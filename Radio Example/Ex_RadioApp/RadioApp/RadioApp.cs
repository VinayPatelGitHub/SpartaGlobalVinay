using System;
using System.Dynamic;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on;

        public int Channel 
        { 
            get
            {
                return _channel;
            }
            set
            {
                if (_on == true && (value > 0 && value < 5))
                {
                    _channel = value;
                }
            }
        }

        public string Play()
        {
            string hello = ""; 
            if (_on == true)
            {
                hello = $"Playing channel {Channel}";
            }
            else
            {
                hello = "Radio is off";
            }          
            return hello;
        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }
    }

    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}