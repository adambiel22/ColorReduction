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
            numberColorLabel.Text = colorNumberTrackBar.Value.ToString();
        }

        private void colorNumberTrackBar_Scroll(object sender, EventArgs e)
        {
            numberColorLabel.Text = colorNumberTrackBar.Value.ToString();
        }

        private void reduceButton_Click(object sender, EventArgs e)
        {
            OctreeColorReducer octreeColorReducerAfterConstruction = new OctreeColorReducerAfterConstruction();
            afterPictureBox.Image = octreeColorReducerAfterConstruction.ReduceBitmap
                (new Bitmap(trueColorPictureBox.Image), colorNumberTrackBar.Value);

            OctreeColorReducer octreeColorReducerAlongConstruction = new OctreeReducerAlongConstruction();
            alongPictureBox.Image = octreeColorReducerAlongConstruction.ReduceBitmap
                (new Bitmap(trueColorPictureBox.Image), colorNumberTrackBar.Value);
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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                trueColorPictureBox.Image = new Bitmap(openFileDialog.FileName);
            }

        }

        private void afterSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                afterPictureBox.Image.Save(saveFileDialog.FileName);
            }
        }

        private void alongSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                alongPictureBox.Image.Save(saveFileDialog.FileName);
            }
        }
    }
}
