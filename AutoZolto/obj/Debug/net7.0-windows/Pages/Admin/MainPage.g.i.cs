﻿#pragma checksum "..\..\..\..\..\Pages\Admin\MainPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CEAF11111153B6EC434E0B53CB5F44927EC1FA39"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoZolto.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AutoZolto.Pages {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 26 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExit;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbFil;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnActivUser;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNotActivUser;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdmin;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUser;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPostUser;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridUser;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AutoZolto;component/pages/admin/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnExit = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            this.BtnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbFil = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.BtnActivUser = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            this.BtnActivUser.Click += new System.Windows.RoutedEventHandler(this.BtnActivUser_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnNotActivUser = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            this.BtnNotActivUser.Click += new System.Windows.RoutedEventHandler(this.BtnNotActivUser_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            this.BtnAdmin.Click += new System.Windows.RoutedEventHandler(this.BtnAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnUser = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            this.BtnUser.Click += new System.Windows.RoutedEventHandler(this.BtnUser_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnPostUser = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            this.BtnPostUser.Click += new System.Windows.RoutedEventHandler(this.BtnPostUser_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DataGridUser = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 88 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnStatusBad_Click);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 105 "..\..\..\..\..\Pages\Admin\MainPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnStatusActivate_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

