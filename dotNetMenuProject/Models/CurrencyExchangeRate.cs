using System;
namespace dotNetMenuProject.Models
{
	public class CurrencyExchangeRate
	{
        public string Status { get; set; }
        public string Message { get; set; }
        public string MessageTR { get; set; }
        public long SystemTime { get; set; }
        public string Endpoint { get; set; }
        public int RowCount { get; set; }
        public int CreditUsed { get; set; }
        public List<ExchangeData> Data { get; set; } // Changed to List<ExchangeData>

        public class ExchangeData
        {
            public string Code { get; set; }
            public string ShortName { get; set; }
            public string FullName { get; set; }
            public double Buying { get; set; }
            public double Selling { get; set; }
            public double Latest { get; set; }
            public double ChangeRate { get; set; }
            public double DayMin { get; set; }
            public double DayMax { get; set; }
            public string LastUpdate { get; set; }
        }

    }
}

