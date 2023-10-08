namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            lblCountdown = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.BackColor = Color.Transparent;
            lblCountdown.Font = new Font("SF Pro Display", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountdown.ForeColor = Color.White;
            lblCountdown.Location = new Point(12, 9);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(118, 44);
            lblCountdown.TabIndex = 1;
            lblCountdown.Text = "label1";
            lblCountdown.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1413, 88);
            label1.Name = "label1";
            label1.Size = new Size(204, 38);
            label1.TabIndex = 2;
            label1.Text = "Lorem Ipsum";
            // 
            // label2
            // 
            label2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1413, 143);
            label2.Name = "label2";
            label2.Size = new Size(356, 786);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(887, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(480, 600);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1781, 753);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCountdown);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private Label lblCountdown;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}