using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex12
{
    internal class Triangulo
    {
        private double v1;
        private double v2;
        private double v3;
        private string classificacao;

        public Triangulo()
        {
            this.v1 = 0;
            this.v2 = 0;
            this.v3 = 0;
        }
        public Triangulo(double v1, double v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void setV1(double v1)
        {
            this.v1 = v1;
        }
        public void setV2(double v2)
        {
            this.v2 = v2;
        }
        public void setV3(double v3)
        {
            this.v3 = v3;
        }

        public double getV1()
        {
            return this.v1;
        }
        public double getV2()
        {
            return this.v2;
        }
        public double getV3()
        {
            return this.v3;
        }
        public string getClassificacao()
        {
            return this.classificacao;
        }
        public void calcular()
        {
            if ((this.v1 + this.v2) > this.v3)
            {
                if ((this.v2 + this.v3) > this.v1)
                {
                    if ((this.v1 + this.v3) > this.v2)
                    {
                        if (this.v1 == this.v2)
                        {
                            if (this.v2 == this.v3)
                            {
                                this.classificacao = "Triângulo Equilatero";
                            }
                            else
                            {
                                this.classificacao = "Triângulo Isósceles";
                            }
                        }
                        else
                        {
                            if (this.v1 == this.v3)
                            {
                                this.classificacao = "Triângulo Isósceles";
                            }
                            else
                            {
                                if (this.v2 == this.v3)
                                {
                                    this.classificacao = "Triângulo Isósceles";
                                }
                                else
                                {
                                    this.classificacao = "Triângulo Escaleno";
                                }
                            }
                        }
                    }
                    else
                    {
                        this.classificacao = "Não Formam um Triângulo";
                    }
                }
                else
                {
                    this.classificacao = "Não Formam um Triângulo";
                }
            }
            else
            {
                this.classificacao = "Não Formam um Triângulo";
            }
        }
    }
}
