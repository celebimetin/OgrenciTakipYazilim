using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.Model.Entities.Base.Interfaces;

namespace OgrenciTakipYazilim.Model.Dto
{
    [NotMapped]
    public class BilgiNotlariL : BilgiNotlari, IBaseHareketEntity
    {
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}