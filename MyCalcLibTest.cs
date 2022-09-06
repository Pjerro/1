using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;

namespace MyCalcLibTest
{
    [TestClass]
    public class MyCalcTest
   
    { /// <summary>
    /// сложение
    /// </summary>
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange
            int x = 10, y = 20;
            int expected = 30;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// вычитание
        /// </summary>
        [TestMethod]
        public void Razn_15and8_7returned()
        {
            //arrange
            int a = 15, b = 8;
            int expected = 7;

            //act
            MyCalc d = new MyCalc();
            int actual = d.Razn(a, b);

            //assert
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// умножение
        /// </summary>

        [TestMethod]
        public void Umn_5and7_35returned() 
        { 
        
            //arrange
           int e = 5, f = 7;
        int expected = 35;

        //act
        MyCalc w = new MyCalc();
        int actual = w.Umn(e, f);

        //assert
        Assert.AreEqual(expected, actual);
          
        }
        /// <summary>
        /// деление
        /// </summary>
        [TestMethod]
        
        public void Del_10and2_5returned()
        {
            //arrange
            int o = 10, p = 2;
            int expected = 5;

            //act
            MyCalc q = new MyCalc();
            int actual = q.Del(o, p);

            //assert
            Assert.AreEqual(expected, actual);

        }
        
    }
}
