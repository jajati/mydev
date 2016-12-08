using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


//namespace StockQuoteDemo
//{
//    public static class YahooFinance
//    {
//        public static List<Price> Parse(string csvData)
//        {
//            List<Price> prices = new List<Price>();

//            string[] rows = csvData.Replace("\n", "").Split('\t');

//         //   string json = JsonConvert.SerializeObject(rows.ToArray());


            
//            foreach (string row in rows)
//            {
//                if (string.IsNullOrEmpty(row)) continue;
               
               

//                string[] cols = row.Split(',');

//              Price p = new Price();
//            //    //p.Symbol = cols[0];
//            //    //p.Name = cols[1];
//            //    //p.Bid = Convert.ToDecimal(cols[2]);
//            //    //p.Ask = Convert.ToDecimal(cols[3]);
//            //    //p.Open = Convert.ToDecimal(cols[4]);
//            //    //p.PreviousClose = Convert.ToDecimal(cols[5]);
//            //    //p.Last = Convert.ToDecimal(cols[6]);


//              p.t = cols[1];
//              p.e = cols[2];
//              p.l = Convert.ToDecimal((cols[3].Split(':')[1]).Replace("'\'",""));
//              p.l_fix = Convert.ToDecimal(cols[4]);
//              p.l_cur = Convert.ToDecimal(cols[5]);
//             // p.PreviousClose = cols[5];
//              p.pcls_fix = Convert.ToDecimal(cols[12]);

//                prices.Add(p);
//            }

//            return prices;
//        }
//    }

//    public class Price
//    {
        
//        public string t { get; set; }
//        public string e { get; set; }
//        public decimal l { get; set; }
//        public decimal l_fix { get; set; }
//        public decimal l_cur { get; set; }
//        public decimal PreviousClose { get; set; }
//        public decimal pcls_fix { get; set; }
       
//    }
//}