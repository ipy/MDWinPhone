﻿#pragma checksum "C:\Users\zhong_000\Desktop\wpMingdao - 副本\mdPhone\View\mainPart\home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4DF3BEAE0E79BD62441ADFD5B9B5E8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Phone.Controls;
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


namespace mdPhone.View.mainPart {
    
    
    public partial class home : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Image uerImg;
        
        internal System.Windows.Controls.TextBlock userName;
        
        internal System.Windows.Controls.TextBlock companyName;
        
        internal Coding4Fun.Phone.Controls.Tile post;
        
        internal Coding4Fun.Phone.Controls.Tile po1st;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/mdPhone;component/View/mainPart/home.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.uerImg = ((System.Windows.Controls.Image)(this.FindName("uerImg")));
            this.userName = ((System.Windows.Controls.TextBlock)(this.FindName("userName")));
            this.companyName = ((System.Windows.Controls.TextBlock)(this.FindName("companyName")));
            this.post = ((Coding4Fun.Phone.Controls.Tile)(this.FindName("post")));
            this.po1st = ((Coding4Fun.Phone.Controls.Tile)(this.FindName("po1st")));
        }
    }
}

