﻿#pragma checksum "..\..\..\..\UI\UC\UCAddItemSearch.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37C8F8560E83B0DD7F25C63AE61ABCBC7716345A51BD1805299CAE4B87885661"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DriveParts.UI.UC;
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


namespace DriveParts.UI.UC {
    
    
    /// <summary>
    /// UCAddItemSearch
    /// </summary>
    public partial class UCAddItemSearch : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\UI\UC\UCAddItemSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup Popup;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\UI\UC\UCAddItemSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListFindedItems;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\UI\UC\UCAddItemSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextNothingFound;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\UI\UC\UCAddItemSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSearch;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\UI\UC\UCAddItemSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextPlaceholder;
        
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
            System.Uri resourceLocater = new System.Uri("/DriveParts;component/ui/uc/ucadditemsearch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\UC\UCAddItemSearch.xaml"
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
            this.Popup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 2:
            this.ListFindedItems = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.TextNothingFound = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\..\UI\UC\UCAddItemSearch.xaml"
            this.TbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbSearch_TextChanged);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\UI\UC\UCAddItemSearch.xaml"
            this.TbSearch.LostFocus += new System.Windows.RoutedEventHandler(this.TbSearch_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextPlaceholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

