using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void Move(IMovement movement, int distance)
        {
            Console.WriteLine($" {this.name} iniciou o movimento.");
            movement.Move(distance);
            Console.WriteLine($" {this.name} terminou o trajeto.");
        }
    }
}
