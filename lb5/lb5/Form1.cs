using System;

namespace lb5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ходаківський Владислав КН21 Варіант 5");
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(400, 400);
            Graphics graph = Graphics.FromImage(bmp);

            graph.FillRectangle(Brushes.LightBlue, new Rectangle(100, 100, 200, 100));
            graph.DrawString("№49", new Font("Arial", 10), Brushes.Black, new Point(105, 105));

            Point[] roofPoints =
            {
            new Point(100, 100),
            new Point(200, 50),
            new Point(300, 100)
            };
            graph.FillPolygon(Brushes.Red, roofPoints);

            graph.FillEllipse(Brushes.White, new Rectangle(187, 65, 25, 25));
            graph.DrawEllipse(Pens.Brown, new Rectangle(187, 65, 25, 25));

            graph.FillRectangle(Brushes.Brown, new Rectangle(125, 125, 50, 50));
            graph.FillRectangle(Brushes.White, new Rectangle(130, 130, 40, 40));
            graph.DrawLine(Pens.Brown, new Point(150, 125), new Point(150, 175));

            graph.FillRectangle(Brushes.Brown, new Rectangle(225, 125, 50, 50));
            graph.FillRectangle(Brushes.White, new Rectangle(230, 130, 40, 40));
            graph.DrawLine(Pens.Brown, new Point(250, 125), new Point(250, 175));

            graph.DrawLine(Pens.Brown, new Point(150, 150), new Point(125, 150));
            graph.DrawLine(Pens.Brown, new Point(250, 150), new Point(225, 150));

            pictureBox1.Image = bmp;
        }

    }
}