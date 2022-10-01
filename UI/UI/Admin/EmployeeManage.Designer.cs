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
            this.panel3.Location = new System.Drawing.Point(478, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 611);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Picture";
            // 
            // empImg
            // 
            this.empImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empImg.Location = new System.Drawing.Point(319, 94);
            this.empImg.Name = "empImg";
            this.empImg.Size = new System.Drawing.Size(160, 175);
            this.empImg.TabIndex = 35;
            this.empImg.TabStop = false;
            // 
            // empBirth
            // 
            this.empBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empBirth.Location = new System.Drawing.Point(291, 319);
            this.empBirth.Margin = new System.Windows.Forms.Padding(1);
            this.empBirth.Name = "empBirth";
            this.empBirth.Size = new System.Drawing.Size(188, 22);
            this.empBirth.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Employee ID";
            // 
            // empID_Box
            // 
            this.empID_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empID_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empID_Box.Enabled = false;
            this.empID_Box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID_Box.Location = new System.Drawing.Point(56, 91);
            this.empID_Box.Name = "empID_Box";
            this.empID_Box.Size = new System.Drawing.Size(216, 32);
            this.empID_Box.TabIndex = 26;
            // 
            // empFemale
            // 
            this.empFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empFemale.AutoSize = true;
            this.empFemale.Location = new System.Drawing.Point(56, 199);
            this.empFemale.Name = "empFemale";
            this.empFemale.Size = new System.Drawing.Size(75, 20);
            this.empFemale.TabIndex = 25;
            this.empFemale.Text = "Female";
            this.empFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Position";
            // 
            // remove_Button
            // 
            this.remove_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.remove_Button.Location = new System.Drawing.Point(56, 468);
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.Size = new System.Drawing.Size(175, 72);
            this.remove_Button.TabIndex = 30;
            this.remove_Button.Text = "REMOVE";
            this.remove_Button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Phone Number";
            // 
            // add_Button
            // 
            this.add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.add_Button.Location = new System.Drawing.Point(56, 385);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(175, 72);
            this.add_Button.TabIndex = 27;
            this.add_Button.Text = "ADD";
            this.add_Button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Employee Name";
            // 
            // cancel_Button
            // 
            this.cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_Button.Location = new System.Drawing.Point(304, 468);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(175, 72);
            this.cancel_Button.TabIndex = 28;
            this.cancel_Button.Text = "CANCEL";
            this.cancel_Button.UseVisualStyleBackColor = false;
            // 
            // update_Button
            // 
            this.update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.update_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.update_Button.Location = new System.Drawing.Point(304, 385);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(175, 72);
            this.update_Button.TabIndex = 29;
            this.update_Button.Text = "UPDATE";
            this.update_Button.UseVisualStyleBackColor = false;
            // 
            // empPos_Box
            // 
            this.empPos_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empPos_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empPos_Box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPos_Box.Location = new System.Drawing.Point(56, 309);
            this.empPos_Box.Name = "empPos_Box";
            this.empPos_Box.Size = new System.Drawing.Size(216, 32);
            this.empPos_Box.TabIndex = 21;
            // 
            // empPhone_Box
            // 
            this.empPhone_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empPhone_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empPhone_Box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPhone_Box.Location = new System.Drawing.Point(56, 252);
            this.empPhone_Box.Name = "empPhone_Box";
            this.empPhone_Box.Size = new System.Drawing.Size(216, 32);
            this.empPhone_Box.TabIndex = 19;
            // 
            // empName_Box
            // 
            this.empName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empName_Box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName_Box.Location = new System.Drawing.Point(56, 148);
            this.empName_Box.Name = "empName_Box";
            this.empName_Box.Size = new System.Drawing.Size(216, 32);
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
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(478, 611);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Employee list";
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
            this.empData.Location = new System.Drawing.Point(11, 49);
            this.empData.Name = "empData";
            this.empData.RowHeadersWidth = 51;
            this.empData.RowTemplate.Height = 70;
            this.empData.Size = new System.Drawing.Size(440, 432);
            this.empData.TabIndex = 16;
            // 
            // searchName_Box
            // 
            this.searchName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchName_Box.Location = new System.Drawing.Point(11, 536);
            this.searchName_Box.Name = "searchName_Box";
            this.searchName_Box.Size = new System.Drawing.Size(440, 22);
            this.searchName_Box.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Search by Name";
            // 
            // EmployeeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 611);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
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