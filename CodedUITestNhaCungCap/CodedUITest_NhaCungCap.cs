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


namespace CodedUITestNhaCungCap
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest_NhaCungCap
    {
        public CodedUITest_NhaCungCap()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            this.UIMap.RecordedMethod_SuaNCC();

        }

         [TestMethod]
        public void CodedUITestMethod2_SuaThanhCong()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            string ten = "E";
            string diachi = "TPHCM";
            string sdt = "012345678";
            string trangthai = "Sửa thành công";

            this.UIMap.RecordedMethod_SuaNCCParams.UITxttenEditText = ten.ToString();
            this.UIMap.RecordedMethod_SuaNCCParams.UITxtdcEditText = ten.ToString();
            this.UIMap.RecordedMethod_SuaNCCParams.UITxtdtEditText = ten.ToString();
            this.UIMap.AssertMethod_NCCExpectedValues.UITxtTrangThaiWindowControlName = trangthai.ToString();
            this.UIMap.RecordedMethod_SuaNCC();
            this.UIMap.AssertMethod_NCC();


        }

         [TestMethod]
        public void CodedUITestMethod_Suakhongthanhcong()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            string ten = "E";
            string diachi = "TPHCM";
            string sdt = "B";
            string trangthai = "Sửa không thành công";

            this.UIMap.RecordedMethod_SuaNCCParams.UITxttenEditText = ten.ToString();
            this.UIMap.RecordedMethod_SuaNCCParams.UITxtdcEditText = ten.ToString();
            this.UIMap.RecordedMethod_SuaNCCParams.UITxtdtEditText = ten.ToString();
            this.UIMap.AssertMethod_NCCExpectedValues.UITxtTrangThaiWindowControlName = trangthai.ToString();

            this.UIMap.RecordedMethod_SuaNCC();
            this.UIMap.AssertMethod_NCC();


        }

         [TestMethod]
        public void CodedUITestMethod_Suakhongdetrong()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            string ten = "E";
            string diachi = "";
            string sdt = "012345678";
            string trangthai = "Tên không được để trống";

            this.UIMap.RecordedMethod_SuaNCCParams.UITxttenEditText = ten.ToString();
            this.UIMap.RecordedMethod_SuaNCCParams.UITxtdcEditText = ten.ToString();
            this.UIMap.RecordedMethod_SuaNCCParams.UITxtdtEditText = ten.ToString();
            this.UIMap.AssertMethod_NCCExpectedValues.UITxtTrangThaiWindowControlName = trangthai.ToString();
            this.UIMap.RecordedMethod_SuaNCC();
            this.UIMap.AssertMethod_NCC();


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
