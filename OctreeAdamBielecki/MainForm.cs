using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace OctreeAdamBielecki
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            numberColorNumericUpDown.Minimum = 1;
            numberColorNumericUpDown.Maximum = int.MaxValue;
            numberColorNumericUpDown.DecimalPlaces = 0;
            numberColorNumericUpDown.Value = 50;
            trueColorPictureBox.Image = Properties.Resources.Flower;
        }

        private void reduceButton_Click(object sender, EventArgs e)
        {
            afterProgressBar.Value = 0;
            alongProgressBar.Value = 0;
            afterPictureBox.Image = null;
            alongPictureBox.Image = null;

            OctreeColorReducer octreeColorReducerAfterConstruction =
                new OctreeColorReducerAfterConstruction(afterProgressBar);
            afterPictureBox.Image = octreeColorReducerAfterConstruction.ReduceBitmap
                (new Bitmap(trueColorPictureBox.Image), (int)numberColorNumericUpDown.Value);

            OctreeColorReducer octreeColorReducerAlongConstruction =
                new OctreeColorReducerAlongConstruction(alongProgressBar);
            alongPictureBox.Image = octreeColorReducerAlongConstruction.ReduceBitmap
                (new Bitmap(trueColorPictureBox.Image), (int)numberColorNumericUpDown.Value);
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = 
                Path.Combine(
                Directory.GetParent(
                    Directory.GetParent(
                        Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName
                    , "Resources");
            openFileDialog.Filter =
                "Image Files(*.png,*.jpg,*.bmp,*.gif)|*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                trueColorPictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void afterSaveButton_Click(object sender, EventArgs e)
        {
            saveImage(afterPictureBox.Image);
        }

        private void alongSaveButton_Click(object sender, EventArgs e)
        {
            saveImage(alongPictureBox.Image);
        }

        private void saveImage(Image image)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.Filter =
                "Image Files(*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog.FileName = "reduced_picture";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog.FileName);
            }
        }
    }
}
