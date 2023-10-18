using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void DrawHead()
        {
            graphics.FillEllipse(System.Drawing.Brushes.Pink, snake[0][0], snake[0][1], 10, 10);
            if (snake.Count > 1)
            {
                for(int i = 1;i<snake.Count-1;i++) 
                    graphics.FillEllipse(new SolidBrush(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255))), snake[i][0], snake[i][1], 10, 10);
            }
            // нарисовать красный круг размером 10 на 10 по координатам нулевой ячейки змейки
        }
    }
}
