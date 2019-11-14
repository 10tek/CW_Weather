using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public partial class WeatherInfo
    {
        public long Cod { get; set; }
        public long Message { get; set; }
        public long Cnt { get; set; }
        public List<List> List { get; set; }
        public City City { get; set; }
    }

    public partial class City
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
        public long Population { get; set; }
        public long Timezone { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }

    public partial class Coord
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public partial class List
    {
        public long Dt { get; set; }
        public DateTime asd {get;set;}
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public Sys Sys { get; set; }
        public DateTimeOffset DtTxt { get; set; }
    }

    public partial class Clouds
    {
        public long All { get; set; }
    }

    public partial class Main
    {
        public double Temp { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public long Pressure { get; set; }
        public long SeaLevel { get; set; }
        public long GrndLevel { get; set; }
        public long Humidity { get; set; }
        public double TempKf { get; set; }
    }

    public partial class Sys
    {
        public string Pod { get; set; }
    }

    public partial class Weather
    {
        public long Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public partial class Wind
    {
        public double Speed { get; set; }
        public long Deg { get; set; }
    }

}
