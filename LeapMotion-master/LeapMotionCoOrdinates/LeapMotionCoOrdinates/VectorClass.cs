using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapMotionCoOrdinates
{
    class VectorClass
    {
        double x;
        double y;
        double z;

        public double X
        {
            set { x = value; }
            get { return x; }
        }

        public double Y
        {
            set { y = value; }
            get { return y; }
        }

        public double Z
        {
            set { z = value; }
            get { return z; }
        }

        public VectorClass()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public VectorClass(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public VectorClass Norm()
        {
            VectorClass _return = new VectorClass(x / Math.Sqrt(x * x + y * y + z * z), y / Math.Sqrt(x * x + y * y + z * z), z / Math.Sqrt(x * x + y * y + z * z));
            return _return;
        }

        public double Magnitude()
        {
            double _return = Math.Sqrt(x * x + y * y + z * z);
            return _return;
        }

        public static VectorClass operator +(VectorClass _vectorA, VectorClass _vectorB)
        {
            VectorClass _vectorClass = new VectorClass();
            _vectorClass.X = _vectorA.X + _vectorB.X;
            _vectorClass.Y = _vectorA.Y + _vectorB.Y;
            _vectorClass.Z = _vectorA.Z + _vectorB.Z;
            return _vectorClass;
        }

        public static VectorClass operator -(VectorClass _vectorA, VectorClass _vectorB)
        {
            VectorClass _vectorClass = new VectorClass();
            _vectorClass.X = _vectorA.X - _vectorB.X;
            _vectorClass.Y = _vectorA.Y - _vectorB.Y;
            _vectorClass.Z = _vectorA.Z - _vectorB.Z;
            return _vectorClass;
        }
    }
}
