namespace PaintProgProject
{
    public partial class Form1 : Form
    {
        Bitmap Bitmap;
        bool mouseDown = false;
        public Form1()
        {
            InitializeComponent();
            Bitmap = new Bitmap(Size.Width, Size.Height);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Console.Write("");
                Graphics g = Graphics.FromImage(Bitmap);
                Pen p = new Pen(Color.Aqua, 2);
                g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1);
                Refresh();

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(Bitmap, 0, 0);
        }
    }
}