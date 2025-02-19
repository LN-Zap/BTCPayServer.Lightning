using System;
using BTCPayServer.Lightning.JsonConverters;
using Newtonsoft.Json;

namespace BTCPayServer.Lightning.LNbank.Models
{
    public class CreateInvoiceRequest
    {
        public string Description { get; set; }

        [JsonConverter(typeof(LightMoneyJsonConverter))]
        public LightMoney Amount { get; set; }

        public TimeSpan Expiry { get; set; }
        public bool PrivateRouteHints { get; set; }
    }
}
