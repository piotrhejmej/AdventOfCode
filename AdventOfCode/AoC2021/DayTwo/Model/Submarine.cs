using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.AoC2021.DayTwo.Model
{

    internal class Submarine
    {
        public long Horizontal { get; set; }
        public long Depth { get; set; }
        public long Aim { get; set; }

        public Submarine()
        {
            Horizontal = 0;
            Depth = 0;
            Aim = 0;
        }

        public void Move(CommandModel command, Task task = Task.One)
        {
            switch(task)
            {
                case Task.One:
                    LoadA(command);
                    break;
                case Task.Two:
                    LoadB(command);
                    break;
            }
        }

        private void LoadA(CommandModel command)
        {
            switch (command.Direction)
            {
                case Direction.Up: Depth -= command.Lenght; break;
                case Direction.Down: Depth += command.Lenght; break;
                case Direction.Forward: Horizontal += command.Lenght; break;
                default: break;
            }
        }

        private void LoadB(CommandModel command)
        {
            switch (command.Direction)
            {
                case Direction.Up: Aim -= command.Lenght; break;
                case Direction.Down: Aim += command.Lenght; break;
                case Direction.Forward: Depth += command.Lenght * Aim; Horizontal += command.Lenght; break;
                default: break;
            }
        }
    }
}
