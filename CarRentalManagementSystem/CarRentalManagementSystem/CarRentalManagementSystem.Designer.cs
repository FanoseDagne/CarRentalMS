namespace CarRentalManagementSystem
{
    partial class CarRentalManagementSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRentalManagementSystem));
            label1 = new Label();
            circularProgressBar1 = new CircularProgressBar_NET5.CircularProgressBar();
            pBoxCar = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labPercentage = new Label();
            ((System.ComponentModel.ISupportInitialize)pBoxCar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(21, 41);
            label1.Name = "label1";
            label1.Size = new Size(458, 34);
            label1.TabIndex = 0;
            label1.Text = "Car Rental Management System";
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.Transparent;
            circularProgressBar1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            circularProgressBar1.ForeColor = Color.FromArgb(64, 64, 64);
            circularProgressBar1.InnerColor = Color.FromArgb(224, 224, 224);
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(109, 78);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.Gray;
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 26;
            circularProgressBar1.ProgressColor = Color.MidnightBlue;
            circularProgressBar1.ProgressWidth = 25;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.Size = new Size(330, 330);
            circularProgressBar1.StartAngle = 0;
            circularProgressBar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = ".23";
            circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "°C";
            circularProgressBar1.TabIndex = 1;
            circularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            // 
            // pBoxCar
            // 
            pBoxCar.Image = (Image)resources.GetObject("pBoxCar.Image");
            pBoxCar.Location = new Point(179, 149);
            pBoxCar.Name = "pBoxCar";
            pBoxCar.Size = new Size(193, 177);
            pBoxCar.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxCar.TabIndex = 2;
            pBoxCar.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // labPercentage
            // 
            labPercentage.AutoSize = true;
            labPercentage.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labPercentage.ForeColor = Color.MidnightBlue;
            labPercentage.Location = new Point(245, 411);
            labPercentage.Name = "labPercentage";
            labPercentage.Size = new Size(53, 34);
            labPercentage.TabIndex = 0;
            labPercentage.Text = "0%";
            // 
            // CarRentalManagementSystem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(507, 459);
            Controls.Add(pBoxCar);
            Controls.Add(circularProgressBar1);
            Controls.Add(labPercentage);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarRentalManagementSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarRentalManagementSystem";
            Load += CarRentalManagementSystem_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CircularProgressBar_NET5.CircularProgressBar circularProgressBar1;
        private PictureBox pBoxCar;
        private System.Windows.Forms.Timer timer1;
        private Label labPercentage;
    }
}