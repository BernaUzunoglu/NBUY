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
    public class ExchangeInfoService : IBinanceReq<BinanceReqExchangBody>
    {
        //private const string BaseUrl = "https://api.binance.com/api/v3/exchangeInfo";
        //public BinanceReqExchangBody Result { get; set; }
        public string BaseUrl => "https://api.binance.com/api/v3/exchangeInfo";

        public BinanceReqExchangBody Result(string param=null)
        {
            HttpClient client  = new HttpClient();

            try
            {
                HttpResponseMessage result= client.GetAsync(new Uri(BaseUrl)).Result;
                if (result.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"İstek başarısız :{result.StatusCode}");

                BinanceReqExchangBody body = JsonConvert.DeserializeObject<BinanceReqExchangBody>(result.Content.ReadAsStringAsync().Result);
                return body;
            }
            catch 
            {

                throw;
            }
        }
    }
}
