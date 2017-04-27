using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace seven.trumpets.Domain
{
    public class AlphaDomain
    {
        static AlphaDomain Instance = null;
        protected static void Init(AlphaDomain Domain)
        {
            Instance = Domain;
        }
        public static AlphaDomain Get()
        {
            return Instance;
        }
        
        public AlphaDomain()
        {
            if (null != Instance)
            {
                throw new InvalidOperationException();
            }
            Init(this);
        }
        private HttpClient HttpClient = new HttpClient();
        public void RefreshHttpClient()
        {
            HttpClient?.Dispose();
            HttpClient = new HttpClient();
        }

        public virtual async Task<byte[]> GetByteArrayFromUrlAsync(string Url)
        {
            return await HttpClient.GetByteArrayAsync(Url);
        }
        public async Task<string> GetStringFromUrlAsync(string Url, System.Text.Encoding Encoding)
        {
            var Data = await GetByteArrayFromUrlAsync(Url);
            return Encoding.GetString(Data, 0, Data.Length);
        }
        public async Task<string> GetStringFromUrlAsync(string Url)
        {
            return await GetStringFromUrlAsync(Url, System.Text.Encoding.UTF8);
        }
    }
}
