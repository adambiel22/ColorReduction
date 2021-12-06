
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
            this.alongPictureBox = new System.Windows.Forms.PictureBox();
            this.trueColorPictureBox = new System.Windows.Forms.PictureBox();
            this.afterPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.reduceButton = new System.Windows.Forms.Button();
            this.afterSaveButton = new System.Windows.Forms.Button();
            this.alongSaveButton = new System.Windows.Forms.Button();
            this.afterProgressBar = new System.Windows.Forms.ProgressBar();
            this.alongProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberColorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.alongPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberColorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // alongPictureBox
            // 
            this.alongPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alongPictureBox.Location = new System.Drawing.Point(709, 407);
            this.alongPictureBox.Name = "alongPictureBox";
            this.alongPictureBox.Size = new System.Drawing.Size(430, 280);
            this.alongPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alongPictureBox.TabIndex = 1;
            this.alongPictureBox.TabStop = false;
            // 
            // trueColorPictureBox
            // 
            this.trueColorPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trueColorPictureBox.Location = new System.Drawing.Point(12, 32);
            this.trueColorPictureBox.Name = "trueColorPictureBox";
            this.trueColorPictureBox.Size = new System.Drawing.Size(599, 369);
            this.trueColorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trueColorPictureBox.TabIndex = 0;
            this.trueColorPictureBox.TabStop = false;
            // 
            // afterPictureBox
            // 
            this.afterPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.afterPictureBox.Location = new System.Drawing.Point(709, 32);
            this.afterPictureBox.Name = "afterPictureBox";
            this.afterPictureBox.Size = new System.Drawing.Size(430, 280);
            this.afterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.afterPictureBox.TabIndex = 2;
            this.afterPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of colors";
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Location = new System.Drawing.Point(12, 407);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(125, 29);
            this.chooseImageButton.TabIndex = 6;
            this.chooseImageButton.Text = "Choose Image";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // reduceButton
            // 
            this.reduceButton.Location = new System.Drawing.Point(12, 538);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(94, 29);
            this.reduceButton.TabIndex = 7;
            this.reduceButton.Text = "Reduce";
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // afterSaveButton
            // 
            this.afterSaveButton.Location = new System.Drawing.Point(1044, 346);
            this.afterSaveButton.Name = "afterSaveButton";
            this.afterSaveButton.Size = new System.Drawing.Size(94, 29);
            this.afterSaveButton.TabIndex = 8;
            this.afterSaveButton.Text = "Save";
            this.afterSaveButton.UseVisualStyleBackColor = true;
            this.afterSaveButton.Click += new System.EventHandler(this.afterSaveButton_Click);
            // 
            // alongSaveButton
            // 
            this.alongSaveButton.Location = new System.Drawing.Point(1044, 721);
            this.alongSaveButton.Name = "alongSaveButton";
            this.alongSaveButton.Size = new System.Drawing.Size(94, 29);
            this.alongSaveButton.TabIndex = 9;
            this.alongSaveButton.Text = "Save";
            this.alongSaveButton.UseVisualStyleBackColor = true;
            this.alongSaveButton.Click += new System.EventHandler(this.alongSaveButton_Click);
            // 
            // afterProgressBar
            // 
            this.afterProgressBar.Location = new System.Drawing.Point(709, 318);
            this.afterProgressBar.Name = "afterProgressBar";
            this.afterProgressBar.Size = new System.Drawing.Size(429, 22);
            this.afterProgressBar.TabIndex = 10;
            // 
            // alongProgressBar
            // 
            this.alongProgressBar.Location = new System.Drawing.Point(709, 693);
            this.alongProgressBar.Name = "alongProgressBar";
            this.alongProgressBar.Size = new System.Drawing.Size(429, 22);
            this.alongProgressBar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reduction after constrution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Reduction along construction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "True image";
            // 
            // numberColorNumericUpDown
            // 
            this.numberColorNumericUpDown.Location = new System.Drawing.Point(12, 490);
            this.numberColorNumericUpDown.Name = "numberColorNumericUpDown";
            this.numberColorNumericUpDown.Size = new System.Drawing.Size(157, 27);
            this.numberColorNumericUpDown.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 770);
            this.Controls.Add(this.numberColorNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alongProgressBar);
            this.Controls.Add(this.afterProgressBar);
            this.Controls.Add(this.alongSaveButton);
            this.Controls.Add(this.afterSaveButton);
            this.Controls.Add(this.reduceButton);
            this.Controls.Add(this.chooseImageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.afterPictureBox);
            this.Controls.Add(this.alongPictureBox);
            this.Controls.Add(this.trueColorPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Color reduction";
            ((System.ComponentModel.ISupportInitialize)(this.alongPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberColorNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trueColorPictureBox;
        private System.Windows.Forms.PictureBox alongPictureBox;
        private System.Windows.Forms.PictureBox afterPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button chooseImageButton;
        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.Button afterSaveButton;
        private System.Windows.Forms.Button alongSaveButton;
        private System.Windows.Forms.ProgressBar afterProgressBar;
        private System.Windows.Forms.ProgressBar alongProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberColorNumericUpDown;
    }
}

