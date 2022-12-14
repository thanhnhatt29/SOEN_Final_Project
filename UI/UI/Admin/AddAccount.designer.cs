namespace UI.Admin
{
    partial class AddAccount
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
            this.emp_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passw_Box = new System.Windows.Forms.TextBox();
            this.passw_reBox = new System.Windows.Forms.TextBox();
            this.accregister_Button = new System.Windows.Forms.Button();
            this.adminCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emp_Box
            // 
            this.emp_Box.BackColor = System.Drawing.Color.Gainsboro;
            this.emp_Box.Font = new System.Drawing.Font("#LQC01 Quicksand Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_Box.Location = new System.Drawing.Point(41, 116);
            this.emp_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_Box.Name = "emp_Box";
            this.emp_Box.Size = new System.Drawing.Size(352, 37);
            this.emp_Box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("#LQC02 AllRoundGothic Demi", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạo Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passw_Box
            // 
            this.passw_Box.BackColor = System.Drawing.Color.Gainsboro;
            this.passw_Box.Font = new System.Drawing.Font("#LQC01 Quicksand Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passw_Box.Location = new System.Drawing.Point(41, 183);
            this.passw_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passw_Box.Name = "passw_Box";
            this.passw_Box.Size = new System.Drawing.Size(352, 37);
            this.passw_Box.TabIndex = 2;
            // 
            // passw_reBox
            // 
            this.passw_reBox.BackColor = System.Drawing.Color.Gainsboro;
            this.passw_reBox.Font = new System.Drawing.Font("#LQC01 Quicksand Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passw_reBox.Location = new System.Drawing.Point(41, 259);
            this.passw_reBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passw_reBox.Name = "passw_reBox";
            this.passw_reBox.Size = new System.Drawing.Size(352, 37);
            this.passw_reBox.TabIndex = 3;
            // 
            // accregister_Button
            // 
            this.accregister_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.accregister_Button.FlatAppearance.BorderSize = 0;
            this.accregister_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accregister_Button.Font = new System.Drawing.Font("#LQC02 AllRoundGothic Demi", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accregister_Button.ForeColor = System.Drawing.Color.White;
            this.accregister_Button.Location = new System.Drawing.Point(41, 362);
            this.accregister_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accregister_Button.Name = "accregister_Button";
            this.accregister_Button.Size = new System.Drawing.Size(352, 48);
            this.accregister_Button.TabIndex = 5;
            this.accregister_Button.Text = "Đăng Kí";
            this.accregister_Button.UseVisualStyleBackColor = false;
            this.accregister_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminCheck
            // 
            this.adminCheck.AutoSize = true;
            this.adminCheck.Font = new System.Drawing.Font("#LQC01 Quicksand Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCheck.Location = new System.Drawing.Point(204, 300);
            this.adminCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminCheck.Name = "adminCheck";
            this.adminCheck.Size = new System.Drawing.Size(179, 38);
            this.adminCheck.TabIndex = 7;
            this.adminCheck.Text = "Administrator";
            this.adminCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(443, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminCheck);
            this.Controls.Add(this.accregister_Button);
            this.Controls.Add(this.passw_reBox);
            this.Controls.Add(this.passw_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emp_Box);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emp_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passw_Box;
        private System.Windows.Forms.TextBox passw_reBox;
        private System.Windows.Forms.Button accregister_Button;
        private System.Windows.Forms.CheckBox adminCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}