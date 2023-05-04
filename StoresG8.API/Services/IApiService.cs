   using StoresG8.Shared.Responses;

    namespace StoresG8.API.Services
    {
        public interface IApiService
        {
            Task<Response> GetListAsync<T>(string servicePrefix, string controller);
        }
    }


