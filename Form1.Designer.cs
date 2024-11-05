namespace P_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label_komunikat = new Label();
            pictureBox = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            groupBox1.Location = new Point(40, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imiona";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radioButton4.ForeColor = Color.RoyalBlue;
            radioButton4.Location = new Point(46, 124);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(106, 25);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Agnieszka";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += RadioButtonImieCheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radioButton3.ForeColor = Color.Red;
            radioButton3.Location = new Point(46, 62);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(92, 25);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Karolina";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += RadioButtonImieCheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radioButton2.Location = new Point(46, 93);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Magda";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButtonImieCheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radioButton1.ForeColor = Color.ForestGreen;
            radioButton1.Location = new Point(46, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Iwona";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RadioButtonImieCheckedChanged;
            // 
            // label_komunikat
            // 
            label_komunikat.AutoSize = true;
            label_komunikat.BackColor = Color.Yellow;
            label_komunikat.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label_komunikat.Location = new Point(381, 26);
            label_komunikat.Name = "label_komunikat";
            label_komunikat.Size = new Size(40, 30);
            label_komunikat.TabIndex = 1;
            label_komunikat.Text = "???";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(389, 123);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(244, 242);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(label_komunikat);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "P-2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label_komunikat;
        private PictureBox pictureBox;
    }
}
