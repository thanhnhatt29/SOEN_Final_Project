namespace UI.Employee
{
    partial class ChangePassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.newPW_lb = new System.Windows.Forms.Label();
            this.submit_bt = new System.Windows.Forms.Button();
            this.retype_tb = new System.Windows.Forms.TextBox();
            this.passw_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentPW_tb = new System.Windows.Forms.TextBox();
            this.showPassw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // newPW_lb
            // 
            this.newPW_lb.AutoSize = true;
            this.newPW_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPW_lb.Location = new System.Drawing.Point(23, 154);
            this.newPW_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newPW_lb.Name = "newPW_lb";
            this.newPW_lb.Size = new System.Drawing.Size(75, 20);
            this.newPW_lb.TabIndex = 18;
            this.newPW_lb.Text = "Mật khẩu";
            // 
            // submit_bt
            // 
            this.submit_bt.BackColor = System.Drawing.SystemColors.Highlight;
            this.submit_bt.FlatAppearance.BorderSize = 0;
            this.submit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_bt.Font = new System.Drawing.Font("#LQC02 AllRoundGothic Demi", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_bt.ForeColor = System.Drawing.Color.White;
            this.submit_bt.Location = new System.Drawing.Point(23, 315);
            this.submit_bt.Margin = new System.Windows.Forms.Padding(2);
            this.submit_bt.Name = "submit_bt";
            this.submit_bt.Size = new System.Drawing.Size(264, 39);
            this.submit_bt.TabIndex = 15;
            this.submit_bt.Text = "Xác nhận";
            this.submit_bt.UseVisualStyleBackColor = false;
            this.submit_bt.Click += new System.EventHandler(this.submit_bt_Click);
            // 
            // retype_tb
            // 
            this.retype_tb.BackColor = System.Drawing.Color.Gainsboro;
            this.retype_tb.Font = new System.Drawing.Font("#LQC01 Quicksand Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retype_tb.Location = new System.Drawing.Point(23, 234);
            this.retype_tb.Margin = new System.Windows.Forms.Padding(2);
            this.retype_tb.Name = "retype_tb";
            this.retype_tb.Size = new System.Drawing.Size(265, 31);
            this.retype_tb.TabIndex = 3;
            // 
            // passw_tb
            // 
            this.passw_tb.BackColor = System.Drawing.Color.Gainsboro;
            this.passw_tb.Font = new System.Drawing.Font("#LQC01 Quicksand Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passw_tb.Location = new System.Drawing.Point(23, 173);
            this.passw_tb.Margin = new System.Windows.Forms.Padding(2);
            this.passw_tb.Name = "passw_tb";
            this.passw_tb.Size = new System.Drawing.Size(265, 31);
            this.passw_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("#LQC02 AllRoundGothic Demi", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "Đổi mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // currentPW_tb
            // 
            this.currentPW_tb.BackColor = System.Drawing.Color.Gainsboro;
            this.currentPW_tb.Font = new System.Drawing.Font("#LQC01 Quicksand Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPW_tb.Location = new System.Drawing.Point(23, 108);
            this.currentPW_tb.Margin = new System.Windows.Forms.Padding(2);
            this.currentPW_tb.Name = "currentPW_tb";
            this.currentPW_tb.Size = new System.Drawing.Size(265, 31);
            this.currentPW_tb.TabIndex = 1;
            // 
            // showPassw
            // 
            this.showPassw.AutoSize = true;
            this.showPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassw.ForeColor = System.Drawing.Color.DimGray;
            this.showPassw.Location = new System.Drawing.Point(146, 279);
            this.showPassw.Margin = new System.Windows.Forms.Padding(2);
            this.showPassw.Name = "showPassw";
            this.showPassw.Size = new System.Drawing.Size(141, 22);
            this.showPassw.TabIndex = 22;
            this.showPassw.Text = "Hiển thị mật khẩu";
            this.showPassw.UseVisualStyleBackColor = true;
            this.showPassw.CheckedChanged += new System.EventHandler(this.showPassw_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.submit_bt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 372);
            this.Controls.Add(this.showPassw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPW_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPW_lb);
            this.Controls.Add(this.submit_bt);
            this.Controls.Add(this.retype_tb);
            this.Controls.Add(this.passw_tb);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label newPW_lb;
        private System.Windows.Forms.Button submit_bt;
        private System.Windows.Forms.TextBox retype_tb;
        private System.Windows.Forms.TextBox passw_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentPW_tb;
        private System.Windows.Forms.CheckBox showPassw;
    }
}