using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class Airplane : Vehicle
    {
        private string _airplane;
        private int _altitude;

        public Airplane (int capacity, int speed, string name ): base(capacity,speed)
        {
            _airplane = name;
        }

        public void Ascend(int height) 
        {
            _altitude += height;
        }

        public void Descend(int height)
        {
            if ((_altitude - height) > 0)
            {
                _altitude -= height;
            }
            else
            {
                _altitude = 0;
            }
            
        }

        public override string Move()
        {
            var message = base.Move();
            return $"Moving along at an altitude of {_altitude} metres.";
        }

        public override string Move(int times)
        {
            var message = base.Move(times);
            return $"Moving along {times} times at an altitude of {_altitude} metres.";
        }
        public override string ToString()
        {
            return $"Thank you for flying {_airplane}: ClassessApp.Airplane capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: {Position} altitude: {_altitude}.";

        }

    }
}
