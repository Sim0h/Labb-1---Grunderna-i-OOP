using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Grunderna_i_OOP
{
    internal class Circle
    {
        float _pi = 3.141f;
        int _Radius;

        public Circle(int Radius)
        {
            
            _Radius = Radius;
        }

        public float Printarea() 
        {
           float area = _Radius * _Radius* _pi;
            return area;
        }

            
    }
}
