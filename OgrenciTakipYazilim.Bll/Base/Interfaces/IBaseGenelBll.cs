using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Bll.Base.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity baseEntity);
        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
        string YeniKodVer();
    }
}