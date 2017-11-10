using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3PicEditor
{
    public partial class PicEditor : Form
    {
        public PicEditor()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void PicEditor_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogOrigin.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialogOrigin.FileName;
            pictureBoxOrigin.Image = Image.FromFile(filename);
            pictureBoxOrigin.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void saveFilteredPictureAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogFiltered.ShowDialog() == DialogResult.Cancel)
                return;

            if (pictureBoxFiltered.Image != null)
            {
                // получаем выбранный файл
                string filename = saveFileDialogFiltered.FileName;
                pictureBoxFiltered.Image.Save(saveFileDialogFiltered.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("There is no image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void blurringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigin.Image != null)
            {
                Bitmap filteredPic = Filter.FilterPic("Gaussian blur", new Bitmap(pictureBoxOrigin.Image));
                pictureBoxFiltered.Image = filteredPic;
                pictureBoxFiltered.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("There is no image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void increaseTheClarityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigin.Image != null)
            {
                Bitmap filteredPic = Filter.FilterPic("Increase the clarity", new Bitmap(pictureBoxOrigin.Image));
                pictureBoxFiltered.Image = filteredPic;
                pictureBoxFiltered.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("There is no image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findBordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigin.Image != null)
            {
                Bitmap filteredPic = Filter.FilterPic("Find edges", new Bitmap(pictureBoxOrigin.Image));
                pictureBoxFiltered.Image = filteredPic;
                pictureBoxFiltered.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("There is no image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigin.Image != null)
            {
                Bitmap filteredPic = Filter.FilterPic("Embossing", new Bitmap(pictureBoxOrigin.Image));
                pictureBoxFiltered.Image = filteredPic;
                pictureBoxFiltered.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("There is no image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boxsFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigin.Image != null)
            {
                Bitmap filteredPic = Filter.FilterPic("Box's filter", new Bitmap(pictureBoxOrigin.Image));
                pictureBoxFiltered.Image = filteredPic;
                pictureBoxFiltered.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("There is no image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxInputMedian_TextChanged(object sender, EventArgs e)
        {
            int Input = 0;
            if (toolStripTextBoxInputMedian.Text != "")
            {
                Input = Convert.ToInt32(toolStripTextBoxInputMedian.Text);
            }
            else
            {
                MessageBox.Show("You didn`t enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pictureBoxOrigin.Image != null)
            {
                Bitmap filteredPic = Filter.ApplyMedian(Input, new Bitmap(pictureBoxOrigin.Image));
                pictureBoxFiltered.Image = filteredPic;
                pictureBoxFiltered.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("There is no image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
