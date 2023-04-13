namespace StoresG8.API.Services
{
    using StoresG8.Shared.Responses;

    namespace Stores.API.Services
    {
        public interface IApiService
        {
            Task<Response> GetListAsync<T>(string servicePrefix, string controller);
        }
    }

}
