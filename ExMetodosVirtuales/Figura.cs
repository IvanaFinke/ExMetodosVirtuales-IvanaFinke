using System;
using System.Drawing;

namespace Figuras
{
    public class Figura
    {
        public virtual void Dibujar(Graphics graphics, int x, int y)
        {

        }
        
        //Nuevo: las figuras van a tener una propiedad de lapiz
        public Pen Pen { get; set; }
    }


    public class Rectangulo : Figura
    {
        protected int alto;
        protected int ancho;
        
        // Constructor
        public Rectangulo(int ancho, int alto) 
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public override void Dibujar(Graphics graphics, int x, int y)
        {
            //Se agrega color verde esoecifico

            Pen pen = new Pen(Color.Green);

            Point[] points = new Point[4]
            { 
                new Point(x,y), 
                new Point(x+ancho,y), 
                new Point(x+ancho,y+alto), 
                new Point(x,y+alto) 
            };
            // DrawPolygon dibuja un poligono dado un conjunto de puntos y un lapiz
            graphics.DrawPolygon(pen, points);
        }
    }

    public class Cuadrado : Rectangulo
    {
        // Constructor. Un cuadrado es un rectangulo con ancho = alto
        public Cuadrado(int lado) : base(lado, lado)
        {
        }
        
         public override void Dibujar(Graphics graphics, int x, int y)
        {
            //Se agrega color violeta  esoecifico
           Pen pen = new Pen(Color.MediumVioletRed);
    
            Point[] points = new Point[4]
            {
                new Point(x,y),
                new Point(x + ancho,y),
                new Point(x + ancho,y + alto),
                new Point(x,y + alto),
                new Point(x,y)
            };
            // DrawPolygon dibuja un poligono dado un conjunto de puntos y un lapiz
            graphics.DrawRectangle(pen, points);
        }

        
    }


    public class Circulo : Figura
    {
        private int radio;

        // Constructor
        public Circulo(int radio)
        {
            this.radio= radio;
        }

        public override void Dibujar(Graphics graphics, int x, int y)
        {
            Pen pen = new Pen(Color.Red);
            graphics.DrawEllipse(pen,x,y, radio, radio);
        }
    }
}
