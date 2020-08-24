using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    class Hunter : Person
    {
        private string _camera;

        public Hunter(string fName, string lName, string camera =""): base(fName,lName)
        {
            _camera = camera;
        }

        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with thier {_camera}";
        }

        public Hunter()
        {
                
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }

    }
}
