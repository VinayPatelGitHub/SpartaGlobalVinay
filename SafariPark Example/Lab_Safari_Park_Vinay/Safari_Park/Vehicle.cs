using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Safari_Park
{
    public class Vehicle
    {
        protected int _capacity;
        protected int _numPassengers;
        protected int _speed = 10;

        public int NumPassengers 
        {
            get { return _numPassengers; }
            //try
            set 
            {   if (value <= _capacity & value >= 0)
                {
                    _numPassengers = value;
                }
                else
                {
                    _numPassengers = _capacity;
                }
            }
        }

        public int Position { get; private set; }

        public virtual string Move()
        {
            Position += _speed;
            return $"Moving along";
        }

        public virtual string Move(int times)
        {
            Position += times * _speed;
            return $"Moving along {times} times";
        }

        public Vehicle()
        {
           
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }

    }
}
