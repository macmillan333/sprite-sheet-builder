using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteSheetBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addInputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Multiselect = true;
            d.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in d.FileNames)
                {
                    inputImageListBox.Items.Add(file);
                }
            }
        }

        private void deleteInputButton_Click(object sender, EventArgs e)
        {
            if (inputImageListBox.SelectedIndex > 0)
            {
                inputImageListBox.Items.RemoveAt(inputImageListBox.SelectedIndex);
            }
        }

        private void browseOutputButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                outputImageTextBox.Text = d.FileName;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (inputImageListBox.Items.Count == 0) return;

            try
            {
                int numImages = inputImageListBox.Items.Count;
                int columns = int.Parse(spritesPerRowTextBox.Text);
                int rows = (numImages - 1) / columns + 1;

                // Read in the 1st image to determine output size.
                Bitmap i = new Bitmap(inputImageListBox.Items[0] as string);
                int width = i.Width;
                int height = i.Height;

                Bitmap output = new Bitmap(width * columns, height * rows,
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                for (int r = 0; r < rows; r++)
                {
                    int cursorY = r * height;
                    for (int c = 0; c < columns; c++)
                    {
                        int imageIndex = r * columns + c;
                        Bitmap input = null;
                        if (imageIndex < numImages)
                        {
                            input = new Bitmap(inputImageListBox.Items[imageIndex] as string);
                        }
                        int cursorX = c * width;
                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                if (input == null)
                                {
                                    output.SetPixel(cursorX + x, cursorY + y, Color.Transparent);
                                }
                                else
                                {
                                    output.SetPixel(cursorX + x, cursorY + y,
                                        input.GetPixel(x, y));
                                }
                            }
                        }
                    }
                }

                output.Save(outputImageTextBox.Text);
                MessageBox.Show("Complete.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
