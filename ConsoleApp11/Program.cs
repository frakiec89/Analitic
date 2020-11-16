using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Analitic analitic = new Analitic();


           var s =  analitic.GetDateTimes(new List<DateTime>() 
            {
                DateTime.Now.AddDays(2) , DateTime.Now , DateTime.Now.AddHours(1)
            });


            foreach (var item in s)
            {
                Console.WriteLine(item.Date);
            }


            Console.ReadLine();
        }
    }

    public  class  Analitic
    {
        public  List<DateTime> GetDateTimes (List<DateTime>  dates)
        {
            List<DateTime> dateTimes = new List<DateTime>();


            foreach (var item in dates)
            {
                var s = item.GetDateTimeFormats();
                var d = DateTime.Parse(s[0]);

                dateTimes.Add(d);
            }

            var data = from  d  in dateTimes
                       group d by d.Date into g
                       select new { Data = g.Key.Date , Count = g.Count()  };

            data = data.OrderBy(x => x.Count).ThenBy(x=>x.Data).ToList();

            dateTimes.Clear();

            foreach (var item in data)
            {
                dateTimes.Add(item.Data);
            }
            return dateTimes;
        }
    }

}
