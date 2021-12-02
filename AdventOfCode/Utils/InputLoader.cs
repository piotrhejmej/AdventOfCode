using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Utils
{
    internal class InputLoader
    {
        public string[] Load(string fileName) => System.IO.File.ReadAllLines($"Resources\\{fileName}.input");
    }
}
