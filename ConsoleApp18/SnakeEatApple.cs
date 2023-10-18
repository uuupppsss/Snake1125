using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static bool SnakeEatApple()
        {
            return apple[0] == snake[0][0] && apple[1] == snake[0][1];
            
        }
        private static bool SnakeEatKringeApple() 
        {
            return kringe_apple[0] == snake[0][0] && kringe_apple[1] == snake[0][1];
        }
    }
}
