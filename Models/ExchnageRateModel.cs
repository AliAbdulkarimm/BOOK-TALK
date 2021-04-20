using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BookTalk.Models
{

    public partial class ExchangeRateModel
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("documentation")]
        public Uri Documentation { get; set; }

        [JsonProperty("terms_of_use")]
        public Uri TermsOfUse { get; set; }

        [JsonProperty("time_last_update_unix")]
        public long TimeLastUpdateUnix { get; set; }

        [JsonProperty("time_last_update_utc")]
        public string TimeLastUpdateUtc { get; set; }

        [JsonProperty("time_next_update_unix")]
        public long TimeNextUpdateUnix { get; set; }

        [JsonProperty("time_next_update_utc")]
        public string TimeNextUpdateUtc { get; set; }

        [JsonProperty("base_code")]
        public string BaseCode { get; set; }

        [JsonProperty("conversion_rates")]
        public Dictionary<string, double> ConversionRates { get; set; }
    }

    public partial class ExchangeRateModel
    {
        public static ExchangeRateModel FromJson(string json) => JsonConvert.DeserializeObject<ExchangeRateModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ExchangeRateModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
        };
    }

}
