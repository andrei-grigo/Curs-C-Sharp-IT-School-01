using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17
{
    public abstract class Shape
    {
        public abstract float GetArea();
        public abstract float GetPerimeter();
    }

    class Square : Shape
    {
        float Latura;
        public Square(float latura)
        {
            Latura = latura;
        }
        public override float GetArea()
        {
            return Latura* Latura;
        }
        public override float GetPerimeter()
        {
            return Latura *4;
        }
    }
}