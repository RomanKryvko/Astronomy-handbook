using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Довідник_астронома
{
    internal class Star
    {
        public string name;
        string constellation;
        double apparentMagnitude;
        double distance;
        //RA stored in seconds.
        double rightAscension;
        //Dec stred in seconds.
        double declination;
    }
}
