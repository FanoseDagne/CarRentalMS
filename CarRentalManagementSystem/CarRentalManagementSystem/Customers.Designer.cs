namespace CarRentalManagementSystem
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            txtCustName = new TextBox();
            labReg = new Label();
            pBoxCar = new PictureBox();
            pictureBox1 = new PictureBox();
            labCarRental = new Label();
            labUser = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            labCarList = new Label();
            labModel = new Label();
            labPrice = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pBoxCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // txtCustName
            // 
            txtCustName.BackColor = Color.White;
            txtCustName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustName.ForeColor = Color.Crimson;
            txtCustName.Location = new Point(59, 194);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(372, 37);
            txtCustName.TabIndex = 16;
            // 
            // labReg
            // 
            labReg.AutoSize = true;
            labReg.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labReg.ForeColor = Color.Crimson;
            labReg.Location = new Point(59, 144);
            labReg.Name = "labReg";
            labReg.Size = new Size(238, 34);
            labReg.TabIndex = 12;
            labReg.Text = "Customer Name";
            // 
            // pBoxCar
            // 
            pBoxCar.Image = (Image)resources.GetObject("pBoxCar.Image");
            pBoxCar.Location = new Point(0, 0);
            pBoxCar.Name = "pBoxCar";
            pBoxCar.Size = new Size(85, 53);
            pBoxCar.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxCar.TabIndex = 1;
            pBoxCar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1098, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labCarRental
            // 
            labCarRental.AutoSize = true;
            labCarRental.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labCarRental.ForeColor = Color.MidnightBlue;
            labCarRental.Location = new Point(91, 9);
            labCarRental.Name = "labCarRental";
            labCarRental.Size = new Size(458, 34);
            labCarRental.TabIndex = 1;
            labCarRental.Text = "Car Rental Management System";
            // 
            // labUser
            // 
            labUser.AutoSize = true;
            labUser.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labUser.ForeColor = Color.Crimson;
            labUser.Location = new Point(1167, 9);
            labUser.Name = "labUser";
            labUser.Size = new Size(85, 39);
            labUser.TabIndex = 1;
            labUser.Text = "Staff";
            // 
            // panel2
            // 
            panel2.Location = new Point(36, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 51);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(1291, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 34);
            label5.TabIndex = 28;
            label5.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(1258, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 34);
            label6.TabIndex = 29;
            label6.Text = "-";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labUser);
            panel1.Controls.Add(labCarRental);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pBoxCar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 53);
            panel1.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.ForeColor = Color.Crimson;
            txtPhone.Location = new Point(1046, 194);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(239, 37);
            txtPhone.TabIndex = 15;
            txtPhone.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.Crimson;
            txtAddress.Location = new Point(545, 194);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(403, 37);
            txtAddress.TabIndex = 13;
            // 
            // labCarList
            // 
            labCarList.AutoSize = true;
            labCarList.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labCarList.ForeColor = Color.Crimson;
            labCarList.Location = new Point(530, 317);
            labCarList.Name = "labCarList";
            labCarList.Size = new Size(262, 43);
            labCarList.TabIndex = 11;
            labCarList.Text = "Customers List";
            // 
            // labModel
            // 
            labModel.AutoSize = true;
            labModel.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labModel.ForeColor = Color.Crimson;
            labModel.Location = new Point(1046, 144);
            labModel.Name = "labModel";
            labModel.Size = new Size(102, 34);
            labModel.TabIndex = 9;
            labModel.Text = "Phone";
            // 
            // labPrice
            // 
            labPrice.AutoSize = true;
            labPrice.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labPrice.ForeColor = Color.Crimson;
            labPrice.Location = new Point(545, 144);
            labPrice.Name = "labPrice";
            labPrice.Size = new Size(122, 34);
            labPrice.TabIndex = 7;
            labPrice.Text = "Address";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(101, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(421, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(803, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1103, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(150, 3);
            label1.Name = "label1";
            label1.Size = new Size(76, 34);
            label1.TabIndex = 1;
            label1.Text = "Cars";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(468, 6);
            label2.Name = "label2";
            label2.Size = new Size(157, 34);
            label2.TabIndex = 1;
            label2.Text = "Customers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(852, 9);
            label3.Name = "label3";
            label3.Size = new Size(74, 34);
            label3.TabIndex = 1;
            label3.Text = "Rent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(1152, 6);
            label4.Name = "label4";
            label4.Size = new Size(100, 34);
            label4.TabIndex = 1;
            label4.Text = "Return";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkBlue;
            panel5.Location = new Point(421, 43);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 5);
            panel5.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(1323, 72);
            panel3.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(421, 271);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 43);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Navy;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(564, 271);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 43);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Navy;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(696, 271);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 43);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Navy;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(852, 271);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 43);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvCustomer
            // 
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(36, 375);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.RowTemplate.Height = 33;
            dgvCustomer.Size = new Size(1275, 442);
            dgvCustomer.TabIndex = 20;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 841);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomer);
            Controls.Add(panel3);
            Controls.Add(labPrice);
            Controls.Add(labModel);
            Controls.Add(labCarList);
            Controls.Add(labReg);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtCustName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustName;
        private Label labReg;
        private PictureBox pBoxCar;
        private PictureBox pictureBox1;
        private Label labCarRental;
        private Label labUser;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label labCarList;
        private Label labModel;
        private Label labPrice;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel5;
        private Panel panel3;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvCustomer;
    }
}