﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C6CACB2E778032C9D38F723A7D7A6E0EAEA2193E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Tema2_Imagen;


namespace Tema2_Imagen {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagen;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock opacidadTextBlock;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton opacidadAltaRadioButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton opacidadMediaRadioButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton opacidadBajaRadioButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Ajuste;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rellenoRadioButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton uniformeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rellenoUniformeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sinAjusteRadioButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tema2-Imagen;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imagen = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.opacidadTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.opacidadAltaRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 34 "..\..\..\MainWindow.xaml"
            this.opacidadAltaRadioButton.Checked += new System.Windows.RoutedEventHandler(this.opacidadAltaRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.opacidadMediaRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 42 "..\..\..\MainWindow.xaml"
            this.opacidadMediaRadioButton.Checked += new System.Windows.RoutedEventHandler(this.opacidadMediaRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.opacidadBajaRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 50 "..\..\..\MainWindow.xaml"
            this.opacidadBajaRadioButton.Checked += new System.Windows.RoutedEventHandler(this.opacidadBajaRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Ajuste = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.rellenoRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 69 "..\..\..\MainWindow.xaml"
            this.rellenoRadioButton.Checked += new System.Windows.RoutedEventHandler(this.RellenoRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.uniformeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 77 "..\..\..\MainWindow.xaml"
            this.uniformeRadioButton.Checked += new System.Windows.RoutedEventHandler(this.uniformeRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rellenoUniformeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 85 "..\..\..\MainWindow.xaml"
            this.rellenoUniformeRadioButton.Checked += new System.Windows.RoutedEventHandler(this.RellenoUniformeRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.sinAjusteRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 92 "..\..\..\MainWindow.xaml"
            this.sinAjusteRadioButton.Checked += new System.Windows.RoutedEventHandler(this.SinAjusteRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
