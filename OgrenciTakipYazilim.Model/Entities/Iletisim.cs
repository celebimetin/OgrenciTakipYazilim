﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Attributes;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class Iletisim : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [StringLength(14)]
        public string TcKimlikNo { get; set; }
        [Required, StringLength(20), ZorunluAlan("Adı", "txtAdi")]
        public string Adi { get; set; }
        [Required, StringLength(20), ZorunluAlan("Soyadı", "txtSoyadi")]
        public string Soyadi { get; set; }
        [StringLength(20)]
        public string BabaAdi { get; set; }
        [StringLength(20)]
        public string AnneAdi { get; set; }
        [StringLength(20)]
        public string DogumYeri { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

        public KanGrubu KanGrubu { get; set; } = KanGrubu.Bos;
        [StringLength(10)]
        public string KimlikSeri { get; set; }
        [StringLength(20)]
        public string KimlikSeriNo { get; set; }
        public long? KimlikIlId { get; set; }
        public long? KimlikIlceId { get; set; }
        [StringLength(20)]
        public string KimlikMahalleKoy { get; set; }
        [StringLength(20)]
        public string KimlikCiltNo { get; set; }
        [StringLength(20)]
        public string KimlikAileSiraNo { get; set; }
        [StringLength(20)]
        public string KimlikBireySiraNo { get; set; }
        [StringLength(20)]
        public string KimlikVerildigiYer { get; set; }
        [StringLength(20)]
        public string KimlikVerilisNedeni { get; set; }
        [StringLength(20)]
        public string KimlikKayitNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? KimlikVerilisTarihi { get; set; }
        [StringLength(17)]
        public string EvTelefon { get; set; }
        [StringLength(17)]
        public string IsTelefon1 { get; set; }
        [StringLength(17)]
        public string IsTelefon2 { get; set; }
        [StringLength(6)]
        public string Dahili1 { get; set; }
        [StringLength(6)]
        public string Dahili2 { get; set; }
        [StringLength(17)]
        public string CepTelefon1 { get; set; }
        [StringLength(17)]
        public string CepTelefon2 { get; set; }
        [StringLength(20)]
        public string Web { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(250)]
        public string EvAdres { get; set; }
        public long? EvAdresIlId { get; set; }
        public long? EvAdresIlceId { get; set; }
        [StringLength(250)]
        public string IsAdres { get; set; }
        public long? IsAdresIlId { get; set; }
        public long? IsAdresIlceId { get; set; }
        public long? MeslekId { get; set; }
        public long? IsyeriId { get; set; }
        public long? GorevId { get; set; }
        [StringLength(32)]
        public string IbanNo { get; set; }
        [StringLength(19)]
        public string KartNo { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        public Il KimlikIl { get; set; }
        public Il EvAdresIl { get; set; }
        public Il IsAdresIl { get; set; }
        public Ilce KimlikIlce { get; set; }
        public Ilce EvAdresIlce { get; set; }
        public Ilce IsAdresIlce { get; set; }
        public Meslek Meslek { get; set; }
        public Isyeri Isyeri { get; set; }
        public Gorev Gorev { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
    }
}