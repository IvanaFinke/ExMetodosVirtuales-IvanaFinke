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

            var penRojo = new Pen(Color.Red);

            var penVerde = new Pen(Color.Green);

            var penVioleta = new Pen(Color.MediumVioletRed);

            figuras = new Figura[3]
            {
                new Circulo(60) {Pen = penRojo},
                new Rectangulo(30,50) {Pen = penVerde},
                new Cuadrado(45) {Pen = penVioleta}
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
