﻿#pragma checksum "..\..\OrdersList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2EA9E98C0943BD4C1F529A3C3982B20C"
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
    /// OrdersList
    /// </summary>
    public partial class OrdersList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox carVinFind;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button find;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid orderDataGrid;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn dateColumn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn amountColumn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn statusColumn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addOrder;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteOrder;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editOrder;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\OrdersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showAll;
        
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
            System.Uri resourceLocater = new System.Uri("/InteticsTest;component/orderslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OrdersList.xaml"
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
            
            #line 8 "..\..\OrdersList.xaml"
            ((InteticsTest.OrdersList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.carVinFind = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.find = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\OrdersList.xaml"
            this.find.Click += new System.Windows.RoutedEventHandler(this.find_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.orderDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.dateColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 7:
            this.amountColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.statusColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.addOrder = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\OrdersList.xaml"
            this.addOrder.Click += new System.Windows.RoutedEventHandler(this.addOrder_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.deleteOrder = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\OrdersList.xaml"
            this.deleteOrder.Click += new System.Windows.RoutedEventHandler(this.deleteOrder_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.editOrder = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\OrdersList.xaml"
            this.editOrder.Click += new System.Windows.RoutedEventHandler(this.editOrder_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.showAll = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\OrdersList.xaml"
            this.showAll.Click += new System.Windows.RoutedEventHandler(this.showAll_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

