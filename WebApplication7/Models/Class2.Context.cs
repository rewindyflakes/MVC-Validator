﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace emreekiz.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ASTOR2Entities1 : DbContext
    {
        public ASTOR2Entities1()
            : base("name=ASTOR2Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kullanici_Bilgi> Kullanici_Bilgi { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TB_Araclar> TB_Araclar { get; set; }
        public virtual DbSet<TB_Müsteriler> TB_Müsteriler { get; set; }
        public virtual DbSet<TB_Personel> TB_Personel { get; set; }
        public virtual DbSet<TB_Seferler> TB_Seferler { get; set; }
        public virtual DbSet<TB_şoförler> TB_şoförler { get; set; }
        public virtual DbSet<TB_Admin> TB_Admin { get; set; }
        public virtual DbSet<TB_Kullanıcı> TB_Kullanıcı { get; set; }
    
        public virtual int araçgetir(Nullable<int> vPlakaID)
        {
            var vPlakaIDParameter = vPlakaID.HasValue ?
                new ObjectParameter("vPlakaID", vPlakaID) :
                new ObjectParameter("vPlakaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("araçgetir", vPlakaIDParameter);
        }
    
        public virtual ObjectResult<MüsteriDurumu_Result> MüsteriDurumu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MüsteriDurumu_Result>("MüsteriDurumu");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_aracekle(string vAraçID, Nullable<int> vPlakaID, string vMarka, Nullable<int> vKoltukID)
        {
            var vAraçIDParameter = vAraçID != null ?
                new ObjectParameter("vAraçID", vAraçID) :
                new ObjectParameter("vAraçID", typeof(string));
    
            var vPlakaIDParameter = vPlakaID.HasValue ?
                new ObjectParameter("vPlakaID", vPlakaID) :
                new ObjectParameter("vPlakaID", typeof(int));
    
            var vMarkaParameter = vMarka != null ?
                new ObjectParameter("vMarka", vMarka) :
                new ObjectParameter("vMarka", typeof(string));
    
            var vKoltukIDParameter = vKoltukID.HasValue ?
                new ObjectParameter("vKoltukID", vKoltukID) :
                new ObjectParameter("vKoltukID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_aracekle", vAraçIDParameter, vPlakaIDParameter, vMarkaParameter, vKoltukIDParameter);
        }
    
        public virtual int sp_AraçGüncelle(string vMarka)
        {
            var vMarkaParameter = vMarka != null ?
                new ObjectParameter("vMarka", vMarka) :
                new ObjectParameter("vMarka", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AraçGüncelle", vMarkaParameter);
        }
    
        public virtual int sp_araçsil(Nullable<int> vAraçID)
        {
            var vAraçIDParameter = vAraçID.HasValue ?
                new ObjectParameter("vAraçID", vAraçID) :
                new ObjectParameter("vAraçID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_araçsil", vAraçIDParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_cursorAraçkayıt11()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_cursorAraçkayıt11");
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_müsteriekle(Nullable<int> vMüsteriID, string vMüsteriAd, string vMüsteriSoyad, string vTel, string vTCNO, string vHesKodu, Nullable<int> vAraçID)
        {
            var vMüsteriIDParameter = vMüsteriID.HasValue ?
                new ObjectParameter("vMüsteriID", vMüsteriID) :
                new ObjectParameter("vMüsteriID", typeof(int));
    
            var vMüsteriAdParameter = vMüsteriAd != null ?
                new ObjectParameter("vMüsteriAd", vMüsteriAd) :
                new ObjectParameter("vMüsteriAd", typeof(string));
    
            var vMüsteriSoyadParameter = vMüsteriSoyad != null ?
                new ObjectParameter("vMüsteriSoyad", vMüsteriSoyad) :
                new ObjectParameter("vMüsteriSoyad", typeof(string));
    
            var vTelParameter = vTel != null ?
                new ObjectParameter("vTel", vTel) :
                new ObjectParameter("vTel", typeof(string));
    
            var vTCNOParameter = vTCNO != null ?
                new ObjectParameter("vTCNO", vTCNO) :
                new ObjectParameter("vTCNO", typeof(string));
    
            var vHesKoduParameter = vHesKodu != null ?
                new ObjectParameter("vHesKodu", vHesKodu) :
                new ObjectParameter("vHesKodu", typeof(string));
    
            var vAraçIDParameter = vAraçID.HasValue ?
                new ObjectParameter("vAraçID", vAraçID) :
                new ObjectParameter("vAraçID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_müsteriekle", vMüsteriIDParameter, vMüsteriAdParameter, vMüsteriSoyadParameter, vTelParameter, vTCNOParameter, vHesKoduParameter, vAraçIDParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_SeferEkle(Nullable<int> vSeferID, string vKalkışŞehirAd, string vVarışŞehirAd, Nullable<int> vSöförID, Nullable<System.DateTime> vKalkışZamanı, Nullable<int> vTahminiSüre, Nullable<int> vBiletTutar)
        {
            var vSeferIDParameter = vSeferID.HasValue ?
                new ObjectParameter("vSeferID", vSeferID) :
                new ObjectParameter("vSeferID", typeof(int));
    
            var vKalkışŞehirAdParameter = vKalkışŞehirAd != null ?
                new ObjectParameter("vKalkışŞehirAd", vKalkışŞehirAd) :
                new ObjectParameter("vKalkışŞehirAd", typeof(string));
    
            var vVarışŞehirAdParameter = vVarışŞehirAd != null ?
                new ObjectParameter("vVarışŞehirAd", vVarışŞehirAd) :
                new ObjectParameter("vVarışŞehirAd", typeof(string));
    
            var vSöförIDParameter = vSöförID.HasValue ?
                new ObjectParameter("vSöförID", vSöförID) :
                new ObjectParameter("vSöförID", typeof(int));
    
            var vKalkışZamanıParameter = vKalkışZamanı.HasValue ?
                new ObjectParameter("vKalkışZamanı", vKalkışZamanı) :
                new ObjectParameter("vKalkışZamanı", typeof(System.DateTime));
    
            var vTahminiSüreParameter = vTahminiSüre.HasValue ?
                new ObjectParameter("vTahminiSüre", vTahminiSüre) :
                new ObjectParameter("vTahminiSüre", typeof(int));
    
            var vBiletTutarParameter = vBiletTutar.HasValue ?
                new ObjectParameter("vBiletTutar", vBiletTutar) :
                new ObjectParameter("vBiletTutar", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SeferEkle", vSeferIDParameter, vKalkışŞehirAdParameter, vVarışŞehirAdParameter, vSöförIDParameter, vKalkışZamanıParameter, vTahminiSüreParameter, vBiletTutarParameter);
        }
    
        public virtual int sp_Seferİptal(Nullable<int> vSeferID)
        {
            var vSeferIDParameter = vSeferID.HasValue ?
                new ObjectParameter("vSeferID", vSeferID) :
                new ObjectParameter("vSeferID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Seferİptal", vSeferIDParameter);
        }
    
        public virtual int sp_Söförekle(Nullable<int> vSöförID, string vSöförSoyad, string vSöförad, Nullable<int> vAraçID)
        {
            var vSöförIDParameter = vSöförID.HasValue ?
                new ObjectParameter("vSöförID", vSöförID) :
                new ObjectParameter("vSöförID", typeof(int));
    
            var vSöförSoyadParameter = vSöförSoyad != null ?
                new ObjectParameter("vSöförSoyad", vSöförSoyad) :
                new ObjectParameter("vSöförSoyad", typeof(string));
    
            var vSöföradParameter = vSöförad != null ?
                new ObjectParameter("vSöförad", vSöförad) :
                new ObjectParameter("vSöförad", typeof(string));
    
            var vAraçIDParameter = vAraçID.HasValue ?
                new ObjectParameter("vAraçID", vAraçID) :
                new ObjectParameter("vAraçID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Söförekle", vSöförIDParameter, vSöförSoyadParameter, vSöföradParameter, vAraçIDParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
