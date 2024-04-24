using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            cityOutput.Text = Form1.city;

            date1.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            min1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempLow)).ToString("0") + "°";
            max1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh)).ToString("0") + "°";

            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            min2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempLow)).ToString("0") + "°";
            max2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh)).ToString("0") + "°";

            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            min3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempLow)).ToString("0") + "°";
            max3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh)).ToString("0") + "°";

            date4.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();
            min4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempLow)).ToString("0") + "°";
            max4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh)).ToString("0") + "°";


            if (Convert.ToInt32(Form1.days[1].icon) < 300)
            {
                //thunderstorm
                BackgroundImage = Properties.Resources.rainImg;
                colourLabel.BackColor = Color.SlateGray;
                img1.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[1].icon) < 400 && Convert.ToInt32(Form1.days[1].icon) >= 300)
            {
                //drizzle
                BackgroundImage = Properties.Resources.drizzleImg;
                img1.Image = Properties.Resources.cloudImg;
                colourLabel.BackColor = Color.Lavender;
            }
            if (Convert.ToInt32(Form1.days[1].icon) < 600 && Convert.ToInt32(Form1.days[1].icon) >= 500)
            {
                //rain
                BackgroundImage = Properties.Resources.rainImg;
                colourLabel.BackColor = Color.MidnightBlue;
                img1.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[1].icon) < 700 && Convert.ToInt32(Form1.days[1].icon) >= 600)
            {
                //snow
                BackColor = Color.White;
                colourLabel.BackColor = Color.White;
                img1.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[1].icon) == 800)
            {
                //sunny
                BackColor = Color.SkyBlue;
                colourLabel.BackColor = Color.Gold;
                img1.Image = Properties.Resources.sunImg;
            }
            if (Convert.ToInt32(Form1.days[1].icon) > 800)
            {
                //clouds
                img1.Image = Properties.Resources.cloudImg;
                colourLabel.BackColor = Color.Lavender;
            }


            if (Convert.ToInt32(Form1.days[2].icon) < 300)
            {
                //thunderstorm
                img2.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[2].icon) < 400 && Convert.ToInt32(Form1.days[2].icon) >= 300)
            {
                //drizzle
                img2.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[2].icon) < 600 && Convert.ToInt32(Form1.days[2].icon) >= 500)
            {
                //rain
                img2.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[2].icon) < 700 && Convert.ToInt32(Form1.days[2].icon) >= 600)
            {
                //snow
                img2.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[2].icon) == 800)
            {
                //sunny
                img2.Image = Properties.Resources.sunImg;
            }
            if (Convert.ToInt32(Form1.days[2].icon) > 800)
            {
                //clouds
                img2.Image = Properties.Resources.cloudImg;
            }


            if (Convert.ToInt32(Form1.days[3].icon) < 300)
            {
                //thunderstorm
                img3.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[3].icon) < 400 && Convert.ToInt32(Form1.days[3].icon) >= 300)
            {
                //drizzle
                img3.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[3].icon) < 600 && Convert.ToInt32(Form1.days[3].icon) >= 500)
            {
                //rain
                img3.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[3].icon) < 700 && Convert.ToInt32(Form1.days[3].icon) >= 600)
            {
                //snow
                img3.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[3].icon) == 800)
            {
                //sunny
                img3.Image = Properties.Resources.sunImg;
            }
            if (Convert.ToInt32(Form1.days[3].icon) > 800)
            {
                //clouds
                img3.Image = Properties.Resources.cloudImg;
            }


            if (Convert.ToInt32(Form1.days[4].icon) < 300)
            {
                //thunderstorm
                img4.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[4].icon) < 400 && Convert.ToInt32(Form1.days[4].icon) >= 300)
            {
                //drizzle
                img4.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[4].icon) < 600 && Convert.ToInt32(Form1.days[4].icon) >= 500)
            {
                //rain
                img4.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[4].icon) < 700 && Convert.ToInt32(Form1.days[4].icon) >= 600)
            {
                //snow
                img4.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[4].icon) == 800)
            {
                //sunny
                img4.Image = Properties.Resources.sunImg;
            }
            if (Convert.ToInt32(Form1.days[4].icon) > 800)
            {
                //clouds
                img4.Image = Properties.Resources.cloudImg;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Visible = false;
                label3.Enabled = true;
                Form1.city = searchInput.Text;
                Form1.days.Clear();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();
                displayForecast();
            }
            catch
            {
                errorLabel.Visible = true;
                label3.Enabled = false;
            }
        }
    }
}
