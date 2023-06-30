using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

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
        /// RA stored in stored in decimal degrees
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
            int currentYear = DateTime.Now.Year;
            DateTime vernalEquinoxDate = new DateTime(currentYear, 03, 20, 23, 24, 00);

            double rightAscensionInHours = RightAscension / 3600d;
            double localTimeInHours = dateTime.Hour + dateTime.Minute / 60d + dateTime.Second / 3600d;

            // days since vernal equinox
            int daysAfterVernalEquinox = (dateTime - vernalEquinoxDate).Days;

            // local clock time, measured by 24 hour scale (0=midnight, 12=noon)
            // lst = 12 + (366.25CT+ 24DV)/365.25
            // CT = local clock time, measured by 24 hour scale (0=midnight, 12=noon)
            // DV = days since vernal equinox
            var lst = 12 + (366.25 * localTimeInHours + 24 * daysAfterVernalEquinox) / 365.25;

            /*
                Hour Angle = hour angle of star = (lst - RA)(360/24)
                RA = right ascension of star
                lst = local sidereal time                
             */
            double hourAngle = (lst - rightAscensionInHours)*(360/24d);

            // sin(Altitude) = sin(Latitude) * sin(Declination) + cos(Latitude) * cos(Declination) * cos(Hour Angle)
            double altitude = Math.Asin(
                Math.Sin(latitude * degreeToRad) * Math.Sin(Declination * degreeToRad) 
                    + Math.Cos(latitude * degreeToRad) * Math.Cos(Declination * degreeToRad) * Math.Cos(hourAngle * degreeToRad)
                * degreeToRad);

            return altitude >= 0;
        }

        /// <summary>
        /// Calculates star observation hours for today
        /// </summary>
        /// <param name="longtitude"></param>
        /// <param name="latitude"></param>
        /// <returns></returns>
        public (TimeSpan? riseTime, TimeSpan? setTime) GetObservationHours(double longtitude, double latitude)
        {
            if (Declination * latitude < 0)
            {
                return (null, null);
            }
            const double degreeToRad = Math.PI / 180;

            int currentYear = DateTime.Now.Year;
            DateTime vernalEquinoxDate = new DateTime(currentYear, 03, 20, 23, 24, 00);
            int daysAfterVernalEquinox = (DateTime.Now - vernalEquinoxDate).Days;

            // cos(hourAngle) = -tg(RA) * tg(declination)
            double hourAngleCos = -Math.Tan(RightAscension * degreeToRad) * Math.Tan(Declination * degreeToRad) - Math.Floor(-Math.Tan(RightAscension * degreeToRad) * Math.Tan(Declination * degreeToRad));
            double riseHourAngle = Math.Acos(hourAngleCos) + Math.PI;

            double setHourAngle = Math.Acos(hourAngleCos);

            double riseLst = (RightAscension + riseHourAngle / degreeToRad) * (24d / 360d);
            double setLst = (RightAscension + setHourAngle / degreeToRad) * (24d / 360d);

            // localRiseTimeInHours = (366.25 * (riseLst - 12) - 24 * DV) / 366.25
            //DV = days since vernal equinox

            double localRiseTimeInHours = Math.Abs((366.25 * (riseLst - 12) - 24 * daysAfterVernalEquinox) / 366.25);
            double localSetTimeInHours = Math.Abs((366.25 * (setLst - 12) - 24 * daysAfterVernalEquinox) / 366.25);

            TimeSpan riseTime = TimeSpan.FromHours(localRiseTimeInHours);
            TimeSpan setTime = TimeSpan.FromHours(localSetTimeInHours);

            return (riseTime, setTime);
        }
    }
}
