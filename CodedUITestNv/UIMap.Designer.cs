﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestNv
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1_nv
        /// </summary>
        public void RecordedMethod1_nv()
        {
            #region Variable Declarations
            WinMenuItem uINhậpDữLiệuMenuItem = this.UIQuảnLýQuánCafeWindow.UIMenuStrip1MenuBar.UINhậpDữLiệuMenuItem;
            WinWindow uIMenuStrip1Window = this.UIQuảnLýQuánCafeWindow.UIQuảnLýQuánCafeClient.UIMenuStrip1Window;
            WinMenuItem uINhânViênMenuItem = this.UIQuảnLýQuánCafeWindow.UIMenuStrip1MenuBar.UINhậpDữLiệuMenuItem.UINhânViênMenuItem;
            WinMenuItem uIKháchHàngMenuItem = this.UIQuảnLýQuánCafeWindow.UIMenuStrip1MenuBar.UINhậpDữLiệuMenuItem.UIKháchHàngMenuItem;
            #endregion

            // Click 'Nhập Dữ Liệu' menu item
            
            uINhậpDữLiệuMenuItem.SetFocus();


            // Click 'menuStrip1' window
            uINhậpDữLiệuMenuItem.SetFocus();
            
            //// Click 'Nhập Dữ Liệu' -> 'Nhân Viên' menu item
            //Mouse.Click(uINhânViênMenuItem, new Point(0, 0));

            //// Click 'menuStrip1' window
            //Mouse.Click(uIMenuStrip1Window, new Point(202, 26));

            //// Click 'Nhập Dữ Liệu' -> 'Khách Hàng' menu item
            //Mouse.Click(uIKháchHàngMenuItem, new Point(0, 0));
        }
        
        #region Properties
        public UIQuảnLýQuánCafeWindow UIQuảnLýQuánCafeWindow
        {
            get
            {
                if ((this.mUIQuảnLýQuánCafeWindow == null))
                {
                    this.mUIQuảnLýQuánCafeWindow = new UIQuảnLýQuánCafeWindow();
                }
                return this.mUIQuảnLýQuánCafeWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIQuảnLýQuánCafeWindow mUIQuảnLýQuánCafeWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIQuảnLýQuánCafeWindow : WinWindow
    {
        
        public UIQuảnLýQuánCafeWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Quản Lý Quán Cafe";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Quản Lý Quán Cafe");
            #endregion
        }
        
        #region Properties
        public UIMenuStrip1MenuBar UIMenuStrip1MenuBar
        {
            get
            {
                if ((this.mUIMenuStrip1MenuBar == null))
                {
                    this.mUIMenuStrip1MenuBar = new UIMenuStrip1MenuBar(this);
                }
                return this.mUIMenuStrip1MenuBar;
            }
        }
        
        public UIQuảnLýQuánCafeClient UIQuảnLýQuánCafeClient
        {
            get
            {
                if ((this.mUIQuảnLýQuánCafeClient == null))
                {
                    this.mUIQuảnLýQuánCafeClient = new UIQuảnLýQuánCafeClient(this);
                }
                return this.mUIQuảnLýQuánCafeClient;
            }
        }
        #endregion
        
        #region Fields
        private UIMenuStrip1MenuBar mUIMenuStrip1MenuBar;
        
        private UIQuảnLýQuánCafeClient mUIQuảnLýQuánCafeClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIMenuStrip1MenuBar : WinMenuBar
    {
        
        public UIMenuStrip1MenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "menuStrip1";
            this.WindowTitles.Add("Quản Lý Quán Cafe");
            #endregion
        }
        
        #region Properties
        public UINhậpDữLiệuMenuItem UINhậpDữLiệuMenuItem
        {
            get
            {
                if ((this.mUINhậpDữLiệuMenuItem == null))
                {
                    this.mUINhậpDữLiệuMenuItem = new UINhậpDữLiệuMenuItem(this);
                }
                return this.mUINhậpDữLiệuMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UINhậpDữLiệuMenuItem mUINhậpDữLiệuMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UINhậpDữLiệuMenuItem : WinMenuItem
    {
        
        public UINhậpDữLiệuMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Nhập Dữ Liệu";
            this.WindowTitles.Add("Quản Lý Quán Cafe");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UINhânViênMenuItem
        {
            get
            {
                if ((this.mUINhânViênMenuItem == null))
                {
                    this.mUINhânViênMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUINhânViênMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Nhân Viên";
                    this.mUINhânViênMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUINhânViênMenuItem.WindowTitles.Add("Quản Lý Quán Cafe");
                    #endregion
                }
                return this.mUINhânViênMenuItem;
            }
        }
        
        public WinMenuItem UIKháchHàngMenuItem
        {
            get
            {
                if ((this.mUIKháchHàngMenuItem == null))
                {
                    this.mUIKháchHàngMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIKháchHàngMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Khách Hàng";
                    this.mUIKháchHàngMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIKháchHàngMenuItem.WindowTitles.Add("Quản Lý Quán Cafe");
                    #endregion
                }
                return this.mUIKháchHàngMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUINhânViênMenuItem;
        
        private WinMenuItem mUIKháchHàngMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIQuảnLýQuánCafeClient : WinClient
    {
        
        public UIQuảnLýQuánCafeClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Quản Lý Quán Cafe";
            this.WindowTitles.Add("Quản Lý Quán Cafe");
            #endregion
        }
        
        #region Properties
        public WinWindow UIMenuStrip1Window
        {
            get
            {
                if ((this.mUIMenuStrip1Window == null))
                {
                    this.mUIMenuStrip1Window = new WinWindow(this);
                    #region Search Criteria
                    this.mUIMenuStrip1Window.SearchProperties[WinWindow.PropertyNames.Name] = "menuStrip1";
                    this.mUIMenuStrip1Window.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
                    this.mUIMenuStrip1Window.WindowTitles.Add("Quản Lý Quán Cafe");
                    #endregion
                }
                return this.mUIMenuStrip1Window;
            }
        }
        #endregion
        
        #region Fields
        private WinWindow mUIMenuStrip1Window;
        #endregion
    }
}
