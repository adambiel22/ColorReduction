
namespace OctreeAdamBielecki
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trueColorPictureBox = new System.Windows.Forms.PictureBox();
            this.alongPictureBox = new System.Windows.Forms.PictureBox();
            this.afterPictureBox = new System.Windows.Forms.PictureBox();
            this.colorNumberTrackBar = new System.Windows.Forms.TrackBar();
            this.numberColorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.reduceButton = new System.Windows.Forms.Button();
            this.afterSaveButton = new System.Windows.Forms.Button();
            this.alongSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trueColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alongPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorNumberTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // trueColorPictureBox
            // 
            this.trueColorPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trueColorPictureBox.Location = new System.Drawing.Point(12, 12);
            this.trueColorPictureBox.Name = "trueColorPictureBox";
            this.trueColorPictureBox.Size = new System.Drawing.Size(376, 234);
            this.trueColorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trueColorPictureBox.TabIndex = 0;
            this.trueColorPictureBox.TabStop = false;
            // 
            // alongPictureBox
            // 
            this.alongPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alongPictureBox.Location = new System.Drawing.Point(517, 239);
            this.alongPictureBox.Name = "alongPictureBox";
            this.alongPictureBox.Size = new System.Drawing.Size(243, 148);
            this.alongPictureBox.TabIndex = 1;
            this.alongPictureBox.TabStop = false;
            // 
            // afterPictureBox
            // 
            this.afterPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.afterPictureBox.Location = new System.Drawing.Point(517, 12);
            this.afterPictureBox.Name = "afterPictureBox";
            this.afterPictureBox.Size = new System.Drawing.Size(243, 160);
            this.afterPictureBox.TabIndex = 2;
            this.afterPictureBox.TabStop = false;
            // 
            // colorNumberTrackBar
            // 
            this.colorNumberTrackBar.Location = new System.Drawing.Point(12, 331);
            this.colorNumberTrackBar.Maximum = 256;
            this.colorNumberTrackBar.Minimum = 2;
            this.colorNumberTrackBar.Name = "colorNumberTrackBar";
            this.colorNumberTrackBar.Size = new System.Drawing.Size(353, 56);
            this.colorNumberTrackBar.TabIndex = 3;
            this.colorNumberTrackBar.Value = 3;
            this.colorNumberTrackBar.Scroll += new System.EventHandler(this.colorNumberTrackBar_Scroll);
            // 
            // numberColorLabel
            // 
            this.numberColorLabel.AutoSize = true;
            this.numberColorLabel.Location = new System.Drawing.Point(371, 331);
            this.numberColorLabel.Name = "numberColorLabel";
            this.numberColorLabel.Size = new System.Drawing.Size(17, 20);
            this.numberColorLabel.TabIndex = 4;
            this.numberColorLabel.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of colors";
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Location = new System.Drawing.Point(12, 252);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(125, 29);
            this.chooseImageButton.TabIndex = 6;
            this.chooseImageButton.Text = "Choose Image";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // reduceButton
            // 
            this.reduceButton.Location = new System.Drawing.Point(12, 393);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(94, 29);
            this.reduceButton.TabIndex = 7;
            this.reduceButton.Text = "Reduce";
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // afterSaveButton
            // 
            this.afterSaveButton.Location = new System.Drawing.Point(517, 178);
            this.afterSaveButton.Name = "afterSaveButton";
            this.afterSaveButton.Size = new System.Drawing.Size(94, 29);
            this.afterSaveButton.TabIndex = 8;
            this.afterSaveButton.Text = "Save";
            this.afterSaveButton.UseVisualStyleBackColor = true;
            this.afterSaveButton.Click += new System.EventHandler(this.afterSaveButton_Click);
            // 
            // alongSaveButton
            // 
            this.alongSaveButton.Location = new System.Drawing.Point(517, 393);
            this.alongSaveButton.Name = "alongSaveButton";
            this.alongSaveButton.Size = new System.Drawing.Size(94, 29);
            this.alongSaveButton.TabIndex = 9;
            this.alongSaveButton.Text = "Save";
            this.alongSaveButton.UseVisualStyleBackColor = true;
            this.alongSaveButton.Click += new System.EventHandler(this.alongSaveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alongSaveButton);
            this.Controls.Add(this.afterSaveButton);
            this.Controls.Add(this.reduceButton);
            this.Controls.Add(this.chooseImageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberColorLabel);
            this.Controls.Add(this.colorNumberTrackBar);
            this.Controls.Add(this.afterPictureBox);
            this.Controls.Add(this.alongPictureBox);
            this.Controls.Add(this.trueColorPictureBox);
            this.Name = "MainForm";
            this.Text = "Color reduction";
            ((System.ComponentModel.ISupportInitialize)(this.trueColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alongPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorNumberTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trueColorPictureBox;
        private System.Windows.Forms.PictureBox alongPictureBox;
        private System.Windows.Forms.PictureBox afterPictureBox;
        private System.Windows.Forms.TrackBar colorNumberTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button chooseImageButton;
        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.Button afterSaveButton;
        private System.Windows.Forms.Button alongSaveButton;
        private System.Windows.Forms.Label numberColorLabel;
    }
}

