using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureEditor
{
    public partial class Form1 : Form
    {
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();
        private Bitmap originalImage;
        private Bitmap currentImage;
        private Color selectedColor = Color.Red;
        public Form1()
        {
            InitializeComponent();
        }

        private void selectPictureBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    currentImage = new Bitmap(originalImage);
                    pictureBox.Image = currentImage;
                    undoStack.Clear();
                    redoStack.Clear();
                    undoStack.Push(currentImage);
                }
            }
        }

        private void ApplyImage(Bitmap image)
        {
            redoStack.Clear();
            redoStack.Push(currentImage);

            currentImage = new Bitmap(image);
            pictureBox.Image = currentImage;
            undoStack.Push(currentImage);
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 1)
            {
                redoStack.Push(undoStack.Pop());
                currentImage = new Bitmap(undoStack.Peek());
                pictureBox.Image = currentImage;
            }
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                currentImage = new Bitmap(redoStack.Pop());
                pictureBox.Image = currentImage;
                undoStack.Push(currentImage);
            }
        }

        private void ApplyBrightness(int brightness)
        {
            Bitmap newImage = new Bitmap(currentImage.Width, currentImage.Height);

            for (int y = 0; y < currentImage.Height; y++)
            {
                for (int x = 0; x < currentImage.Width; x++)
                {
                    Color pixel = currentImage.GetPixel(x, y);
                    int newR = Math.Max(0, Math.Min(255, pixel.R + brightness));
                    int newG = Math.Max(0, Math.Min(255, pixel.G + brightness));
                    int newB = Math.Max(0, Math.Min(255, pixel.B + brightness));
                    newImage.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }

            ApplyImage(newImage);
        }
        private void ApplySaturation(float saturationFactor)
        {
            Bitmap newImage = new Bitmap(currentImage.Width, currentImage.Height);

            for (int y = 0; y < currentImage.Height; y++)
            {
                for (int x = 0; x < currentImage.Width; x++)
                {
                    Color pixel = currentImage.GetPixel(x, y);
                    float avg = (pixel.R + pixel.G + pixel.B) / 3f;
                    int newR = (int)(avg + (pixel.R - avg) * saturationFactor);
                    int newG = (int)(avg + (pixel.G - avg) * saturationFactor);
                    int newB = (int)(avg + (pixel.B - avg) * saturationFactor);
                    newImage.SetPixel(x, y, Color.FromArgb(
                        Math.Max(0, Math.Min(255, newR)),
                        Math.Max(0, Math.Min(255, newG)),
                        Math.Max(0, Math.Min(255, newB))));
                }
            }

            ApplyImage(newImage);
        }

        private void ApplyColorFilter(Color filterColor)
        {
            Bitmap newImage = new Bitmap(currentImage.Width, currentImage.Height);
            var filterStrength = 0.4;

            for (int y = 0; y < currentImage.Height; y++)
            {
                for (int x = 0; x < currentImage.Width; x++)
                {
                    Color pixel = currentImage.GetPixel(x, y);
                    int newR = (int)(pixel.R * (1 - filterStrength) + filterColor.R * filterStrength);
                    int newG = (int)(pixel.G * (1 - filterStrength) + filterColor.G * filterStrength);
                    int newB = (int)(pixel.B * (1 - filterStrength) + filterColor.B * filterStrength);

                    newImage.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }

            ApplyImage(newImage);
        }


        private void grayscaleBtn_Click(object sender, EventArgs e)
        {
            Bitmap newImage = new Bitmap(currentImage.Width, currentImage.Height);

            for (int y = 0; y < currentImage.Height; y++)
            {
                for (int x = 0; x < currentImage.Width; x++)
                {
                    Color pixel = currentImage.GetPixel(x, y);
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;
                    newImage.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }

            ApplyImage(newImage);
        }

        private void redFilterBtn_Click(object sender, EventArgs e)
        {
            Bitmap newImage = new Bitmap(currentImage.Width, currentImage.Height);

            for (int y = 0; y < currentImage.Height; y++)
            {
                for (int x = 0; x < currentImage.Width; x++)
                {
                    Color pixel = currentImage.GetPixel(x, y);
                    newImage.SetPixel(x, y, Color.FromArgb(pixel.R, 0, 0));
                }
            }

            ApplyImage(newImage);
        }

        private void brightnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ApplyBrightness(brightnessTrackBar.Value);
        }

        private void saturationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            float saturationFactor = saturationTrackBar.Value / 100f;
            ApplySaturation(saturationFactor);
        }

        private void selectColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
                ApplyColorFilter(selectedColor);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            undoStack.Clear();
            redoStack.Clear();
            redoStack = new Stack<Bitmap>();
            var undo = currentImage;
            brightnessTrackBar.Value = 0;
            saturationTrackBar.Value = 0;
            currentImage = new Bitmap(originalImage);
            undoStack.Push(undo);
            undoStack.Push(currentImage);
            pictureBox.Image = currentImage;
        }
    }
}
