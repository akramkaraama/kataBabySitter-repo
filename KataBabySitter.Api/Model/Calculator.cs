using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KataBabySitter.Api.Model
{
    public class Calculator
    {
        public static int[] GetTimes()
        {
            int[] times = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4 };

            return times;
        }

        //private static List<Rates> GetTimeRates()
        //{
        //    List<Rates> rates = new List<Rates>()
        //    {
        //        new Rates()
        //        {
        //            Id= 1,
        //            Rate = 12
        //        },
        //        new Rates()
        //        {
        //            Id= 2,
        //            Rate = 12
        //        },
        //        new Rates()
        //        {
        //            Id= 3,
        //            Rate = 12.00
        //        },
        //        new Rates()
        //        {
        //            Id= 4,
        //            Rate = 12.00
        //        },
        //        new Rates()
        //        {
        //            Id= 5,
        //            Rate = 8.00
        //        },
        //        new Rates()
        //        {
        //            Id= 6,
        //            Rate = 8.00
        //        },
        //        new Rates()
        //        {
        //            Id= 7,
        //            Rate = 8.00
        //        },
        //        new Rates()
        //        {
        //            Id= 8,
        //            Rate = 16.00
        //        },
        //        new Rates()
        //        {
        //            Id= 9,
        //            Rate = 16.00
        //        },
        //        new Rates()
        //        {
        //            Id= 10,
        //            Rate = 16.00
        //        },
        //        new Rates()
        //        {
        //            Id= 11,
        //            Rate = 16.00
        //        }
        //    };

        //    return rates.ToList();
        //}

        ////public string[] GetRate()
        ////{
        ////    string[] rate = new string[] { "8", "", "12", "16" };

        ////    return rate;
        ////}

        //public static double GetEmployeePay( int startTimeId, int endTimeId)
        //{
        //    double pay = 0.00;
        //    if (startTimeId == endTimeId)
        //    {
        //        return 0.00;
        //    }

        //    if ((startTimeId < 1) && (endTimeId  > 11))
        //    {
        //        return 0.00;
        //    }

        //    for (int i = startTimeId; i <= endTimeId; i++)
        //    {
        //        foreach (var rate in GetTimeRates())
        //        {
        //            if (rate.Id == i)
        //            {
        //                pay += rate.Rate;
        //            }
        //        }
        //    }
        //    return pay;
        //}

    }

    //public class Rates
    //{
    //    public int Id { get; set; }
    //    public double Rate { get; set; }
    //}


}
