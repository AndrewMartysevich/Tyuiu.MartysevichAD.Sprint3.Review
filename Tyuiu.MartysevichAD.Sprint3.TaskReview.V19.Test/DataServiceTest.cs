using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint3.TaskReview.V19.Lib;


namespace Tyuiu.MartysevichAD.Sprint3.TaskReview.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] ValueWaitArray;
            ValueWaitArray = new double[len];
            ValueWaitArray[0] = 23.61;
            ValueWaitArray[1] = 16.08;
            ValueWaitArray[2] = 7.84;
            ValueWaitArray[3] = 4.58;
            ValueWaitArray[4] = 2.88;
            ValueWaitArray[5] = 0.75;
            ValueWaitArray[6] = -4.47;
            ValueWaitArray[7] = -9.46;
            ValueWaitArray[8] = -7.41;
            ValueWaitArray[9] = -6.16;
            ValueWaitArray[10] = -7.29;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(ValueWaitArray, res);
        }
    }
}
