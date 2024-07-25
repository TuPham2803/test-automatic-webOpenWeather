using Microsoft.VisualStudio.TestTools.UnitTesting;
using _62_Tu_NunitTestPTBac2;
using System;

namespace _62_Tu_PTBac2Tester
{
    [TestClass]
    public class UnitTestPTBac2_Tu62
    {
        public TestContext TestContext { get; set; }

        [TestMethod]// TestCase TC001- Phuong trinh vo so nghiem//a= 0, b=0, c=0 , expected = "Phuong trinh vo so nghiem!"
        public void TC001_VoSoNghiem_Tu62()
        {
            string expected, actual;
            PTBac2_Tu62 pt = new PTBac2_Tu62(0, 0, 0);
            actual = pt.Execute_Tu62(0, 0, 0);
            expected = "Phuong trinh vo so nghiem!";
            Assert.AreEqual(expected, actual, "TestCase khong thanh cong! ");
        }

        [TestMethod]// TestCase TC002- Phuong trinh vo nghiem // a=1, b=1, c=1, expected = "Phuong trinh vo nghiem!"
        public void TC002_VoNghiem_Tu62()
        {
            string expected, actual;
            PTBac2_Tu62 pt = new PTBac2_Tu62(1, 1, 1);
            actual = pt.Execute_Tu62(1, 1, 1);
            expected = "Phuong trinh vo nghiem!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]// TestCase TC003- Phuong trinh co 2 nghiem// a=1,b=-5,c=6, expected =""Phuong trinh co 2 nghiem: " + "x1= " + 3 + ", x2= " + 2;
        public void TC003_Co2NgiemPhanBiet_Tu62()
        {
            string expected, actual;
            PTBac2_Tu62 pt = new PTBac2_Tu62(1, -5, 6);
            actual = pt.Execute_Tu62(1, -5, 6);
            expected = "Phuong trinh co 2 nghiem: " + "x1= " + 3 + ", x2= " + 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]// TestCase TC004- Phuong trinh  nghiem kep //a=1,b=2,c=1, expected ="Phuong trinh co  nghiem kep: " + "x1=x2= " + -1"
        public void TC004_CoNghiemKep_Tu62()
        {
            string expected, actual;
            PTBac2_Tu62 pt = new PTBac2_Tu62(1, 2, 1);
            actual = pt.Execute_Tu62(1, 2, 1);
            expected = "Phuong trinh co nghiem kep: " + "x1=x2= " + -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]// TestCase TC005- Phuong trinh 1 nghiem // a=0,b=2,c=4, expected ="Phuong trinh co 1 nghiem!: " + -2;
        public void TC005_Co1nghiem_Tu62()
        {
            string expected, actual;
            PTBac2_Tu62 pt = new PTBac2_Tu62(0, 2, 4);
            actual = pt.Execute_Tu62(0, 2, 4);
            expected = "Phuong trinh co 1 nghiem!: " + -2;
            Assert.AreEqual(expected, actual);
        }

      




        // Lien ket Testdata voi project

        [TestMethod]// TestCase TC2001- Phuong trinh vo so nghiem//a= 0, b=0, c=0 , expected = "Phuong trinh vo so nghiem!
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data_Tu62\Data_PTBac2_Tu62.csv",
            "Data_PTBac2_Tu62#csv", DataAccessMethod.Sequential)]
        public void TC001_TestData_Tu62()
        {
            double a, b, c;
            string expected, actual;
            a = double.Parse(TestContext.DataRow[0].ToString());
            b = double.Parse(TestContext.DataRow[1].ToString());
            c = double.Parse(TestContext.DataRow[2].ToString());
            PTBac2_Tu62 pt = new PTBac2_Tu62(a, b, c);
            actual = pt.Execute_Tu62(a, b, c);
            expected = TestContext.DataRow[3].ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}
