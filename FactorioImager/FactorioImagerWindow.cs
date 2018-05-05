using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioImager
{
    public partial class FactorioImagerWindow : Form
    {
        public FactorioImagerWindow()
        {
            InitializeComponent();
        }

        private Bitmap original;
        private Bitmap map;

        private bool? abortCache = null;

        private (int, int) gridSize(int width, int height, int size) => (width = (int)Math.Ceiling((decimal)width / (decimal)size), height = (int)Math.Ceiling((decimal)height / (decimal)size));
        private (int, int) gridToImageCoordinates(int gx, int gy, int xoff, int yoff, int size) => (gx * size + xoff, gy * size + yoff);

        private bool isHit(Bitmap image, int gx, int gy, int xoff, int yoff, int size, float limit)
        {
            float avg = this.averageColor(image, gx, gy, xoff, yoff, size);
            return avg < limit;
        }

        private bool abortPrompt()
        {
            if (this.abortCache.HasValue)
                return this.abortCache.Value;

            bool result = MessageBox.Show($"This process seems to take a long time, maybe the image is too large or the grid size is too small.{Environment.NewLine}Would you like to continue?", "Time warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No;
            this.abortCache = result;

            return result;
        }

        private float averageColor(Bitmap image, int gx, int gy, int xoff, int yoff, int size)
        {
            Bitmap average = new Bitmap(1, 1);
            using (Graphics averageGraphics = Graphics.FromImage(average))
            {
                averageGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                (int x, int y) = this.gridToImageCoordinates(gx, gy, xoff, yoff, size);
                averageGraphics.DrawImage(image, new Rectangle(0, 0, 1, 1), new Rectangle(x, y, size, size), GraphicsUnit.Pixel);
            }

            Color color = average.GetPixel(0, 0);

            return (((color.R + color.G + color.B) / 3.0f) + (255 - color.A)) / 255.0f;
        }

        private Bitmap generateMap(Bitmap image, int size, int xoff, int yoff, float limit, bool inverted)
        {
            DateTime startTime = DateTime.Now;

            (int mw, int mh) = this.gridSize(image.Width, image.Height, size);

            Bitmap map = new Bitmap(mw, mh);
            using (Graphics graphics = Graphics.FromImage(map))
            {
                graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, mw, mh));
                for (int gx = 0; gx < mw; gx++)
                {
                    for (int gy = 0; gy < mh; gy++)
                    {
                        if (this.isHit(image, gx, gy, xoff, yoff, size, limit) != inverted)
                            graphics.FillRectangle(Brushes.Black, new Rectangle(gx, gy, 1, 1));

                        if ((DateTime.Now - startTime).TotalSeconds > 2 && this.abortPrompt())
                            return map;
                    }
                }
            }

            return map;
        }

        private Bitmap generateGrid(Bitmap image, int size, int xoff, int yoff)
        {
            (int mw, int mh) = this.gridSize(image.Width, image.Height, size);

            Bitmap grid = new Bitmap(image);
            using (Graphics gridGraphics = Graphics.FromImage(grid))
            {
                for (int gx = 0; gx < mw; gx++)
                {
                    (int x, int y) = this.gridToImageCoordinates(gx, 0, xoff, yoff, size);
                    gridGraphics.DrawLine(Pens.Red, x, 0, x, image.Height);
                }

                for (int gy = 0; gy < mh; gy++)
                {
                    (int x, int y) = this.gridToImageCoordinates(0, gy, xoff, yoff, size);
                    gridGraphics.DrawLine(Pens.Red, 0, y, image.Width, y);
                }
            }

            return grid;
        }

        private Bitmap generatePreview(Bitmap map, int size)
        {
            DateTime startTime = DateTime.Now;

            Bitmap preview = new Bitmap(map.Width * size, map.Height * size);
            (int mw, int mh) = this.gridSize(preview.Width, preview.Height, size);

            using (Graphics previewGraphics = Graphics.FromImage(preview))
            {
                previewGraphics.FillRectangle(Brushes.White, new Rectangle(0, 0, preview.Width, preview.Height));
                for (int gx = 0; gx < mw; gx++)
                {
                    for (int gy = 0; gy < mh; gy++)
                    {
                        if (map.GetPixel(gx, gy).GetBrightness() == Color.Black.GetBrightness())
                        {
                            (int x, int y) = this.gridToImageCoordinates(gx, gy, 0, 0, size);
                            previewGraphics.FillRectangle(Brushes.Black, new Rectangle(x, y, size, size));
                        }

                        if ((DateTime.Now - startTime).TotalSeconds > 2 && this.abortPrompt())
                            return preview;
                    }
                }
            }

            return preview;
        }

        private Bitmap resizeToFit(Bitmap image, int width, int height)
        {
            double ratioX = (double)width / (double)image.Width;
            double ratioY = (double)height / (double)image.Height;
            double ratio = ratioX < ratioY ? ratioX : ratioY;

            Bitmap resized = new Bitmap(image, (int)(image.Width * ratio), (int)(image.Height * ratio));
            Bitmap fullSize = new Bitmap(width, height);
            using (Graphics sizeGraphics = Graphics.FromImage(fullSize))
                sizeGraphics.DrawImageUnscaled(resized, 0, 0);

            return fullSize;
        }

        private void loadImage(string path)
        {
            this.original = (Bitmap)Bitmap.FromFile(path);
        }

        private void updateGrid()
        {
            int size = (int)nudGridSize.Value;
            int xoff = (int)nudXoff.Value;
            int yoff = (int)nudYoff.Value;
            float limit = (float)nudLimit.Value / 100.0f;
            bool inverted = cbInvert.Checked;

            this.abortCache = null;

            this.map = this.generateMap(this.original, size, xoff, yoff, limit, inverted);
            this.pbGridView.Image = this.resizeToFit(this.generateGrid(this.original, size, xoff, yoff), this.pbGridView.Width, this.pbGridView.Height);
            this.pbPreview.Image = this.resizeToFit(this.generatePreview(this.map, size), this.pbPreview.Width, this.pbPreview.Height);
        }

        private void generateBlueprint()
        {
            DateTime startTime = DateTime.Now;

            this.updateGrid();

            string propName = txtPropName.Text;
            bool isEntity = rbEntity.Checked;

            // DON'T LOOK
            string json = "{'blueprint':{'icons':[{'signal':{'type':'item','name':'concrete'},'index':1}],'" + (rbTile.Checked ? "tiles" : "entities") + "':[";
            int entityNumber = 0;

            for (int gx = 0; gx < this.map.Width; gx++)
            {
                for (int gy = 0; gy < this.map.Height; gy++)
                {
                    if (this.map.GetPixel(gx, gy).GetBrightness() == Color.Black.GetBrightness())
                    {
                        int px = gx - (int)Math.Ceiling((double)this.map.Width / 2.0);
                        int py = gy - (int)Math.Ceiling((double)this.map.Height / 2.0);
                        json += "{'position':{'x':" + px + ",'y':" + py + "},'name':'" + propName + "'" + (isEntity ? ",'entity_number':" + (++entityNumber) : "") + "},";
                    }

                    if ((DateTime.Now - startTime).TotalSeconds > 2 && this.abortPrompt())
                        return;
                }
            }

            if (json.EndsWith(","))
                json = json.Substring(0, json.Length - 1);
            json += "],'item':'blueprint','label':'Generated by Gachl','version':64426606595}}";
            json = json.Replace('\'', '"');

            txtBlueprint.Text = Blueprint.Encode(json);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Images (*.png;*.jpg)|*.png;*.jpg;*.jpeg"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            this.loadImage(openFileDialog.FileName);
            this.generateBlueprint();
        }

        private void nudGridSize_ValueChanged(object sender, EventArgs e)
        {
            this.nudXoff.Maximum = nudGridSize.Value - 1;
            this.nudYoff.Maximum = nudGridSize.Value - 1;
        }

        private void btnUpdatePreview_Click(object sender, EventArgs e)
        {
            if (this.original == null)
                return;

            this.updateGrid();
        }

        private void btnGenerateBlueprint_Click(object sender, EventArgs e)
        {
            if (this.original == null)
                return;

            this.generateBlueprint();
        }

        private void txtBlueprint_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtBlueprint.SelectAll();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"1. Load an image, preferably monochrome or grayscale{Environment.NewLine}2. Adjust grid settings to needs, check using Update grid button{Environment.NewLine}3. Adjust threshold limit for grayscale images{Environment.NewLine}4. Enter tile or entity name in prop selection{Environment.NewLine}5. Select prop type{Environment.NewLine}6. Generate blueprint, copy and paste into game{Environment.NewLine}{Environment.NewLine}2018 CodeFreak.net, Version 1.5", "About", MessageBoxButtons.OK);
        }
    }
}
