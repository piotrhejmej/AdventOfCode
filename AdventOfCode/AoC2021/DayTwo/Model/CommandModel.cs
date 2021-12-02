using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.AoC2021.DayTwo.Model
{

    internal class CommandModel
    {
        public Direction Direction { get; set; }
        public int Lenght { get; set; }

        public CommandModel(string input)
        {
            var splitted = input
                .Split(' ');

            if (!int.TryParse(splitted[1], out int lenght)) 
                throw new ArgumentException($"Value is not int: {splitted[1]}");

            Lenght = lenght;

            Direction = (Direction)Enum.Parse(
                typeof(Direction), 
                Enum
                    .GetNames(typeof(Direction))
                    .ToList()
                    .FirstOrDefault(n => n.ToUpper() == splitted[0].ToUpper()), 
                true);
        }
    }
}
