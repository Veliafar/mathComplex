using System;

namespace mathComplex
{
    struct Complex
    {
        double re;
        double im;


        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static Complex Sum(Complex x1, Complex x2)
        {
            Complex result = new Complex(
               re: x1.re + x2.re,
               im: x1.im + x2.im
               );

            return result;
        }

        public static Complex Sub(Complex x1, Complex x2)
        {
            Complex result = new Complex(
               re: x1.re - x2.re,
               im: x1.im - x2.im
               );

            return result;
        }

        public static Complex Multi(Complex x1, Complex x2)
        {
            Complex result = new Complex(
               re: (x1.re * x2.re) - (x1.im * x2.im),
               im: (x1.re * x2.im) + (x1.im * x2.re)
               );

            return result;
        }

        public static Complex Divide(Complex x1, Complex x2)
        {
            Complex result = new Complex(
               re: ((x1.re * x2.re) + (x1.im * x2.im)) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2)),
               im: (x1.re * x2.im) - (x1.im * x2.re) / (Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2))
               );

            return result;
        }

        public string IntoString()
        {
            if (im < 0)
            {
                return re + " - " + (-im) + "i";
            }
            else
            {
                return re + " + " + im + "i";
            }
        }
    }
}

