using System;

namespace BTDiemDanh
{
    class PTB2
    {
        int a267, b267, c267;

        public PTB2() {

        }

        public PTB2(int a267, int b267, int c267) {
            this.a267 = a267;
            this.b267 = b267;
            this.c267 = c267;
        }

        public int getA() {
            return a267;
        }

        public int getB() {
            return b267;
        }

        public int getC() {
            return c267;
        }

        public void setA(int a267) {
            this.a267 = a267;
        }

        public void setB(int b267) {
            this.b267 = b267;
        }

        public void setC(int c267) {
            this.c267 = c267;
        }

        public int delta() {
            return (int) (Math.Pow(b267, 2) - 4 * a267 * c267);
        }

        public void result() {
            if (delta() < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta() == 0) 
            {
                double x267 = -b267 / (2 * a267);
                Console.WriteLine("Phuong trinh co nghiem duy nhat: x = " + x267);
            }
            else 
            {
                double x1 = (-b267 + Math.Sqrt(delta())) / (2 * a267);
                double x2 = (-b267 - Math.Sqrt(delta())) / (2 * a267);
                Console.WriteLine("Phuong trinh co 2 nghiem: x1 = " + x1 + "; x2 = " + x2);
            }
        }
    }
}