using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Car
    {
        private int speed;
        public string Name { get; set; }
        public string Maker { get; set; } = "";
        public string Model { get; set; } = "";

        public int Speed
        {
            get { return this.speed; }
        }

        public Car(string name)
        {
            this.Name = name;
        }

        public void Start()
        {
            this.speed = 1;
        }

        public void Accelerate(int increaseSpeed = 10)
        {
            this.speed += increaseSpeed;
        }

        public void Break(int decreaseSpeed = 10)
        {
            this.speed -= decreaseSpeed;
        }

        public void Stop()
        {
            this.speed = 0;
        }
    }
}
