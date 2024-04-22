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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.city;
            dateOutput.Text = DateTime.Now.ToString("dddd");         
            currentOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp)).ToString("0") + "°";
            minOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow)).ToString("0") + "°";
            maxOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh)).ToString("0") + "°";
            humidityOutput.Text = Form1.days[0].humid + "%";
            conditionOutput.Text = Form1.days[0].condition;

            if (Convert.ToInt32(Form1.days[0].icon) < 300)
            {
                //thunderstorm
                BackgroundImage = Properties.Resources.rainImg;
                colourLabel.BackColor = Color.SlateGray;
                currentImg.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[0].icon) < 400 && Convert.ToInt32(Form1.days[0].icon) >= 300)
            {
                //drizzle
                BackgroundImage = Properties.Resources.drizzleImg;
                colourLabel.BackColor = Color.Lavender;
                currentImg.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[0].icon) < 600 && Convert.ToInt32(Form1.days[0].icon) >= 500)
            {
                //rain
                BackgroundImage = Properties.Resources.rainImg;
                colourLabel.BackColor = Color.MidnightBlue;
                currentImg.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[0].icon) < 700 && Convert.ToInt32(Form1.days[0].icon) >= 600)
            {
                //snow
                BackColor = Color.White;
                colourLabel.BackColor = Color.White;
                currentImg.Image = Properties.Resources.cloudImg;
            }
            if (Convert.ToInt32(Form1.days[0].icon) == 800)
            {
                //sunny
                BackColor = Color.SkyBlue;
                colourLabel.BackColor = Color.Gold;
                currentImg.Image = Properties.Resources.sunImg;
            }
            if (Convert.ToInt32(Form1.days[0].icon) > 800)
            {
                //clouds
                colourLabel.BackColor = Color.Lavender;
                currentImg.Image = Properties.Resources.cloudImg;
            }
        }
        //date format

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form1.city = searchInput.Text;
            Form1.days.Clear();
            Form1.ExtractForecast();
            Form1.ExtractCurrent();
            DisplayCurrent();
        }
    }
}
