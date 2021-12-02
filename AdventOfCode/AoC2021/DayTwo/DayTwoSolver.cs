using AdventOfCode.AoC2021.DayTwo.Model;
using AdventOfCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.AoC2021.DayTwo
{

    internal class DayTwoSolver
    {
        private readonly InputLoader InputLoader;
        public DayTwoSolver()
        {
            InputLoader = new InputLoader();
        }

        public void TaskOne()
        {
            var sub = new Submarine();
            var inputs = InputLoader
                .Load("DayTwo");

            inputs
                .Select(r => new CommandModel(r))
                .ToList()
                .ForEach(r => sub.Move(r));

            var resultA = sub.Horizontal * sub.Depth;
            
            sub = new Submarine();

            inputs
                .Select(r => new CommandModel(r))
                .ToList()
                .ForEach(r => sub.Move(r, Model.Task.Two));
            var resultB = sub.Horizontal * sub.Depth;
        }
    }
}
