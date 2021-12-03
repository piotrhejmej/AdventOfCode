using AdventOfCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.AoC2021.DayThree
{
    internal class DayThreeSolver
    {
        private readonly InputLoader InputLoader;
        public DayThreeSolver()
        {
            InputLoader = new InputLoader();
        }

        public int Solve()
        {
            var inputs = InputLoader
                .Load("DayThree");
            
            var firstOne = SolveSecond(inputs);


            return 1;
        }

        public int SolveFirst(string[] inputs)
        {
            var halfInputCount = inputs.Length / 2;

            var gammaCol = inputs
                .SelectMany(r => r.Select((c, index) => (value: int.Parse(c.ToString()), index)))
                .GroupBy(r => r.index)
                .Select(r => (index: r.Key, sum: r.Sum(r => r.value)))
                .Select(r => r.sum > halfInputCount ? '1' : '0');
            var epsilonCol = gammaCol.Select(r => r == '1' ? '0' : '1');

            var gamma = String.Join("", gammaCol).ToInt(2);
            var epsilon = String.Join("", epsilonCol).ToInt(2);

            return gamma * epsilon;
        }

        public int SolveSecond(string[] inputs)
        {

            var oxygen = AirStatFinder(inputs.ToList(), '1', '0').ToInt(2);
            var co2 = AirStatFinder(inputs.ToList(), '0', '1').ToInt(2);

            return oxygen * co2;
        }

        private string AirStatFinder(List<string> inputs, char successChar, char failureChar)
        {
            var two = (decimal)2;
            var inputLength = inputs.First().Length;
            for (int i = 0; i < inputLength; i++)
            {
                inputs = inputs.Where(o => o[i] ==
                    (inputs
                    .Where(r => r[i] == '1')
                    .Count() >= Math.Ceiling(inputs.Count() / two) ? successChar : failureChar))
                    .ToList();

                if (inputs.Count == 1) return inputs.First();
            }

            return String.Empty;
        }
    }
}
