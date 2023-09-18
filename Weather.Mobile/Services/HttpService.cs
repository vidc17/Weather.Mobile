using System.Text;
using Weather.Mobile.Global;

namespace Weather.Mobile.Services
{
    public class HttpService
    {
        public async Task<string> ExecuteRequest(string url, string method)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.None)
                return null;

            var httpCaller = new HttpClient();

            httpCaller.Timeout = TimeSpan.FromSeconds(30);

            var httpMethod = new HttpMethod(method);

            var requestMessage = new HttpRequestMessage(httpMethod, url);

            var responseData = await httpCaller.SendAsync(requestMessage);

            if (responseData == null)
                return null;

            return await responseData.Content.ReadAsStringAsync();
        }
    }
}
