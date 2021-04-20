using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using BookTalk.Models;
using System.Net;

public class CurrencyService
{

    private const string baseUrl = "https://v6.exchangerate-api.com/v6/4b6c89bf2900a92bee4f9178/latest/SEK";

    public ExchangeRateModel Rates()
    {
        RestClient client = new RestClient(baseUrl);

        RestRequest request = new RestRequest
        {
            Method = Method.GET
        };

        request.Parameters.Clear();

        IRestResponse response = client.Execute(request);

        if (response.StatusCode == HttpStatusCode.OK)
        {
            ExchangeRateModel model = JsonConvert.DeserializeObject<ExchangeRateModel>(response.Content);
   
            return model;
        }
        else
        {
            return null;
        }

    }

}
