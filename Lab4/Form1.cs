using System.Net.NetworkInformation;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
                openFileDialog.Title = "Wybierz obrazek";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            Bitmap bmpDest = null;
            using (Bitmap bmpSource = new Bitmap(pictureBox1.Image))
            {
                bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height);
                for (int x = 0; x < bmpSource.Width; x++)
                {
                    for (int y = 0; y < bmpSource.Height; y++)
                    {
                        Color clrPixel = bmpSource.GetPixel(x, y);

                        
                        float total = clrPixel.R + clrPixel.G + clrPixel.B;
                        float greenRatio = total > 0 ? clrPixel.G / total : 0;

                        
                        if (greenRatio > 0.4f && clrPixel.G > 100 &&
                            clrPixel.G > clrPixel.R && clrPixel.G > clrPixel.B)
                        {
                           
                            bmpDest.SetPixel(x, y, Color.FromArgb(
                                clrPixel.A,
                                clrPixel.R / 4,  
                                clrPixel.G,      
                                clrPixel.B / 4)); 
                        }
                        else
                        {
                            bmpDest.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                    }
                }
            }
            pictureBox1.Image = (Image)bmpDest;

        }
    }
    }

