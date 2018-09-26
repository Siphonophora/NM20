using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallParser
{
    public interface ICountryZone
    {
        string Country { get; }
        int ITUZone { get; }
        int CQZone { get; }
    }
}
