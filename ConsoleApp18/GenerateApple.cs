using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void GenerateApple()
        {
            // с помощью рандомайзера сгенерировать 2 числа в промежутке от 0 до 40, полученные числа домножить на 10
            // назначить полученные числа в координаты apple
            // нарисовать зеленый круг размером 10 на 10 по новым координатам
            for (int i = 0; i < 2; i++)
                apple[i] = random.Next(0, 40);
            apple[0] = apple[0] * 10;
            apple[1] = apple[1] * 10;
            graphics.FillEllipse(System.Drawing.Brushes.Green, apple[0], apple[1], 10, 10);


        }
        private static void GenerateKringeApple() 
        {
            for (int j = 0; j < 2; j++)
                kringe_apple[j] = random.Next(0, 40);
            kringe_apple[0] = kringe_apple[0] * 10;
            kringe_apple[1] = kringe_apple[1] * 10;
            graphics.FillEllipse(System.Drawing.Brushes.Red, kringe_apple[0], kringe_apple[1], 10, 10);
        }

    }
}
