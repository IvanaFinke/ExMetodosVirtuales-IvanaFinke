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
            //Se agrega color verde si es null

            Pen pen = this.Pen ?? new Pen(Color.Green);

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
        
        //Parte b)
         public override void Dibujar(Graphics graphics, int x, int y)
        {
            //Se agrega color violeta si es null
            
            Pen pen = this.Pen ?? new Pen(Color.MediumVioletRed);
    
            Point[] points = new Point[5]
            {
                new Point(x,y),
                new Point(x + ancho,y),
                new Point(x + ancho,y + alto),
                new Point(x,y + alto),
                new Point(x,y)
            };
            // DrawPolygon dibuja un poligono dado un conjunto de puntos y un lapiz
            graphics.DrawPolygon(pen, points);
        }

        
    }


    public class Circulo : Figura
    {
        private int radio;

        // Constructor
        public Circulo(int radio)
        {
            this.radio = radio;
        }

        public override void Dibujar(Graphics graphics, int x, int y)
        {
            Pen pen = this.Pen ?? new Pen(Color.Red);


            graphics.DrawEllipse(pen, x, y, radio, radio);
        }
    }

    //Parte E:
    public class TrianguloIsosceles : Figura
    {
        protected int lado;
        protected int ladoBase;

        public TrianguloIsosceles(int lado, int ladoBase)
        {
            this.lado = lado;
            this.ladoBase = ladoBase;
        }

        public override void Dibujar(Graphics graphics, int x, int y)
        {
            //Se agrega color violeta si es null

            Pen pen = this.Pen ?? new Pen(Color.SteelBlue);

            double altura = Math.Sqrt(Math.Pow(lado, 2) - Math.Pow(baseTriangulo / 2.0, 2));

            Point[] points = new Point[3]
            {
                new Point(x, (int)(y + alto)),
                new Point(x + ladoBase/2,y),
                new Point(x + ladoBase,(int)(y + alto))
              
            };
            // DrawPolygon dibuja un poligono dado un conjunto de puntos y un lapiz
            graphics.DrawPolygon(pen, points);
        }


    }
    
    public class TrianguloEquilatero : Figura
    {
        protected int lado;

        public TrianguloEquilatero(int lado)
        {
            this.lado = lado;
        }
        
         public override void Dibujar(Graphics graphics, int x, int y)
        {
            //Se agrega color violeta si es null

            Pen pen = this.Pen ?? new Pen(Color.MintCream);

            double altura = (Math.Sqrt(3) / 2) * lado;

            Point[] points = new Point[3]
            {
                new Point(x,(int)(y + alto)),
                new Point(x + lado/2,y),
                new Point(x + lado,(int)(y + alto))
            };
            // DrawPolygon dibuja un poligono dado un conjunto de puntos y un lapiz
            graphics.DrawPolygon(pen, points);
        }

        
    }
}
