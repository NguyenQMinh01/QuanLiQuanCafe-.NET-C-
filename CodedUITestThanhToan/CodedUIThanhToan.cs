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


namespace CodedUITestThanhToan
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUIThanhToan
    {
        public CodedUIThanhToan()
        {
        }

        [TestMethod]
        public void CodedUITestMethod_ThanhToanThanhCong()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
           
            string tienkhachdua = "30000";
            string trangthai = "Thanh toán thành công";
            this.UIMap.RecordedMethod_ThanhToan1Params.UITxtTienKhachDuaEditText = tienkhachdua.ToString();
            this.UIMap.AssertMethod_ThanhToanExpectedValues.UITxtTongTienThanhToanWindowControlName = trangthai.ToString();
            this.UIMap.RecordedMethod_ThanhToan1();
            this.UIMap.AssertMethod_ThanhToan1();



        }


        [TestMethod]
        public void CodedUITestMethod_ThanhToanKhongThanhCong()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            string tienkhachdua = "20000";
            string trangthai = "Thanh toán không thành công";
            this.UIMap.RecordedMethod_ThanhToan1Params.UITxtTienKhachDuaEditText = tienkhachdua.ToString();
            this.UIMap.AssertMethod_ThanhToanExpectedValues.UITxtTongTienThanhToanWindowControlName = trangthai.ToString();
            this.UIMap.RecordedMethod_ThanhToan1();
            this.UIMap.AssertMethod_ThanhToan1();


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
