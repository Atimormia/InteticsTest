﻿#pragma checksum "..\..\..\UI\CarsList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "558CEC4F38EB30170781334FA724A526"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InteticsTest;
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


namespace InteticsTest {
    
    
    /// <summary>
    /// CarsList
    /// </summary>
    public partial class CarsList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid carDataGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn makeColumn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn modelColumn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn yearColumn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn vinColumn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientSurname;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addCar;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteCar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editCar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UI\CarsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button chooseCar;
        
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
            System.Uri resourceLocater = new System.Uri("/InteticsTest;component/ui/carslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\CarsList.xaml"
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
            
            #line 8 "..\..\..\UI\CarsList.xaml"
            ((InteticsTest.CarsList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.carDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.makeColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.modelColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.yearColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.vinColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.clientName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.clientSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.addCar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\UI\CarsList.xaml"
            this.addCar.Click += new System.Windows.RoutedEventHandler(this.addCar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.deleteCar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UI\CarsList.xaml"
            this.deleteCar.Click += new System.Windows.RoutedEventHandler(this.deleteCar_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.editCar = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UI\CarsList.xaml"
            this.editCar.Click += new System.Windows.RoutedEventHandler(this.editCar_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.chooseCar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\UI\CarsList.xaml"
            this.chooseCar.Click += new System.Windows.RoutedEventHandler(this.chooseCar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
