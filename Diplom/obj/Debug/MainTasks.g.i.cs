﻿#pragma checksum "..\..\MainTasks.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2A5748B45ED7832B0DD6EE7585FF8D4C1FC5CA0FAE615D0480852ABB884468D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Diplom;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Diplom {
    
    
    /// <summary>
    /// MainTasks
    /// </summary>
    public partial class MainTasks : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllTask;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTask1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTask2;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTask3;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnWorker;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DTGridClient;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRemove;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPriority;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWorker;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/Diplom;component/maintasks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainTasks.xaml"
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
            
            #line 10 "..\..\MainTasks.xaml"
            ((Diplom.MainTasks)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AllTask = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\MainTasks.xaml"
            this.AllTask.Click += new System.Windows.RoutedEventHandler(this.AllTask_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnTask1 = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\MainTasks.xaml"
            this.btnTask1.Click += new System.Windows.RoutedEventHandler(this.btnTask1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnTask2 = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\MainTasks.xaml"
            this.btnTask2.Click += new System.Windows.RoutedEventHandler(this.btnTask2_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnTask3 = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\MainTasks.xaml"
            this.btnTask3.Click += new System.Windows.RoutedEventHandler(this.btnTask3_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnWorker = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainTasks.xaml"
            this.BtnWorker.Click += new System.Windows.RoutedEventHandler(this.BtnWorker_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DTGridClient = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.BtnRemove = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\MainTasks.xaml"
            this.BtnRemove.Click += new System.Windows.RoutedEventHandler(this.BtnRemove_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\MainTasks.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cmbPriority = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\MainTasks.xaml"
            this.cmbPriority.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbPriority_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtWorker = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\MainTasks.xaml"
            this.txtWorker.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtWorker_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\MainTasks.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
