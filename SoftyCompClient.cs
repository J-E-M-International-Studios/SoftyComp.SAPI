using RestSharp;
using SoftyComp.SAPI.Models;
using System.Text.Json;

namespace SoftyComp.SAPI
{
    public class SoftyCompClient
    {
        private readonly string _apiKey;
        private readonly string _apiSecret;
        private readonly string _baseUrl;
        private string? _token;
        private DateTime _tokenExpiry;
        private readonly RestClient _client;

        public SoftyCompClient(string baseUrl, string apiKey, string apiSecret)
        {
            _apiKey = apiKey;
            _apiSecret = apiSecret;
            _baseUrl = baseUrl.TrimEnd('/') + "/auth/generatetoken";
            _client = new RestClient(new RestClientOptions(_baseUrl) { MaxTimeout = -1 });
        }

        public async Task<string> GetTokenAsync()
        {
            if (!string.IsNullOrEmpty(_token) && DateTime.UtcNow < _tokenExpiry)
                return _token;

            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer Generated Bearer Token"); // placeholder

            var payload = new { apiKey = _apiKey, apiSecret = _apiSecret };
            request.AddJsonBody(payload);

            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
                throw new Exception("Failed to retrieve token: " + response.Content);

            var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(response.Content);
            _token = tokenResponse?.token;
            _tokenExpiry = tokenResponse?.expiration ?? DateTime.UtcNow.AddMinutes(-1);

            return _token!;
        }

        public async Task<AvsResponse> RequestAvsAuthenticationAsync(AvsRequest requestModel)
        {
            var token = await GetTokenAsync();
            var client = new RestClient(_baseUrl.Replace("/auth/generatetoken", ""));
            var request = new RestRequest("avs/requestAvsAuthentication", Method.Post);
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(requestModel);

            var response = await client.ExecuteAsync<AvsResponse>(request);
            if (!response.IsSuccessful)
                throw new Exception("AVS Request failed: " + response.Content);

            return response.Data!;
        }

        public async Task<PayByLinkResponse> CreatePayByLinkAsync(PayByLinkRequest requestModel)
        {
            var token = await GetTokenAsync();
            var client = new RestClient(_baseUrl.Replace("/auth/generatetoken", ""));
            var request = new RestRequest("cardpayments/createpaybylink", Method.Post);
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(requestModel);

            var response = await client.ExecuteAsync<PayByLinkResponse>(request);
            if (!response.IsSuccessful)
                throw new Exception($"Card Payment request failed: {response.Content}");

            return response.Data!;
        }

        public async Task<CdvResponse> ValidateBankDetailsAsync(CdvRequest requestModel)
        {
            var token = await GetTokenAsync();
            var client = new RestClient(_baseUrl.Replace("/auth/generatetoken", ""));
            var request = new RestRequest("cdv/validatebankdetails", Method.Post);
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(requestModel);

            var response = await client.ExecuteAsync<CdvResponse>(request);
            if (!response.IsSuccessful)
                throw new Exception($"CDV validation failed: {response.Content}");

            return response.Data!;
        }
        public async Task<DebiCheckResponse> SubmitDebiCheckAsync(DebiCheckRequest requestModel)
        {
            var token = await GetTokenAsync();
            var client = new RestClient(_baseUrl.Replace("/auth/generatetoken", ""));
            var request = new RestRequest("debicheck/submitmandate", Method.Post);
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(requestModel);

            var response = await client.ExecuteAsync<DebiCheckResponse>(request);
            if (!response.IsSuccessful)
                throw new Exception($"DebiCheck request failed: {response.Content}");

            return response.Data!;
        }

        public async Task<DebitOrderResponse> SubmitDebitOrderAsync(DebitOrderRequest requestModel)
        {
            var token = await GetTokenAsync();
            var client = new RestClient(_baseUrl.Replace("/auth/generatetoken", ""));
            var request = new RestRequest("debitorders/submitorder", Method.Post);
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(requestModel);

            var response = await client.ExecuteAsync<DebitOrderResponse>(request);
            if (!response.IsSuccessful)
                throw new Exception($"Debit Order request failed: {response.Content}");

            return response.Data!;
        }

        public async Task<EftSecureResponse> SubmitEftSecureAsync(EftSecureRequest requestModel)
        {
            var token = await GetTokenAsync();
            var client = new RestClient(_baseUrl.Replace("/auth/generatetoken", ""));
            var request = new RestRequest("eftsecure/submitpayment", Method.Post);
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(requestModel);

            var response = await client.ExecuteAsync<EftSecureResponse>(request);
            if (!response.IsSuccessful)
                throw new Exception($"EFTSecure request failed: {response.Content}");

            return response.Data!;
        }


        public async Task<MobiMandateResponse> CreateMobiMandateAsync(MobiMandateRequest requestModel)
        {
            var token = await GetTokenAsync();
            var client = new RestClient(_baseUrl.Replace("/auth/generatetoken", ""));
            var request = new RestRequest("mobimandates/create", Method.Post);
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(requestModel);

            var response = await client.ExecuteAsync<MobiMandateResponse>(request);
            if (!response.IsSuccessful)
                throw new Exception($"Mobi-Mandate creation failed: {response.Content}");

            return response.Data!;
        }

    }





}
