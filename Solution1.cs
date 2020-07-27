using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CousantAssessment
{
   public  class Solution1
    {
        public void PrintCategories()
        {
            var foodCategories = new List<string>();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://drive.google.com/u/0/uc?id=1KR5_pSuSwbF5IH7GD5BtTZn7SZ-xeWhM&export=download");
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            using (var rd = new StreamReader(resp.GetResponseStream()))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(',');
                    var categoryIndex = splits.Length - 1;
                    foodCategories.Add(splits[categoryIndex]);
                }
            }

            var r = from e in foodCategories
                    where e != "CATEGORY"
                    group e by new { e } into g
                    select new
                    {
                        Category = g.Key.e,
                        Count = g.Count()
                    };
            

            //print category in order of highest category count
            foreach (var foodCategory in r.OrderByDescending(x => x.Count))
            {
                Console.WriteLine(foodCategory.Category + " ........ " + foodCategory.Count);
            }
               

        }
    }
}
