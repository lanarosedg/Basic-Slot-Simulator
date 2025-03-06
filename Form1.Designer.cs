namespace ScatterSlotSimulator
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
            spinButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            balanceText = new Label();
            resultText = new Label();
            resetButton = new Button();
            quitButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // spinButton
            // 
            spinButton.Anchor = AnchorStyles.None;
            spinButton.BackColor = Color.FromArgb(205, 193, 255);
            spinButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            spinButton.ForeColor = Color.FromArgb(15, 44, 89);
            spinButton.Location = new Point(238, 257);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(127, 45);
            spinButton.TabIndex = 0;
            spinButton.Text = "Spin";
            spinButton.UseVisualStyleBackColor = false;
            spinButton.Click += spinButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(166, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Location = new Point(322, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Location = new Point(478, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // balanceText
            // 
            balanceText.Anchor = AnchorStyles.None;
            balanceText.AutoSize = true;
            balanceText.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            balanceText.ForeColor = Color.FromArgb(15, 44, 89);
            balanceText.Location = new Point(173, 37);
            balanceText.Name = "balanceText";
            balanceText.Size = new Size(112, 35);
            balanceText.TabIndex = 4;
            balanceText.Text = "Balance:";
            // 
            // resultText
            // 
            resultText.Anchor = AnchorStyles.None;
            resultText.AutoSize = true;
            resultText.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            resultText.ForeColor = Color.FromArgb(15, 44, 89);
            resultText.Location = new Point(405, 37);
            resultText.Name = "resultText";
            resultText.Size = new Size(94, 35);
            resultText.TabIndex = 5;
            resultText.Text = "Result:";
            resultText.UseWaitCursor = true;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.None;
            resetButton.BackColor = Color.FromArgb(162, 148, 249);
            resetButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            resetButton.ForeColor = Color.FromArgb(15, 44, 89);
            resetButton.Location = new Point(391, 257);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(127, 45);
            resetButton.TabIndex = 6;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // quitButton
            // 
            quitButton.Anchor = AnchorStyles.None;
            quitButton.BackColor = Color.FromArgb(255, 128, 128);
            quitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quitButton.ForeColor = Color.FromArgb(15, 44, 89);
            quitButton.Location = new Point(328, 321);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(94, 29);
            quitButton.TabIndex = 7;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 421);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 255);
            ClientSize = new Size(745, 450);
            Controls.Add(label1);
            Controls.Add(quitButton);
            Controls.Add(resetButton);
            Controls.Add(resultText);
            Controls.Add(balanceText);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(spinButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button spinButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label balanceText;
        private Label resultText;
        private Button resetButton;
        private Button quitButton;
        private Label label1;
    }
}
