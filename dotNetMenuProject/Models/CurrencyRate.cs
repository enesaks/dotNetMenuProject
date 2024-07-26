using System;
namespace dotNetMenuProject.Models
{
    public class CurrencyRateModel
    {
        public CurrencyRateData Data { get; set; }
    }

    public class CurrencyRateData
    {
        public CurrencyRateInformations Informations { get; set; }
        public List<CurrencyRate> CurrencyRates { get; set; }
    }

    public class CurrencyRateInformations
    {
        public string LastUpdateTime { get; set; }
        public long LastUpdateTimeUnix { get; set; }
        public string Timezone { get; set; }
    }

    public class CurrencyRate
    {
        public string CrossOrder { get; set; }
        public string Code { get; set; }
        public string CurrencyCode { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }
        public string CurrencyName { get; set; }
        public string ForexBuying { get; set; }
        public string ForexSelling { get; set; }
        public string BanknoteBuying { get; set; }
        public string BanknoteSelling { get; set; }
        public string CrossRateUsd { get; set; }
        public string CrossRateOther { get; set; }
    }


}
