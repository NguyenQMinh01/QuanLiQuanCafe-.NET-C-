using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestDangNhap
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest_DangNhap
    {
        public CodedUITest_DangNhap()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463



       
            this.UIMap.RecordedMethod5();

            this.UIMap.AssertMethod2();



        }

        [TestMethod]
        public void CodedUITestMethod2()
        {

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            string user = "nv01";
            string pass = "admin";
            string trangthai = "Đăng nhập thành công";
            this.UIMap.RecordedMethod5Params.UITxtuserEditText = user.ToString();
            this.UIMap.RecordedMethod5Params.UITxtpassEditText = pass.ToString();
            this.UIMap.AssertMethod2ExpectedValues.UITxtTrangThaiEditControlName = trangthai.ToString();
            this.UIMap.RecordedMethod5();
            this.UIMap.AssertMethod2();



        }

        [TestMethod]
        public void CodedUITestMethod3()
        {

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463



            string user = "";
            string pass = "";
            string trangthai = "Tài khoản đăng nhập chưa đúng";
            this.UIMap.RecordedMethod5Params.UITxtuserEditText = user.ToString();
            this.UIMap.RecordedMethod5Params.UITxtpassEditText = pass.ToString();
            this.UIMap.AssertMethod2ExpectedValues.UITxtTrangThaiEditControlName = trangthai.ToString();
            this.UIMap.RecordedMethod6();
            this.UIMap.AssertMethod3();



        }



        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
