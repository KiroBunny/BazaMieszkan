//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mieszkania
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pracownicy
    {
        public int IdPracownika { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string NrTel { get; set; }
        public string Pesel { get; set; }
        public string Miasto_Zamieszkania { get; set; }
        public string Adres_Zamieszkania { get; set; }
        public int IdStanowisko { get; set; }
        public bool Zatrudniony { get; set; }
    
        public virtual Stanowiska Stanowiska { get; set; }
    }
}