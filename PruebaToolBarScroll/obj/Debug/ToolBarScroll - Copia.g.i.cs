﻿#pragma checksum "..\..\ToolBarScroll - Copia.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4D89363CAF35F0BEB4D33B128F4CF948"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using PruebaToolBarScroll;
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


namespace PruebaToolBarScroll {
    
    
    /// <summary>
    /// ToolBarScroll
    /// </summary>
    public partial class ToolBarScroll : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ToolBarScroll - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolbar;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ToolBarScroll - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Left;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ToolBarScroll - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Items;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ToolBarScroll - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Right;
        
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
            System.Uri resourceLocater = new System.Uri("/PruebaToolBarScroll;component/toolbarscroll%20-%20copia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ToolBarScroll - Copia.xaml"
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
            
            #line 8 "..\..\ToolBarScroll - Copia.xaml"
            ((PruebaToolBarScroll.ToolBarScroll)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.toolbar = ((System.Windows.Controls.ToolBar)(target));
            
            #line 10 "..\..\ToolBarScroll - Copia.xaml"
            this.toolbar.Loaded += new System.Windows.RoutedEventHandler(this.ToolBar_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_Left = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\ToolBarScroll - Copia.xaml"
            this.bt_Left.Click += new System.Windows.RoutedEventHandler(this.bt_Left_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Items = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.bt_Right = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\ToolBarScroll - Copia.xaml"
            this.bt_Right.Click += new System.Windows.RoutedEventHandler(this.bt_Right_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

