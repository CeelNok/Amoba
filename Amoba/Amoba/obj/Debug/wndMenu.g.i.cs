﻿#pragma checksum "..\..\wndMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B5B2FBE96D911A0741DD2C447556FB12CF1471DD295BECF91F07FA3FC91507B3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Amoba;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Amoba {
    
    
    /// <summary>
    /// wndMenu
    /// </summary>
    public partial class wndMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\wndMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btUjjatek;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\wndMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btEredmenyek;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\wndMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btKilep;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Amoba;component/wndmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\wndMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btUjjatek = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\wndMenu.xaml"
            this.btUjjatek.Click += new System.Windows.RoutedEventHandler(this.click_UjJatek);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btEredmenyek = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\wndMenu.xaml"
            this.btEredmenyek.Click += new System.Windows.RoutedEventHandler(this.click_Eredmenyek);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btKilep = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\wndMenu.xaml"
            this.btKilep.Click += new System.Windows.RoutedEventHandler(this.click_Kilep);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

