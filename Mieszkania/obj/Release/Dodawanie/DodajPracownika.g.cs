﻿#pragma checksum "..\..\..\Dodawanie\DodajPracownika.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D45FAA28A65597BFBAB35D0E2C1FC73A67F17F2AFE97857BFAE1B8D506890B2F"
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
    /// DodajPracownika
    /// </summary>
    public partial class DodajPracownika : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Pesel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_miasto;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_adres;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataG;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbox_stanowisko;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbox_zatrudniony;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_imiePrac;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_nazPrac;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_telPrac;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Dodawanie\DodajPracownika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_dodaj;
        
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
            System.Uri resourceLocater = new System.Uri("/Mieszkania;component/dodawanie/dodajpracownika.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dodawanie\DodajPracownika.xaml"
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
            
            #line 9 "..\..\..\Dodawanie\DodajPracownika.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_Pesel = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\Dodawanie\DodajPracownika.xaml"
            this.txt_Pesel.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_Pesel_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_miasto = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\Dodawanie\DodajPracownika.xaml"
            this.txt_miasto.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_miasto_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_adres = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\Dodawanie\DodajPracownika.xaml"
            this.txt_adres.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_adres_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.cbox_stanowisko = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.cbox_zatrudniony = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.txt_imiePrac = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\Dodawanie\DodajPracownika.xaml"
            this.txt_imiePrac.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_imiePrac_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txt_nazPrac = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\Dodawanie\DodajPracownika.xaml"
            this.txt_nazPrac.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_nazPrac_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txt_telPrac = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Dodawanie\DodajPracownika.xaml"
            this.txt_telPrac.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_telPrac_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_dodaj = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Dodawanie\DodajPracownika.xaml"
            this.btn_dodaj.Click += new System.Windows.RoutedEventHandler(this.btn_dodaj_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

