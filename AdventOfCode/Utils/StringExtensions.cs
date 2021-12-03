using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Utils
{
    internal static class StringExtensions
    {
        public static int ToInt(this string value, int nBase) => Convert.ToInt32(value, nBase);
    }
}
