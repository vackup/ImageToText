using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImageToText_Click(object sender, EventArgs e)
        {
            var image = Image.FromFile(this.txtImagePath.Text);

            var bitmap = ResizeImage(image, 36, 36);

            for (int y = 0; y < bitmap.Height; y++) //for each row
            {
                for (int x = 0; x < bitmap.Width; x++) //for each column
                {
                    // Get the color of a pixel within myBitmap.
                    Color cl = bitmap.GetPixel(x, y);

                    int greyValue = (int)((cl.R * 0.3) + (cl.G * 0.59) + (cl.B * 0.11));

                    this.txtImageText.AppendText(greyValue.ToString().PadLeft(3, '0'));
                }

                this.txtImageText.AppendText(Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtImagePath.Text = @"";
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
