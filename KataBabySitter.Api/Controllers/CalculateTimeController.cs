using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KataBabySitter.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace KataBabySitter.Api.Controllers
{
    [Route("api/[controller]")]
    public class CalculateTimeController : Controller
    {
        // POST api/values
        //[HttpPost]
        //public string Post([FromBody] WorkTime workTime)
        //{
        //    if (workTime.StartTime == workTime.EndTime)
        //    {
        //        return "Wrong Entry";
        //    }

        //    int bedTime = 9;
        //    int midnight = 12;

        //    var times = Calculator.GetTimes();
            
        //    var beginIndex = Array.FindIndex(times, item => item == workTime.StartTime);
        //    var endIndex = Array.FindIndex(times, item => item == workTime.EndTime);
        //    int arrLength = endIndex - beginIndex;
        //    if (arrLength < 0)
        //    {
        //        return "Wrong Entry";
        //    }
        //    int[] timeRange = new int[arrLength];
        //    Array.Copy(times, beginIndex, timeRange, 0, arrLength);

        //    var rate = 0;
        //    if (times.Contains(workTime.StartTime) && times.Contains(workTime.EndTime))
        //    {
        //        if ((workTime.StartTime != 4) && (workTime.EndTime != 5))
        //        {
        //            foreach (int val in timeRange)
        //            {
        //                if ((val < bedTime && val >= times[0]) && (val >= workTime.StartTime))
        //                {
        //                    rate += 12;
        //                }
        //                if (val >= bedTime && val < midnight)
        //                {
        //                    rate += 8;
        //                }
        //                if (val < times[11] || val == midnight)
        //                {
        //                    rate += 16;
        //                }
        //            }
        //        }
        //        return "Your Pay is: $" + rate.ToString();
        //    }
        //    else
        //    {
        //        return "Wrong Entry!";
        //    }
        //}

        [HttpPost]
        public double Post([FromBody] WorkTime workTime)
        {
            double pay = Calculator.GetEmployeePay(workTime.StartTime, workTime.EndTime);

            return pay;
        }
    }
}
