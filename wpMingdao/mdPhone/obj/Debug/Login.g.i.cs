﻿#pragma checksum "C:\Users\zhong_000\Desktop\wpMingdao - 副本\mdPhone\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DB094840AE1DCB02D8AA981081FD70E"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using mdPhone.Controls.WatermarkedTextBox;


namespace mdPhone {
    
    
    public partial class Login : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock mySelf;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Grid login;
        
        internal mdPhone.Controls.WatermarkedTextBox.WatermarkedTextBox txtUserEmail;
        
        internal System.Windows.Controls.PasswordBox txtPasswrod;
        
        internal System.Windows.Controls.TextBlock txtPassWordTip;
        
        internal System.Windows.Shapes.Rectangle btnLogin;
        
        internal System.Windows.Controls.CheckBox rememberPwd;
        
        internal System.Windows.Controls.Grid loginAnimate;
        
        internal System.Windows.Controls.Grid manyProject;
        
        internal System.Windows.Controls.ListBox netsImtes;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/mdPhone;component/Login.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.mySelf = ((System.Windows.Controls.TextBlock)(this.FindName("mySelf")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.login = ((System.Windows.Controls.Grid)(this.FindName("login")));
            this.txtUserEmail = ((mdPhone.Controls.WatermarkedTextBox.WatermarkedTextBox)(this.FindName("txtUserEmail")));
            this.txtPasswrod = ((System.Windows.Controls.PasswordBox)(this.FindName("txtPasswrod")));
            this.txtPassWordTip = ((System.Windows.Controls.TextBlock)(this.FindName("txtPassWordTip")));
            this.btnLogin = ((System.Windows.Shapes.Rectangle)(this.FindName("btnLogin")));
            this.rememberPwd = ((System.Windows.Controls.CheckBox)(this.FindName("rememberPwd")));
            this.loginAnimate = ((System.Windows.Controls.Grid)(this.FindName("loginAnimate")));
            this.manyProject = ((System.Windows.Controls.Grid)(this.FindName("manyProject")));
            this.netsImtes = ((System.Windows.Controls.ListBox)(this.FindName("netsImtes")));
        }
    }
}

