using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Triângulo
    {
        private double b;
        private double h;
        private double area;

        public Triângulo()
        {
            this.b = 0;
            this.h = 0;
        }

        public Triângulo(double b, double h)
        { 
            this.b = b;
            this.h = h;
        }

        public void setB(double b)
        {
            this.b = b;
        }
        public void setH(double h)
        {
            this.h = h;
        }
        public double getB()
        {
            return this.b;
        }
        public double getH()
        {
            return this.h;
        }

        public double getArea()
        {
            return this.area;
        }
        public void calcular()
        {
            this.area = (this.b * this.h)/2;
        }
    }
}
