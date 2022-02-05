using System.Collections.Generic;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Bll.Base.Interfaces
{
    public interface IBaseHareketGenelBll
    {
        bool Insert(IList<BaseHaraketEntity> entities);
        bool Update(IList<BaseHaraketEntity> entities);
        bool Delete(IList<BaseHaraketEntity> entities);
    }
}