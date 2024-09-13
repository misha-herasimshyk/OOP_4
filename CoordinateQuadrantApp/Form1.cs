using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoordinateQuadrantApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(xInput.Text);
                double y = Convert.ToDouble(yInput.Text);

                PointCoordinates point = new PointCoordinates(x, y);
                string quadrant = point.DetermineQuadrant();
                quadrantLabel.Text = "Точка знаходиться: " + quadrant;

                DisplayPointOnGraph(x, y);  
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для X і Y.");
            }
        }


        private void DisplayPointOnGraph(double x, double y)
        {

            graphPanel.Invalidate();
        }


        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen axisPen = new Pen(Color.Black, 2);


            int centerX = graphPanel.Width / 2;
            int centerY = graphPanel.Height / 2;
            g.DrawLine(axisPen, centerX, 0, centerX, graphPanel.Height);
            g.DrawLine(axisPen, 0, centerY, graphPanel.Width, centerY);


            if (double.TryParse(xInput.Text, out double x) && double.TryParse(yInput.Text, out double y))
            {
                Pen pointPen = new Pen(Color.DarkRed, 5);
                int scale = 20;


                int pointX = centerX + (int)(x * scale);
                int pointY = centerY - (int)(y * scale);


                g.DrawEllipse(pointPen, pointX - 2, pointY - 2, 5, 5);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

