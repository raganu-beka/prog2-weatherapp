using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace weatherapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            var cityName = city.Text;
            var requestUrl = $"http://api.weatherapi.com/v1/forecast.xml?key=ecdaff50705e449ab6311843250302&q={cityName}&days=1";
        
            XDocument doc = XDocument.Load(requestUrl);

            string moonPhs = (string)doc.Descendants("moon_phase").FirstOrDefault();

            moonPhase.Text = moonPhs;
        }
    }
}
