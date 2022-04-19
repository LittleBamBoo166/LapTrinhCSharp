using System;

namespace _1
{
    class Rectangle:Shape
    {
        private string firstEdge;
        private string secondEdge;
        private string thirdEdge;
        private string fourthEdge;

        public Rectangle(int edgeNumber, string firstEdge, string secondEdge, string thirdEdge, string fourthEdge):base(edgeNumber)
        {
            this.firstEdge = firstEdge;
            this.secondEdge = secondEdge;
            this.thirdEdge = thirdEdge;
            this.fourthEdge = fourthEdge;
        }

        public override void translationSpells(Vecto vecto)
        {
            
        }
    }
}