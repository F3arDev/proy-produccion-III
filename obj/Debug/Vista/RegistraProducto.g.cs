﻿#pragma checksum "..\..\..\Vista\RegistraProducto.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A4AC73555A30022C40D7713EE7D5E68B1B07DD82EAE679C9079E56AADF734F5B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Software_de_Producción.Vista;
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


namespace Software_de_Producción.Vista {
    
    
    /// <summary>
    /// RegistraProducto
    /// </summary>
    public partial class RegistraProducto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Vista\RegistraProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridTop;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Vista\RegistraProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minimizar;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Vista\RegistraProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cerrar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Vista\RegistraProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Vista\RegistraProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioVenta;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Vista\RegistraProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioCompra;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Vista\RegistraProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInventario;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Vista\RegistraProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrar;
        
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
            System.Uri resourceLocater = new System.Uri("/Software de Producción;component/vista/registraproducto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vista\RegistraProducto.xaml"
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
            
            #line 16 "..\..\..\Vista\RegistraProducto.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridTop = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Minimizar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Vista\RegistraProducto.xaml"
            this.Minimizar.Click += new System.Windows.RoutedEventHandler(this.Minimizar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Cerrar = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Vista\RegistraProducto.xaml"
            this.Cerrar.Click += new System.Windows.RoutedEventHandler(this.Cerrar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\Vista\RegistraProducto.xaml"
            this.txtNombre.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\Vista\RegistraProducto.xaml"
            this.txtNombre.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPrecioVenta = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\Vista\RegistraProducto.xaml"
            this.txtPrecioVenta.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtPrecioVenta_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\Vista\RegistraProducto.xaml"
            this.txtPrecioVenta.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtPrecioVenta_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtPrecioCompra = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\Vista\RegistraProducto.xaml"
            this.txtPrecioCompra.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtPrecioCompra_KeyDown);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\Vista\RegistraProducto.xaml"
            this.txtPrecioCompra.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtPrecioCompra_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtInventario = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\Vista\RegistraProducto.xaml"
            this.txtInventario.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtInventario_KeyDown);
            
            #line default
            #line hidden
            
            #line 70 "..\..\..\Vista\RegistraProducto.xaml"
            this.txtInventario.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtInventario_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnRegistrar = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Vista\RegistraProducto.xaml"
            this.btnRegistrar.Click += new System.Windows.RoutedEventHandler(this.btnRegistrar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

