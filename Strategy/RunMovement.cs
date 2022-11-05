using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RunMovement : IMovement
    {
        public void Move(int distance)
        {
            int currentDistance = 0;
            while (currentDistance < distance)
            {
                currentDistance++;
                Thread.Sleep(150);
            }
                  

            Console.WriteLine($"Distância percorrida {currentDistance} m");
        }
    }
}
