using System;

namespace _62_Tu_NunitTestPTBac2
{
    public class PTBac2_Tu62
    {
        private double a, b, c;
        public PTBac2_Tu62(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string Execute_Tu62(double a, double b, double c)
        {

            string result;
            if (a != 0)
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    result = "Phuong trinh co 2 nghiem: " + "x1= " + x1 + ", x2= " + x2;
                }
                else if (delta == 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    result = "Phuong trinh co nghiem kep: " + "x1=x2= " + x1;
                }
                else
                {
                    result = "Phuong trinh vo nghiem!";
                }
            }
            else
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        result = "Phuong trinh vo so nghiem!";
                    }
                    else
                    {
                        result = "Phuong trinh vo nghiem!";
                    }
                }
                else
                {
                    result = "Phuong trinh co 1 nghiem!: " + -c / (1.0 * b);
                }
            }
            return result;
        }
    }
}
