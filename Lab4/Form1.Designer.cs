namespace Lab4
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
            pictureBox1 = new PictureBox();
            Load = new Button();
            greenButton = new Button();
            radioButton90 = new RadioButton();
            radioButton180 = new RadioButton();
            radioButton270 = new RadioButton();
            rotateButton = new Button();
            invButton = new Button();
            revButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(332, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 335);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Load
            // 
            Load.Location = new Point(69, 335);
            Load.Name = "Load";
            Load.Size = new Size(125, 59);
            Load.TabIndex = 1;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // radioButton90
            // 
            radioButton90.AutoSize = true;
            radioButton90.Location = new Point(69, 59);
            radioButton90.Name = "radioButton90";
            radioButton90.Size = new Size(37, 19);
            radioButton90.TabIndex = 2;
            radioButton90.TabStop = true;
            radioButton90.Text = "90";
            radioButton90.UseVisualStyleBackColor = true;
            // 
            // radioButton180
            // 
            radioButton180.AutoSize = true;
            radioButton180.Location = new Point(69, 84);
            radioButton180.Name = "radioButton180";
            radioButton180.Size = new Size(43, 19);
            radioButton180.TabIndex = 3;
            radioButton180.TabStop = true;
            radioButton180.Text = "180";
            radioButton180.UseVisualStyleBackColor = true;
            // 
            // radioButton270
            // 
            radioButton270.AutoSize = true;
            radioButton270.Location = new Point(69, 109);
            radioButton270.Name = "radioButton270";
            radioButton270.Size = new Size(43, 19);
            radioButton270.TabIndex = 4;
            radioButton270.TabStop = true;
            radioButton270.Text = "270";
            radioButton270.UseVisualStyleBackColor = true;
            // 
            // rotateButton
            // 
            rotateButton.Location = new Point(69, 134);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(75, 23);
            rotateButton.TabIndex = 5;
            rotateButton.Text = "Rotate";
            rotateButton.UseVisualStyleBackColor = true;
            rotateButton.Click += rotateButton_Click;
            // 
            // invButton
            // 
            invButton.Location = new Point(69, 163);
            invButton.Name = "invButton";
            invButton.Size = new Size(75, 23);
            invButton.TabIndex = 6;
            invButton.Text = "Invert colors";
            invButton.UseVisualStyleBackColor = true;
            invButton.Click += invButton_Click;
            // 
            // revButton
            // 
            revButton.Location = new Point(69, 192);
            revButton.Name = "revButton";
            revButton.Size = new Size(75, 23);
            revButton.TabIndex = 7;
            revButton.Text = "Upside down";
            revButton.UseVisualStyleBackColor = true;
            revButton.Click += revButton_Click;
            // 
            // greenButton
            // 
            greenButton.Location = new Point(69, 220);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(75, 23);
            greenButton.TabIndex = 2;
            greenButton.Text = "Only green";
            greenButton.UseVisualStyleBackColor = true;
            greenButton.Click += greenButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 495);
            Controls.Add(revButton);
            Controls.Add(invButton);
            Controls.Add(rotateButton);
            Controls.Add(radioButton270);
            Controls.Add(radioButton180);
            Controls.Add(radioButton90);
            Controls.Add(greenButton);
            Controls.Add(Load);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Load;
        private RadioButton radioButton90;
        private RadioButton radioButton180;
        private RadioButton radioButton270;
        private Button rotateButton;
        private Button invButton;
        private Button revButton;
        private Button greenButton;
    }
}
