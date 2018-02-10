using System;

namespace DMBS.Data.Models
{
    public class OrganizationModel
    {
        public Datum[] Data { get; set; }
        public int Total { get; set; }
        public object AggregateResults { get; set; }
        public object Errors { get; set; }
    }

    public class Datum
    {
        public object Ad { get; set; }
        public int Sayi { get; set; }
        public int Oran { get; set; }
        public int Plaka { get; set; }
        public string AnaNevisi { get; set; }
        public string telNo { get; set; }
        public string Mail { get; set; }
        public string WebSitesi { get; set; }
        public int FkSisKodPkNevi { get; set; }
        public int FKSisTeskilatPk { get; set; }
        public object SisKod { get; set; }
        public string KurumAd { get; set; }
        public string KurumAdres { get; set; }
        public int Sira { get; set; }
        public string BaskanAdSoyad { get; set; }
        public int FkSisCityInfoPk { get; set; }
        public Altnevi[] AltNevis { get; set; }
        public string AltNevisString { get; set; }
        public object IsActive { get; set; }
        public DateTime DtOlusturma { get; set; }
        public object DtDegistirme { get; set; }
        public int Olusturan { get; set; }
        public object Degistiren { get; set; }
    }

    public class Altnevi
    {
        public int Pk { get; set; }
        public int FkEdrKurumPk { get; set; }
        public Siskod SisKod { get; set; }
        public int FkSisKodPkNevi { get; set; }
        public object IsActive { get; set; }
        public DateTime DtOlusturma { get; set; }
        public object DtDegistirme { get; set; }
        public int Olusturan { get; set; }
        public object Degistiren { get; set; }
    }

    public class Siskod
    {
        public int Pk { get; set; }
        public object Fk { get; set; }
        public object Enum { get; set; }
        public object Kod { get; set; }
        public object Aciklama { get; set; }
        public int Sira { get; set; }
        public string Text { get; set; }
        public bool IsReadOnly { get; set; }
        public object IsActive { get; set; }
        public DateTime DtOlusturma { get; set; }
        public object DtDegistirme { get; set; }
        public int Olusturan { get; set; }
        public object Degistiren { get; set; }
    }
}
