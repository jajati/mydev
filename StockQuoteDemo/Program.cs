using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Json;
using Newtonsoft.Json.Linq;

namespace StockQuoteDemo
{
    class Program
    {
        public static string stockPrice(string stck)
        {

             string csvData;
            string stock = stck ;


            //string nationalStock;
            string globalstock;
           // stock = Console.ReadLine();

            using (WebClient web = new WebClient())
            {
                               

                  globalstock = "http://finance.google.com/finance/info?client=ig&q="  + stock;
               
                     csvData = web.DownloadString(globalstock);
                
                            }
            string value = csvData.Replace("//", "").Replace("[", "").Replace("]", "");
          
            JObject response = JObject.Parse(value);
            String CName = Convert.ToString(response["t"]);
            String stockMarketType = Convert.ToString(response["e"]);
            String l = Convert.ToString(response["l"]);
            String l_fix = Convert.ToString(response["l_fix"]);
            String l_cur = Convert.ToString(response["l_cur"]);
           // String pcls_fix = Convert.ToString(response["pcls_fix"]);
            string lt_dts = Convert.ToString(response["lt_dts"]);
            string gain = Convert.ToString(response["c"]);
            string cp = Convert.ToString(response["cp"]);
         //   Console.WriteLine(CName, stockMarketType, l,l_fix, l_cur,  lt_dts,gain,cp);
           // Console.ReadLine();



        

            return value;
        }
        static void Main(string[] args)
        {
            string output = Program.stockPrice("IBM");
          Console.WriteLine(output);
          Console.ReadLine();

        }
    }
}

