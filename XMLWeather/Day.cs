using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, visibility, humid, icon;
        public Day()
        {
            currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = humid = icon = "";
        }
    }
}
