using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.FiltreForms
{
    public partial class FiltreEditForm : BaseEditForm
    {
        private readonly GridControl _filtreGrid;
        private readonly KartTuru _filtreKartTuru;

        public FiltreEditForm(params object[] prm)
        {
            InitializeComponent();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new FiltreBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.Filtre;
            EventsLoad();

            HideItems = new BarItem[]
            {
                btnYeni,
                btnGeriAl
            };
            ShowItems = new BarItem[]
            {
                btnFarkliKaydet,
                btnUygula
            }; 
        }

        protected internal override void Yukle()
        {
            txtFiltreMetni.SourceControl = _filtreGrid;

            while (true)
            {
                if (BaseEditIslemTuru == IslemTuru.EntityInsert)
                {
                    OldEntity = new Filtre();
                    Id = BaseEditIslemTuru.IdOlustur(OldEntity);
                    txtKod.Text = ((FiltreBll)BllEdit).YeniKodVer(x => x.KartTuru == _filtreKartTuru);
                }
                else
                {
                    OldEntity = ((FiltreBll)BllEdit).Single(FilterFunctions.Filter<Filtre>(Id));
                    if (OldEntity == null)
                    {
                        BaseEditIslemTuru = IslemTuru.EntityInsert;
                        continue;
                    }
                    NesneKontrollereBagla();
                }
                break;
            }
        }

        protected override void NesneKontrollereBagla()
        {
            Filtre entity = (Filtre)OldEntity;
            txtKod.Text = entity.Kod;
            txtFiltreAdi.Text = entity.FiltreAdi;
            txtFiltreMetni.FilterString = entity.FiltreMetni;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Filtre
            {
                Id = Id,
                Kod = txtKod.Text,
                FiltreAdi = txtFiltreAdi.Text,
                FiltreMetni = txtFiltreMetni.FilterString,
                KartTuru = _filtreKartTuru
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((FiltreBll)BllEdit).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
        }

        protected override bool EntityUpdate()
        {
            return ((FiltreBll)BllEdit).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
        }

        protected override void FiltreUygula()
        {
            txtFiltreMetni.Select();
            txtFiltreMetni.ApplyFilter();

        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!Isloaded)
            {
                return;
            }
            GeneralFunctionsWin.ButtonEnabledDurumu(btnKaydet, btnFarkliKaydet, btnSil, BaseEditIslemTuru, OldEntity, CurrentEntity);
        }
    }
}