using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class IndirimBll: BaseGenelBll<Indirim>, IBaseCommonBll
    {
        public IndirimBll() : base(KartTuru.Indirim) { }
        public IndirimBll(Control control) : base(control, KartTuru.Indirim) { }

        public override BaseEntity Single(Expression<Func<Indirim, bool>> filter)
        {
            return BaseSingle(filter, x => new IndirimS()
            {
                Id = x.Id,
                Kod = x.Kod,
                IndirimAdi = x.IndirimAdi,
                IndirimTuruId = x.IndirimTuruId,
                IndirimTuruAdi = x.IndirimTuru.IndirimTuruAdi,
                SubeId = x.SubeId,
                DonemId = x.DonemId,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Indirim, bool>> filter)
        {
            return BaseList(filter, x => new IndirimL()
            {
                Id = x.Id,
                Kod = x.Kod,
                IndirimAdi = x.IndirimAdi,
                IndirimTuruAdi = x.IndirimTuru.IndirimTuruAdi,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}