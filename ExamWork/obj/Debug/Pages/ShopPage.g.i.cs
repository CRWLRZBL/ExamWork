﻿#pragma checksum "..\..\..\Pages\ShopPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2CDA6CD0D2576512504A91228C7FFD7D063364D563446CA3C7FCD3916E55C5A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ExamWork.Pages;
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


namespace ExamWork.Pages {
    
    
    /// <summary>
    /// ShopPage
    /// </summary>
    public partial class ShopPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Pages\ShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userSearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\ShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\ShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filterComboBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\ShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView productListView;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\ShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PriceLabel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\ShopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider priceSlider;
        
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
            System.Uri resourceLocater = new System.Uri("/ExamWork;component/pages/shoppage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ShopPage.xaml"
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
            this.userSearchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.searchButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.filterComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\Pages\ShopPage.xaml"
            this.filterComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filterComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.productListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.PriceLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.priceSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 50 "..\..\..\Pages\ShopPage.xaml"
            this.priceSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.priceSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

