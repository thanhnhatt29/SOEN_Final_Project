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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancel_Button = new MaterialSkin.Controls.MaterialButton();
            this.update_Button = new MaterialSkin.Controls.MaterialButton();
            this.remove_Button = new MaterialSkin.Controls.MaterialButton();
            this.add_Button = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.empImg = new System.Windows.Forms.PictureBox();
            this.empBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empID_Box = new System.Windows.Forms.TextBox();
            this.empFemale = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empPos_Box = new System.Windows.Forms.TextBox();
            this.empPhone_Box = new System.Windows.Forms.TextBox();
            this.empName_Box = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.empData = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchName_Box = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empImg)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 499);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 228);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.groupBox2.Controls.Add(this.cancel_Button);
            this.groupBox2.Controls.Add(this.update_Button);
            this.groupBox2.Controls.Add(this.remove_Button);
            this.groupBox2.Controls.Add(this.add_Button);
            this.groupBox2.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(696, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(359, 198);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành Động";
            // 
            // cancel_Button
            // 
            this.cancel_Button.AutoSize = false;
            this.cancel_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancel_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancel_Button.Depth = 0;
            this.cancel_Button.HighEmphasis = true;
            this.cancel_Button.Icon = null;
            this.cancel_Button.Location = new System.Drawing.Point(196, 36);
            this.cancel_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cancel_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancel_Button.Size = new System.Drawing.Size(137, 44);
            this.cancel_Button.TabIndex = 40;
            this.cancel_Button.Text = "làm mới";
            this.cancel_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancel_Button.UseAccentColor = false;
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.AutoSize = false;
            this.update_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.update_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.update_Button.Depth = 0;
            this.update_Button.HighEmphasis = true;
            this.update_Button.Icon = null;
            this.update_Button.Location = new System.Drawing.Point(196, 106);
            this.update_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.update_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.update_Button.Name = "update_Button";
            this.update_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.update_Button.Size = new System.Drawing.Size(137, 44);
            this.update_Button.TabIndex = 39;
            this.update_Button.Text = "Sửa";
            this.update_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.update_Button.UseAccentColor = false;
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // remove_Button
            // 
            this.remove_Button.AutoSize = false;
            this.remove_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.remove_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.remove_Button.Depth = 0;
            this.remove_Button.HighEmphasis = true;
            this.remove_Button.Icon = null;
            this.remove_Button.Location = new System.Drawing.Point(27, 106);
            this.remove_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.remove_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.remove_Button.Size = new System.Drawing.Size(137, 44);
            this.remove_Button.TabIndex = 38;
            this.remove_Button.Text = "Xoá";
            this.remove_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.remove_Button.UseAccentColor = false;
            this.remove_Button.UseVisualStyleBackColor = true;
            this.remove_Button.Click += new System.EventHandler(this.remove_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.AutoSize = false;
            this.add_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.add_Button.Depth = 0;
            this.add_Button.HighEmphasis = true;
            this.add_Button.Icon = null;
            this.add_Button.Location = new System.Drawing.Point(27, 36);
            this.add_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.add_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_Button.Name = "add_Button";
            this.add_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.add_Button.Size = new System.Drawing.Size(137, 44);
            this.add_Button.TabIndex = 37;
            this.add_Button.Text = "Thêm";
            this.add_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.add_Button.UseAccentColor = false;
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(161)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.empImg);
            this.groupBox1.Controls.Add(this.empBirth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.empID_Box);
            this.groupBox1.Controls.Add(this.empFemale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.empPos_Box);
            this.groupBox1.Controls.Add(this.empPhone_Box);
            this.groupBox1.Controls.Add(this.empName_Box);
            this.groupBox1.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(668, 198);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(608, -22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 30);
            this.label8.TabIndex = 36;
            this.label8.Text = "Ảnh";
            // 
            // empImg
            // 
            this.empImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empImg.Location = new System.Drawing.Point(529, 16);
            this.empImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empImg.Name = "empImg";
            this.empImg.Size = new System.Drawing.Size(129, 176);
            this.empImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empImg.TabIndex = 35;
            this.empImg.TabStop = false;
            this.empImg.Click += new System.EventHandler(this.empImg_Click);
            // 
            // empBirth
            // 
            this.empBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empBirth.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBirth.Location = new System.Drawing.Point(372, 71);
            this.empBirth.Margin = new System.Windows.Forms.Padding(1);
            this.empBirth.Name = "empBirth";
            this.empBirth.Size = new System.Drawing.Size(128, 32);
            this.empBirth.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 30);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mã nhân viên";
            // 
            // empID_Box
            // 
            this.empID_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empID_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empID_Box.Enabled = false;
            this.empID_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID_Box.Location = new System.Drawing.Point(11, 71);
            this.empID_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empID_Box.Name = "empID_Box";
            this.empID_Box.Size = new System.Drawing.Size(155, 32);
            this.empID_Box.TabIndex = 26;
            // 
            // empFemale
            // 
            this.empFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empFemale.AutoSize = true;
            this.empFemale.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empFemale.Location = new System.Drawing.Point(372, 154);
            this.empFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empFemale.Name = "empFemale";
            this.empFemale.Size = new System.Drawing.Size(61, 34);
            this.empFemale.TabIndex = 25;
            this.empFemale.Text = "Nữ";
            this.empFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "Công việc";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên nhân viên";
            // 
            // empPos_Box
            // 
            this.empPos_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empPos_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empPos_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPos_Box.Location = new System.Drawing.Point(184, 151);
            this.empPos_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empPos_Box.Name = "empPos_Box";
            this.empPos_Box.Size = new System.Drawing.Size(156, 32);
            this.empPos_Box.TabIndex = 21;
            // 
            // empPhone_Box
            // 
            this.empPhone_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empPhone_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empPhone_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPhone_Box.Location = new System.Drawing.Point(184, 71);
            this.empPhone_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empPhone_Box.Name = "empPhone_Box";
            this.empPhone_Box.Size = new System.Drawing.Size(155, 32);
            this.empPhone_Box.TabIndex = 19;
            // 
            // empName_Box
            // 
            this.empName_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empName_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName_Box.Location = new System.Drawing.Point(11, 151);
            this.empName_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empName_Box.Name = "empName_Box";
            this.empName_Box.Size = new System.Drawing.Size(155, 32);
            this.empName_Box.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.empData);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.searchName_Box);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 499);
            this.panel4.TabIndex = 3;
            // 
            // empData
            // 
            this.empData.AllowUserToAddRows = false;
            this.empData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.empData.ColumnHeadersHeight = 29;
            this.empData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.empData.Location = new System.Drawing.Point(15, 80);
            this.empData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empData.Name = "empData";
            this.empData.RowHeadersWidth = 51;
            this.empData.RowTemplate.Height = 70;
            this.empData.Size = new System.Drawing.Size(1044, 394);
            this.empData.TabIndex = 16;
            this.empData.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.empData_ColumnHeaderMouseClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::UI.Properties.Resources.search45;
            this.label5.Location = new System.Drawing.Point(988, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 59);
            this.label5.TabIndex = 20;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("#LQC01 Quicksand", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 41);
            this.label6.TabIndex = 26;
            this.label6.Text = "Danh sách nhân viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // searchName_Box
            // 
            this.searchName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchName_Box.AnimateReadOnly = false;
            this.searchName_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchName_Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchName_Box.Depth = 0;
            this.searchName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchName_Box.HideSelection = true;
            this.searchName_Box.LeadingIcon = null;
            this.searchName_Box.Location = new System.Drawing.Point(601, 15);
            this.searchName_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchName_Box.MaxLength = 32767;
            this.searchName_Box.MouseState = MaterialSkin.MouseState.OUT;
            this.searchName_Box.Name = "searchName_Box";
            this.searchName_Box.PasswordChar = '\0';
            this.searchName_Box.PrefixSuffixText = null;
            this.searchName_Box.ReadOnly = false;
            this.searchName_Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchName_Box.SelectedText = "";
            this.searchName_Box.SelectionLength = 0;
            this.searchName_Box.SelectionStart = 0;
            this.searchName_Box.ShortcutsEnabled = true;
            this.searchName_Box.Size = new System.Drawing.Size(380, 48);
            this.searchName_Box.TabIndex = 27;
            this.searchName_Box.TabStop = false;
            this.searchName_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchName_Box.TrailingIcon = null;
            this.searchName_Box.UseSystemPasswordChar = false;
            this.searchName_Box.TextChanged += new System.EventHandler(this.searchName_Box_TextChanged);
            // 
            // EmployeeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 727);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeManage";
            this.Text = "EmployeeManage";
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empPos_Box;
        private System.Windows.Forms.TextBox empPhone_Box;
        private System.Windows.Forms.TextBox empName_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker empBirth;
        private System.Windows.Forms.PictureBox empImg;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialButton cancel_Button;
        private MaterialSkin.Controls.MaterialButton update_Button;
        private MaterialSkin.Controls.MaterialButton remove_Button;
        private MaterialSkin.Controls.MaterialButton add_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox2 searchName_Box;
        private System.Windows.Forms.DataGridView empData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}