using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimesterReport
{
    static class Converter
    {
        static public string GroupByTrimester(DateTime date)
        {
            if (date.Month > 0 && date.Month <= 4)
            {
                return "I";
            }
            else if (date.Month > 4 && date.Month <= 8)
            {
                return "II";
            }
            else if (date.Month > 8 && date.Month <= 12)
            {
                return "III";
            }
            else
            {
                throw new Exception("this month is not valid: {0}");
            }
        }

        
    }
}
