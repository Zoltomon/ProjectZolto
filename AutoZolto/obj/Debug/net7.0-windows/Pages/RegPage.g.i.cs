﻿#pragma checksum "..\..\..\..\Pages\RegPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A330DE9B2DA5ACD3DBA21D588CDFF821D73827E"
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
    /// RegPage
    /// </summary>
    public partial class RegPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Pages\RegPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbLog;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\RegPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbPass;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\RegPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbCopyPass;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Pages\RegPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxbBlcPassStrength;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\RegPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider PassStrength;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Pages\RegPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReg;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Pages\RegPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoZolto;component/pages/regpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\RegPage.xaml"
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
            this.TxbLog = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxbPass = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\..\Pages\RegPage.xaml"
            this.TxbPass.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxbPass_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxbCopyPass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxbBlcPassStrength = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PassStrength = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.BtnReg = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\Pages\RegPage.xaml"
            this.BtnReg.Click += new System.Windows.RoutedEventHandler(this.BtnReg_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\Pages\RegPage.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

