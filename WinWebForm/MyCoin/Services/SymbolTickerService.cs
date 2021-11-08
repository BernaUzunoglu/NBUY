using MyCoin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.Services
{
    public class SymbolTickerService : IBinanceReq<BinanceReq24HTicker>
    {
        public string BaseUrl =>  "https://api.binance.com/api/v3/ticker/24hr";

        public BinanceReq24HTicker Result(string param)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, BaseUrl);
            try
            {
                var query = $"{BaseUrl}?symbol={param}";
                HttpResponseMessage resp = client.GetAsync(query).Result;
                if (resp.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"İstek başarısız: {resp.StatusCode}");

                BinanceReq24HTicker resulTicker = JsonConvert.DeserializeObject<BinanceReq24HTicker>(resp.Content.ReadAsStringAsync().Result);
                return resulTicker;
            }
            catch
            {

                throw;
            }
        }
    }
}
