using System.Windows.Forms;

namespace ProgettoFiera
{
    public partial class Form1 : Form
    {


        Bitmap immaginegrezza;
        Bitmap immagine;
        Bitmap output;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Cerca = new OpenFileDialog();
            Cerca.Filter = "Image files (*.jpg; *.bmp; *.jpeg;)|*.jpg; *.bmp; *.jpeg";
            Cerca.ShowDialog();


            immaginegrezza = new Bitmap(Cerca.FileName);
            float fatform = (float)immaginegrezza.Width / (float)pictureBox1.Width;
            float highform = (float)immaginegrezza.Height / (float)pictureBox1.Height;

            immagine = new Bitmap(immaginegrezza, new Size((int)(immaginegrezza.Width / fatform), (int)(immaginegrezza.Height / highform)));


            pictureBox1.Image = immagine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap NewImage = new Bitmap(immagine.Width, immagine.Height);
            int x, y;



            for (x = 0; x < immagine.Width; x++)
            {
                for (y = 0; y < immagine.Height; y++)
                {

                    Color pixel = immagine.GetPixel(x, y);
                    int R;
                    int G;
                    int B;

                    R = (pixel.R + pixel.G + pixel.B) / 3;
                    G = (pixel.R + pixel.G + pixel.B) / 3;
                    B = (pixel.R + pixel.G + pixel.B) / 3;



                    Color newpixel = Color.FromArgb(R, G, B);
                    NewImage.SetPixel(x, y, newpixel);
                }
            }
            pictureBox1.Image = NewImage;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap NewImage = new Bitmap(immagine.Width, immagine.Height);
            int x, y;

            for (x = 0; x < immagine.Width; x++)
            {
                for (y = 0; y < immagine.Height; y++)
                {

                    Color pixel = immagine.GetPixel(x, y);
                    int R;
                    int G;
                    int B;

                    R = (pixel.R + pixel.G + pixel.B) / 3;
                    G = (pixel.R + pixel.G + pixel.B) / 3;
                    B = (pixel.R + pixel.G + pixel.B) / 3;

                    if (R < 127 && G < 127 && B < 127)
                    {
                        R = 0;
                        G = 0;
                        B = 0;
                    }
                    else
                    {
                        R = 255;
                        G = 255;
                        B = 255;
                    }


                    Color newpixel = Color.FromArgb(R, G, B);
                    NewImage.SetPixel(x, y, newpixel);
                }
            }
            pictureBox1.Image = NewImage;

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            Bitmap NewImage = new Bitmap(immagine.Width, immagine.Height);
            int x, y;

            int valore = 0;
            valore = trackBar1.Value;


            for (x = 0; x < immagine.Width; x++)
            {
                for (y = 0; y < immagine.Height; y++)
                {

                    Color pixel = immagine.GetPixel(x, y);
                    int R;
                    int G;
                    int B;

                    R = (pixel.R + pixel.G + pixel.B) / 3;
                    G = (pixel.R + pixel.G + pixel.B) / 3;
                    B = (pixel.R + pixel.G + pixel.B) / 3;

                    if (R < valore && G < valore && B < valore)
                    {
                        R = 0;
                        G = 0;
                        B = 0;
                    }
                    else
                    {
                        R = 255;
                        G = 255;
                        B = 255;
                    }


                    Color newpixel = Color.FromArgb(R, G, B);
                    NewImage.SetPixel(x, y, newpixel);
                }
            }
            pictureBox1.Image = NewImage;

        }

     

        
    }
}