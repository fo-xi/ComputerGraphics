using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork5._1
{
    public class Point
    {
        private float _x;

        private float _y;

        private float _z;

        private float _h;

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public float Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }

        public float H
        {
            get
            {
                return _h;
            }
            set
            {
                _h = value;
            }
        }

        public Point(float x, float y, float z, float h)
        {
            X = x;
            Y = y;
            Z = z;
            H = h;
        }
    }
}
