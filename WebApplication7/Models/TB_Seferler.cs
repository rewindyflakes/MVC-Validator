//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Seferler
    {
        public int SeferID { get; set; }
        public string KalkışŞehirAd { get; set; }
        public string VarışŞehirAd { get; set; }
        public int SöförID { get; set; }
        public System.DateTime KalkışZamanı { get; set; }
        public int TahminiSüre { get; set; }
        public Nullable<int> BiletTutar { get; set; }
        public Nullable<int> AraçID { get; set; }
    }
}
