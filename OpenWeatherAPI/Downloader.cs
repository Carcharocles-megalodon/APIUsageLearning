using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

namespace OpenWeatherAPI
{
    class Downloader
    {
        private HttpClient client;

        public Downloader()
        {
            client = new HttpClient();
        }

        public async Task<Stream> Get(string uri)
        {
            Stream response = await client.GetStreamAsync(uri);
            response.Position = 0;
            return response;
        }
    }
}
