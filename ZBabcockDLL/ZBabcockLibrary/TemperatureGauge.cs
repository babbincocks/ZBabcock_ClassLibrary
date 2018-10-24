using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBabcockLibrary
{
    public partial class TemperatureGauge : UserControl
    {
        public TemperatureGauge()
        {
            InitializeComponent();
        }

        private void tbTemp_Scroll(object sender, EventArgs e)
        {
            if(rbCelsius.Checked)
            {
                txtCelsius.Text = tbTemp.Value.ToString();
                double fahr = Math.Round((tbTemp.Value * 1.8) + 32, 2);
                txtFahr.Text = fahr.ToString();
            }
            else if(rbFahr.Checked)
            {
                txtFahr.Text = tbTemp.Value.ToString();
                double celsius = Math.Round((tbTemp.Value - 32) / 1.8, 2);
                txtCelsius.Text = celsius.ToString();
            }
        }
    }
}
