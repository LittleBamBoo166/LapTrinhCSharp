using System;

namespace _1
{
    public class Shape
    {
        struct Vecto
        {
            string startPoint;
            string endPoint;
        }

        protected int edgeNumber;

        public Shape(int edgeNumber)
        {
            this.edgeNumber = edgeNumber;
        }

        public abstract void translationSpells(Vecto vecto);
    }
}