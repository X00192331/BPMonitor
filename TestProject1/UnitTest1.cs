using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBloodPressure_Low()
        {
            BloodPressure bp1 = new BloodPressure();
            bp1.Diastolic = 50;
            bp1.Systolic = 80;

            Assert.AreEqual(bp1.Category, BPCategory.Low);
        }
        [TestMethod]
        public void TestBloodPressure_Ideal()
        {
            BloodPressure bp2 = new BloodPressure();
            bp2.Diastolic = 60;
            bp2.Systolic = 100;
            
            Assert.AreEqual(bp2.Category, BPCategory.Ideal);
        }

        [TestMethod]
        public void TestBloodPressure_PreHigh()
        {
            BloodPressure bp3 = new BloodPressure();
            bp3.Diastolic = 80;
            bp3.Systolic = 130;

            Assert.AreEqual(bp3.Category, BPCategory.PreHigh);
        }

        [TestMethod]
        public void TestBloodPressure_High()
        {
            BloodPressure bp4 = new BloodPressure();
            bp4.Diastolic = 80;
            bp4.Systolic = 150;

            Assert.AreEqual(bp4.Category, BPCategory.High);
        }
    }
}
