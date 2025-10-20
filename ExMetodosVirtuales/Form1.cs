using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Figuras
{
    public partial class Form1 : Form
    {
        Figura[] figuras;

        public Form1()
        {
            InitializeComponent();

            //PARTE B)
           /* var penRojo = new Pen(Color.Red);

            var penVerde = new Pen(Color.Green);

            var penVioleta = new Pen(Color.MediumVioletRed);

            figuras = new Figura[3]
            {
                new Circulo(60) {Pen = penRojo},
                new Rectangulo(30,50) {Pen = penVerde},
                new Cuadrado(45) {Pen = penVioleta}
            }; */

            //PARTE C.1)

             Random random = new Random();
            //Metodo de la clase random que genera tres numeros entre 0 y 255
            Color color1 = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            Color color2 = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            Color color3 = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            //PARTE E:
            Color color4 = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            Color color5 = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));


            Pen pen1 = new Pen(color1, 2);
            Pen pen2 = new Pen(color2, 2);
            Pen pen3 = new Pen(color3, 2);
            Pen pen4 = new Pen(color4, 2);
            Pen pen5 = new Pen(color4, 2);

            
            figuras = new Figura[3]
            {
                new Circulo(60) {Pen = pen1},
                new Rectangulo(50,80) {Pen = pen2},
                new Cuadrado(100) {Pen = pen3 }
                new TrianguloEquilatero(10) {Pen = pen5}
                new TrianguloIsosceles(13,10) {Pen = pen4}
                
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            //Pen pen = new Pen(Color.Black);
            //a) Las figuras deben mostrarse en trazo rojo
           // Pen penRojo = new Pen(Color.Red);
            for (int i = 0; i < figuras.Length; i++)
            {
                //figuras[i].Dibujar(penRojo,gr,i * 100, 50);
                figuras[i].Dibujar(gr,i * 100, 50);
            }

        }
    }
}
