using System.ComponentModel.DataAnnotations;

namespace Довідник_астронома
{
    public class Star
    {
        [Key]
        public string Name { get; set; }

        public string Constellation { get; set; }

        public double ApparentMagnitude { get; set; }

        /// <summary>
        /// Distance stored in light years
        /// </summary>
        public double Distance { get; set; }

        /// <summary>
        /// RA stored in seconds
        /// </summary>
        public double RightAscension { get; set; }

        /// <summary>
        /// Declination stored in decimal degrees
        /// </summary>
        public double Declination { get; set; }

        /// <summary>
        /// Declanation shown in degrees / minutes / seconds
        /// </summary>
        public string DeclinationFormatted
        {
            get
            {
                double declination = Math.Abs(Declination);

                int d = (int)declination;
                int m = (int)((declination - d) * 60);
                double s = (declination - d - m / 60d) * 3600;

                string sign = Declination < 0 ? "-" : "+";

                return $"{sign}{d}° {m}' {s:0.##}''";
            }
        }

        /// <summary>
        /// Calculates if the star is visible
        /// </summary>
        /// <param name="longtitude"></param>
        /// <param name="latitude"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public bool IsVisible(
            double longtitude,
            double latitude,
            DateTime dateTime)
        {
            const double degreeToRad = Math.PI / 180;

            double GMST = 0;

            double LST = GMST + longtitude;

            double hourAngle = LST - RightAscension;

            // sin(Altitude) = sin(Latitude) * sin(Declination) + cos(Latitude) * cos(Declination) * cos(Hour Angle)

            double altitude = Math.Asin(
                Math.Sin(latitude * degreeToRad) * Math.Sin(Declination * degreeToRad) 
                    + Math.Cos(latitude * degreeToRad) * Math.Cos(Declination * degreeToRad) * Math.Cos(hourAngle * degreeToRad)
                * degreeToRad);

            //double azimuth = Math.Acos((Math.Sin(declination  Math.PI / 180) - Math.Sin(latitude  Math.PI / 180)  Math.Sin(altitude)) / (Math.Cos(latitude  Math.PI / 180)  Math.Cos(altitude))  Math.PI / 180);

            return altitude >= 0;
        }
    }
}
