using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_geométrique
{
    public class Point
    {
        private int X;
        private int Y;
        private int originalX;
        private int originalY;
        public void Reset()
        {
            X = originalX;
            Y = originalY;
        }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
            originalX = X;
            originalY = Y;
        }
        public void MoveX(int cord)
        {
            X = X + cord;
        }
        public void MoveY(int cord)
        {
            Y = Y + cord;
        }
        public string GetLocation()
        {
            return string.Format("location de cette point est {0},{1}", X, Y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(12, 13);
            p.MoveX(120);
            p.MoveY(130);
            string s = p.GetLocation();
            p.Reset();
        }
    }
}
