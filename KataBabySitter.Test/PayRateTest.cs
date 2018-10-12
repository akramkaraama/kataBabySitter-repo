using System;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataBabySitter.Test
{
    [TestClass]
    public class PayRateTest
    {


        enum TimeSlot : byte {
            FivePM = 1,
            SixPM = 2 ,
            SevenPM =3,
            EightPM = 4,
            NinePM = 5,
            TenPM = 6,
            ElevenPm = 7,
            TwelveAM = 8,
            OneAM = 9,
            TwoAM = 10,
            ThreeAM = 11
        };

        [TestMethod]
        public void OutSideWorkHoours()
        {
            //arrange
            var rate = ApiCaller.CallApi((int)TimeSlot.FivePM, (int)TimeSlot.ThreeAM);

            //

            //
        }
    }
}
