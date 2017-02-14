using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProject;
using System.Collections.Generic;

namespace Test_v1
{
    [TestClass]
    public class UnitTest1
    {
        private MyClass TestClass;

        [TestInitialize]
        public void Init()
        {
            TestClass = new MyClass();
        }

        [TestMethod]
        public void NotNull()
        {
            //arrange
            List<double> vector = new List<double>();

            vector.Add(1);
            vector.Add(2);
            vector.Add(3);

            //act 
            List<double> exp_res = new List<double>();
            exp_res.Add(1);
            exp_res.Add(2);
            exp_res.Add(3);

            List<double> RealRes = TestClass.increment_vector(vector);

            CollectionAssert.AllItemsAreNotNull(RealRes);

        }

        [TestMethod]
        public void TestCorrectResult()
        {
            //arrange
            List<double> vector = new List<double>();

            vector.Add(1);
            vector.Add(2);
            vector.Add(3);

            //act 
            List<double> exp_res = new List<double>();
            exp_res.Add(2);
            exp_res.Add(3);
            exp_res.Add(4);

            List<double> RealRes = TestClass.increment_vector(vector);

            CollectionAssert.AreEqual(exp_res, RealRes);

        }
        [TestMethod]
        public void TestOneType()
        {
            //arrange
            List<double> vector = new List<double>();

            vector.Add(1);
            vector.Add(2);
            vector.Add(3);

            //act 
            List<double> exp_res = new List<double>();
            exp_res.Add(1);
            exp_res.Add(2);
            exp_res.Add(3);

            List<double> RealRes = TestClass.increment_vector(vector);
            double x=0;
            CollectionAssert.AllItemsAreInstancesOfType(RealRes, x.GetType());
        }
    }
}
