using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CousantAssessment
{
   public class Solution4
    {
        public void GetMondayNews()
        {
            using (HttpClient client = new HttpClient())
            {
                string newsUri = "https://newsapi.org/v2/everything?q=nigeria&apiKey=3574206693d14c8996dbe331bcbc22ad";
                var response = client.GetAsync(newsUri).Result;

                //please install Newtonsoft.json NuGet package and use "Newtonsoft.Json" namespace to resolve the issue below
                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse>(response.Content.ReadAsStringAsync().Result);

                foreach (var item in result.articles)
                {
                    var dayOfWeek = DateTime.Parse(item.publishedAt).DayOfWeek.ToString();

                    if (item.title.Contains("Nigeria") && dayOfWeek == "Monday")
                    {
                        var mainDate = DateTime.Parse(item.publishedAt);
                        var exactDate = $"{mainDate.Day}-{ToShortMonthName(mainDate)}-{mainDate.Year}";
                        Console.WriteLine(item.title + " ........ " + exactDate);
                    }

                }
            }
        }

        public static string ToShortMonthName(DateTime dateTime)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dateTime.Month);
        }

        public class ApiResponse
        {
            public string status { get; set; }
            public string totalResults { get; set; }
            public Article[] articles { get; set; }
        }
        public class Article
        {
            public string title { get; set; }
            public string publishedAt { get; set; }
        }
    }
}
