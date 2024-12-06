using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text=db.Location.Average(x=>x.Capacity)?.ToString("0.00");
            lblAvgLocationPrice.Text=db.Location.Average(x=>x.Price)?.ToString("0.00"); //virgülden sonra sadece 2 basamak gelecek şekilde düzenlenmesi isteniyor
            int LastCountryId=db.Location.Max(x=>x.LocationId);
            lblLastCountry.Text = db.Location.Where(x => x.LocationId == LastCountryId).Select(y => y.Country).FirstOrDefault();
            lblCappadociaLocationCapacity.Text=db.Location.Where(x=>x.City=="Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();

            var romeGuideID= db.Location.Where(x=>x.City=="Roma Turistik").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuidName.Text=db.Guide.Where(x=>x.GuideId==romeGuideID).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x=>x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

            //lblOrtTurFiyatiDeger.Text = db.TblLocation.Average(x => x.LocationPrice)?.ToString("0.00");

            var guideByNameAysegulCınar=db.Guide.Where(x=>x.GuideName=="Ayşegül" && x.GuideSurname=="Çınar").Select(y=>y.GuideId).FirstOrDefault();
            lblAysegulCınarınLocationCount.Text=db.Location.Where(x=>x.GuideId == guideByNameAysegulCınar).Count().ToString();

        }
    }
}
