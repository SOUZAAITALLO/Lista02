using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Quadrado
    {
        private double aresta;
        private double area;

        public Quadrado()
        {
            this.aresta = 0;
        }

        public Quadrado(double aresta)
        { 
            this.aresta = aresta;
        }
        public void setAresta(double aresta)
        {
            this.aresta = aresta;
        }

        public double getAresta()
        {
            return this.aresta;
        }

        public double getArea()
        {
            return this.area;
        }

        public void calcular()
        {
            this.area = this.aresta * this.aresta;
        }
    }
}
