﻿#pragma checksum "..\..\WhereTheCar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "512257DCE149BA30D0D4F7F28ABC624EE83679B2F260DFCFB9FE2F50EB9592B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CAR_BD2;
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


namespace CAR_BD2 {
    
    
    /// <summary>
    /// WhereTheCar
    /// </summary>
    public partial class WhereTheCar : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\WhereTheCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid avto;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WhereTheCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit_Click;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WhereTheCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WhereTHECar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WhereTheCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddWhereTheCar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WhereTheCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteWhereTheCar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WhereTheCar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateWhereTheCar;
        
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
            System.Uri resourceLocater = new System.Uri("/CAR_BD2;component/wherethecar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WhereTheCar.xaml"
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
            this.avto = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\WhereTheCar.xaml"
            this.avto.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.avto_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exit_Click = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\WhereTheCar.xaml"
            this.exit_Click.Click += new System.Windows.RoutedEventHandler(this.exit_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.WhereTHECar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AddWhereTheCar = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\WhereTheCar.xaml"
            this.AddWhereTheCar.Click += new System.Windows.RoutedEventHandler(this.AddWhereTheCar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteWhereTheCar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\WhereTheCar.xaml"
            this.DeleteWhereTheCar.Click += new System.Windows.RoutedEventHandler(this.DeleteWhereTheCar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UpdateWhereTheCar = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\WhereTheCar.xaml"
            this.UpdateWhereTheCar.Click += new System.Windows.RoutedEventHandler(this.UpdateWhereTheCar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
