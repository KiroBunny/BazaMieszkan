﻿#pragma checksum "..\..\..\Dodawanie\DodajRemont.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "38464B9F720E50FCF03440D9EE14BB09247B8B7B30706C0EE6DC45CD0C213810"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Mieszkania;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Mieszkania {
    
    
    /// <summary>
    /// DodajRemont
    /// </summary>
    public partial class DodajRemont : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Dodawanie\DodajRemont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_stan;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Dodawanie\DodajRemont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Koszt;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Dodawanie\DodajRemont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txt_data_p;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Dodawanie\DodajRemont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txt_data_k;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Dodawanie\DodajRemont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_id_m;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Dodawanie\DodajRemont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_dodaj_r;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Dodawanie\DodajRemont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_wybierz_mieszkanie;
        
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
            System.Uri resourceLocater = new System.Uri("/Mieszkania;component/dodawanie/dodajremont.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dodawanie\DodajRemont.xaml"
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
            this.txt_stan = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\Dodawanie\DodajRemont.xaml"
            this.txt_stan.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_stan_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_Koszt = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\Dodawanie\DodajRemont.xaml"
            this.txt_Koszt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_Koszt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_data_p = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.txt_data_k = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.txt_id_m = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_dodaj_r = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Dodawanie\DodajRemont.xaml"
            this.btn_dodaj_r.Click += new System.Windows.RoutedEventHandler(this.btn_dodaj_r_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_wybierz_mieszkanie = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Dodawanie\DodajRemont.xaml"
            this.btn_wybierz_mieszkanie.Click += new System.Windows.RoutedEventHandler(this.btn_wybierz_mieszkanie_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

