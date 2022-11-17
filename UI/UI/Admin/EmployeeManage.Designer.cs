namespace UI
{
    partial class EmployeeManage
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.empImg = new System.Windows.Forms.PictureBox();
            this.empBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empID_Box = new System.Windows.Forms.TextBox();
            this.empFemale = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.remove_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.add_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.update_Button = new System.Windows.Forms.Button();
            this.empPos_Box = new System.Windows.Forms.TextBox();
            this.empPhone_Box = new System.Windows.Forms.TextBox();
            this.empName_Box = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.empData = new System.Windows.Forms.DataGridView();
            this.searchName_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empImg)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.empImg);
            this.panel3.Controls.Add(this.empBirth);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.empID_Box);
            this.panel3.Controls.Add(this.empFemale);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.remove_Button);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.add_Button);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cancel_Button);
            this.panel3.Controls.Add(this.update_Button);
            this.panel3.Controls.Add(this.empPos_Box);
            this.panel3.Controls.Add(this.empPhone_Box);
            this.panel3.Controls.Add(this.empName_Box);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(418, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 591);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Ảnh";
            // 
            // empImg
            // 
            this.empImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empImg.Location = new System.Drawing.Point(239, 123);
            this.empImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empImg.Name = "empImg";
            this.empImg.Size = new System.Drawing.Size(120, 143);
            this.empImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empImg.TabIndex = 35;
            this.empImg.TabStop = false;
            this.empImg.Click += new System.EventHandler(this.empImg_Click);
            // 
            // empBirth
            // 
            this.empBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empBirth.Location = new System.Drawing.Point(218, 306);
            this.empBirth.Margin = new System.Windows.Forms.Padding(1);
            this.empBirth.Name = "empBirth";
            this.empBirth.Size = new System.Drawing.Size(142, 20);
            this.empBirth.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mã nhân viên";
            // 
            // empID_Box
            // 
            this.empID_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empID_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empID_Box.Enabled = false;
            this.empID_Box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID_Box.Location = new System.Drawing.Point(42, 121);
            this.empID_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empID_Box.Name = "empID_Box";
            this.empID_Box.Size = new System.Drawing.Size(163, 27);
            this.empID_Box.TabIndex = 26;
            // 
            // empFemale
            // 
            this.empFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empFemale.AutoSize = true;
            this.empFemale.Location = new System.Drawing.Point(42, 209);
            this.empFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empFemale.Name = "empFemale";
            this.empFemale.Size = new System.Drawing.Size(40, 17);
            this.empFemale.TabIndex = 25;
            this.empFemale.Text = "Nữ";
            this.empFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Công việc";
            // 
            // remove_Button
            // 
            this.remove_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.remove_Button.Location = new System.Drawing.Point(42, 427);
            this.remove_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.Size = new System.Drawing.Size(131, 58);
            this.remove_Button.TabIndex = 30;
            this.remove_Button.Text = "XÓA";
            this.remove_Button.UseVisualStyleBackColor = false;
            this.remove_Button.Click += new System.EventHandler(this.remove_Button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số điện thoại";
            // 
            // add_Button
            // 
            this.add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.add_Button.Location = new System.Drawing.Point(42, 360);
            this.add_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(131, 58);
            this.add_Button.TabIndex = 27;
            this.add_Button.Text = "THÊM";
            this.add_Button.UseVisualStyleBackColor = false;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên nhân viên";
            // 
            // cancel_Button
            // 
            this.cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_Button.Location = new System.Drawing.Point(228, 427);
            this.cancel_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(131, 58);
            this.cancel_Button.TabIndex = 28;
            this.cancel_Button.Text = "LÀM MỚI";
            this.cancel_Button.UseVisualStyleBackColor = false;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.update_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.update_Button.Location = new System.Drawing.Point(228, 360);
            this.update_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(131, 58);
            this.update_Button.TabIndex = 29;
            this.update_Button.Text = "SỬA";
            this.update_Button.UseVisualStyleBackColor = false;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // empPos_Box
            // 
            this.empPos_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empPos_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empPos_Box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPos_Box.Location = new System.Drawing.Point(42, 298);
            this.empPos_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empPos_Box.Name = "empPos_Box";
            this.empPos_Box.Size = new System.Drawing.Size(163, 27);
            this.empPos_Box.TabIndex = 21;
            // 
            // empPhone_Box
            // 
            this.empPhone_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empPhone_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empPhone_Box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPhone_Box.Location = new System.Drawing.Point(42, 252);
            this.empPhone_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empPhone_Box.Name = "empPhone_Box";
            this.empPhone_Box.Size = new System.Drawing.Size(163, 27);
            this.empPhone_Box.TabIndex = 19;
            // 
            // empName_Box
            // 
            this.empName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empName_Box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName_Box.Location = new System.Drawing.Point(42, 167);
            this.empName_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empName_Box.Name = "empName_Box";
            this.empName_Box.Size = new System.Drawing.Size(163, 27);
            this.empName_Box.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.empData);
            this.panel4.Controls.Add(this.searchName_Box);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 591);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Danh sách nhân viên";
            // 
            // empData
            // 
            this.empData.AllowUserToAddRows = false;
            this.empData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.empData.ColumnHeadersHeight = 29;
            this.empData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.empData.Location = new System.Drawing.Point(8, 40);
            this.empData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empData.Name = "empData";
            this.empData.RowHeadersWidth = 51;
            this.empData.RowTemplate.Height = 70;
            this.empData.Size = new System.Drawing.Size(389, 445);
            this.empData.TabIndex = 16;
            this.empData.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.empData_ColumnHeaderMouseClick);
            // 
            // searchName_Box
            // 
            this.searchName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchName_Box.Location = new System.Drawing.Point(8, 530);
            this.searchName_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchName_Box.Name = "searchName_Box";
            this.searchName_Box.Size = new System.Drawing.Size(390, 20);
            this.searchName_Box.TabIndex = 18;
            this.searchName_Box.TextChanged += new System.EventHandler(this.searchName_Box_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 512);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tìm kiếm theo tên nhân viên";
            // 
            // EmployeeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 591);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeManage";
            this.Text = "EmployeeManage";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empImg)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empID_Box;
        private System.Windows.Forms.CheckBox empFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button remove_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.TextBox empPos_Box;
        private System.Windows.Forms.TextBox empPhone_Box;
        private System.Windows.Forms.TextBox empName_Box;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView empData;
        private System.Windows.Forms.TextBox searchName_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker empBirth;
        private System.Windows.Forms.PictureBox empImg;
        private System.Windows.Forms.Label label8;
    }
}