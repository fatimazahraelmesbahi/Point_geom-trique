using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_geométrique
{
    public class Point
    {
        private double Abscisse;            
        private double Ordonne;            
 
        public double getAbscisse()         
        {
            return Abscisse;
        }
 
        public void setAbscisse(double a)  
        {
            Abscisse = a;
        }
 
        public double getOrdonne()         
        {
            return Ordonne;
        }
 
        public void setOrdonne(double o)    
        {
            Ordonne = o;
        }
 
        public Point()                     
        {
        }
 
        public Point(double a, double o)   
        {
            Abscisse = a;
            Ordonne = o;
        }
 
        public double Norme()             
        {
            return Math.Sqrt(Abscisse * Abscisse + Ordonne * Ordonne);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a, o,n;
            Point p = new Point();                  
            Console.Out.Write("Donner l'abscisse: ");
            a = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner l'ordonne: ");
            o = double.Parse(Console.In.ReadLine());
            p.setAbscisse(a);                       
            p.setOrdonne(o);
            n=p.Norme();
            Console.Out.WriteLine("La norme du point (" + p.getAbscisse() + "," + p.getOrdonne() + ") est: " + n);
            Console.ReadKey();     
        }
    }
}
