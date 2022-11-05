using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class WalkMovement : IMovement
    {
        public void Move(int distance)
        {
            int currentDistance = 0;
            while (currentDistance <distance)
            {
                currentDistance++;
                Thread.Sleep(300);
                if (currentDistance % 20 == 0)
                {
                    Thread.Sleep(300);
                    Console.WriteLine("Parada para descanço!");
                }
            }
                     

            Console.WriteLine($"Distância percorrida {currentDistance} m");
        }
    }
}
