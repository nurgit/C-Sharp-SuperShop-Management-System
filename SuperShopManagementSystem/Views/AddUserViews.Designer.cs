﻿namespace SuperShopManagementSystem.Views
{
    partial class AddUserViews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserViews));
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelCatagory = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPasseord = new System.Windows.Forms.Label();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAddUsers = new System.Windows.Forms.DataGridView();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.White;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.Black;
            this.labelId.Location = new System.Drawing.Point(79, 201);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 24);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(52, 274);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name :";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.White;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Black;
            this.labelUserName.Location = new System.Drawing.Point(7, 238);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(105, 20);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "User NAme:";
            // 
            // labelCatagory
            // 
            this.labelCatagory.AutoSize = true;
            this.labelCatagory.BackColor = System.Drawing.Color.White;
            this.labelCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatagory.ForeColor = System.Drawing.Color.Black;
            this.labelCatagory.Location = new System.Drawing.Point(12, 318);
            this.labelCatagory.Name = "labelCatagory";
            this.labelCatagory.Size = new System.Drawing.Size(100, 20);
            this.labelCatagory.TabIndex = 3;
            this.labelCatagory.Text = "User Type :";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(128, 199);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(319, 26);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(127, 274);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(319, 26);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(128, 238);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(319, 26);
            this.textBoxUsername.TabIndex = 7;
            // 
            // labelPasseord
            // 
            this.labelPasseord.AutoSize = true;
            this.labelPasseord.BackColor = System.Drawing.Color.White;
            this.labelPasseord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasseord.ForeColor = System.Drawing.Color.Black;
            this.labelPasseord.Location = new System.Drawing.Point(26, 352);
            this.labelPasseord.Name = "labelPasseord";
            this.labelPasseord.Size = new System.Drawing.Size(96, 20);
            this.labelPasseord.TabIndex = 8;
            this.labelPasseord.Text = "Password :";
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Location = new System.Drawing.Point(128, 315);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(313, 28);
            this.comboBoxUserType.TabIndex = 10;
            this.comboBoxUserType.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserType_SelectedIndexChanged);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.Location = new System.Drawing.Point(303, 400);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(143, 33);
            this.buttonAddUser.TabIndex = 11;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(16, 22);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(141, 41);
            this.buttonHome.TabIndex = 23;
            this.buttonHome.Text = "Back";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            this.buttonHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonHome_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(357, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Manager Dashboard ";
            // 
            // dataGridViewAddUsers
            // 
            this.dataGridViewAddUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAddUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddUsers.Location = new System.Drawing.Point(517, 201);
            this.dataGridViewAddUsers.Name = "dataGridViewAddUsers";
            this.dataGridViewAddUsers.Size = new System.Drawing.Size(536, 245);
            this.dataGridViewAddUsers.TabIndex = 25;
            this.dataGridViewAddUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pro);
            this.dataGridViewAddUsers.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.RowChanged);
            this.dataGridViewAddUsers.SelectionChanged += new System.EventHandler(this.dataGridViewAllUser_SelectionChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(127, 352);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(319, 26);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.BackColor = System.Drawing.Color.Yellow;
            this.labelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAddProduct.Location = new System.Drawing.Point(258, 153);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(84, 20);
            this.labelAddProduct.TabIndex = 43;
            this.labelAddProduct.Text = "Add User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(741, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "All Users";
            // 
            // AddUserViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1081, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAddProduct);
            this.Controls.Add(this.dataGridViewAddUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.comboBoxUserType);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPasseord);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelCatagory);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserViews";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelCatagory;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPasseord;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAddUsers;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Label label1;
    }
}