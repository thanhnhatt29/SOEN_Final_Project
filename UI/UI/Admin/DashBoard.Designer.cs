namespace UI
{
    partial class DashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.selling_button = new System.Windows.Forms.Button();
            this.revenue_button = new System.Windows.Forms.Button();
            this.account_button = new System.Windows.Forms.Button();
            this.employee_button = new System.Windows.Forms.Button();
            this.product_button = new System.Windows.Forms.Button();
            this.voucher_button = new System.Windows.Forms.Button();
            this.order_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_greet = new System.Windows.Forms.Label();
            this.pn_nameForm = new System.Windows.Forms.Panel();
            this.lb_nameForm = new System.Windows.Forms.Label();
            this.dashboard_panel = new System.Windows.Forms.Panel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_nameForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.logout_button);
            this.panel1.Controls.Add(this.selling_button);
            this.panel1.Controls.Add(this.revenue_button);
            this.panel1.Controls.Add(this.account_button);
            this.panel1.Controls.Add(this.employee_button);
            this.panel1.Controls.Add(this.product_button);
            this.panel1.Controls.Add(this.voucher_button);
            this.panel1.Controls.Add(this.order_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 711);
            this.panel1.TabIndex = 12;
            // 
            // logout_button
            // 
            this.logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logout_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.SystemColors.Control;
            this.logout_button.Location = new System.Drawing.Point(0, 670);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(158, 41);
            this.logout_button.TabIndex = 9;
            this.logout_button.Text = "👈 Đăng xuất";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // selling_button
            // 
            this.selling_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selling_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.selling_button.FlatAppearance.BorderSize = 0;
            this.selling_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selling_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selling_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.selling_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selling_button.Location = new System.Drawing.Point(0, 399);
            this.selling_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selling_button.Name = "selling_button";
            this.selling_button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.selling_button.Size = new System.Drawing.Size(158, 53);
            this.selling_button.TabIndex = 7;
            this.selling_button.Text = "📜 Lịch sử";
            this.selling_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selling_button.UseVisualStyleBackColor = true;
            this.selling_button.Click += new System.EventHandler(this.selling_button_Click);
            // 
            // revenue_button
            // 
            this.revenue_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.revenue_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.revenue_button.FlatAppearance.BorderSize = 0;
            this.revenue_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revenue_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenue_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.revenue_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revenue_button.Location = new System.Drawing.Point(0, 346);
            this.revenue_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.revenue_button.Name = "revenue_button";
            this.revenue_button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.revenue_button.Size = new System.Drawing.Size(158, 53);
            this.revenue_button.TabIndex = 6;
            this.revenue_button.Text = "💵 Doanh thu";
            this.revenue_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revenue_button.UseVisualStyleBackColor = true;
            this.revenue_button.Click += new System.EventHandler(this.revenue_button_Click);
            // 
            // account_button
            // 
            this.account_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.account_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.account_button.FlatAppearance.BorderSize = 0;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.account_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account_button.Location = new System.Drawing.Point(0, 293);
            this.account_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.account_button.Name = "account_button";
            this.account_button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.account_button.Size = new System.Drawing.Size(158, 53);
            this.account_button.TabIndex = 5;
            this.account_button.Text = "👤 Tài khoản";
            this.account_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account_button.UseVisualStyleBackColor = true;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            // 
            // employee_button
            // 
            this.employee_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employee_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.employee_button.FlatAppearance.BorderSize = 0;
            this.employee_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.employee_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee_button.Location = new System.Drawing.Point(0, 240);
            this.employee_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employee_button.Name = "employee_button";
            this.employee_button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.employee_button.Size = new System.Drawing.Size(158, 53);
            this.employee_button.TabIndex = 4;
            this.employee_button.Text = "👩‍🍳 Nhân viên";
            this.employee_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee_button.UseVisualStyleBackColor = true;
            this.employee_button.Click += new System.EventHandler(this.employee_button_Click);
            // 
            // product_button
            // 
            this.product_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.product_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_button.FlatAppearance.BorderSize = 0;
            this.product_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.product_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.product_button.Location = new System.Drawing.Point(0, 187);
            this.product_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product_button.Name = "product_button";
            this.product_button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.product_button.Size = new System.Drawing.Size(158, 53);
            this.product_button.TabIndex = 3;
            this.product_button.Text = "🍔 Sản phẩm";
            this.product_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.product_button.UseVisualStyleBackColor = true;
            this.product_button.Click += new System.EventHandler(this.product_button_Click);
            // 
            // voucher_button
            // 
            this.voucher_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.voucher_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.voucher_button.FlatAppearance.BorderSize = 0;
            this.voucher_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voucher_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucher_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.voucher_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voucher_button.Location = new System.Drawing.Point(0, 134);
            this.voucher_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voucher_button.Name = "voucher_button";
            this.voucher_button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.voucher_button.Size = new System.Drawing.Size(158, 53);
            this.voucher_button.TabIndex = 2;
            this.voucher_button.Text = "🎫 Mã giảm giá";
            this.voucher_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voucher_button.UseVisualStyleBackColor = true;
            this.voucher_button.Click += new System.EventHandler(this.voucher_button_Click);
            // 
            // order_button
            // 
            this.order_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.order_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.order_button.FlatAppearance.BorderSize = 0;
            this.order_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.order_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order_button.Location = new System.Drawing.Point(0, 81);
            this.order_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.order_button.Name = "order_button";
            this.order_button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.order_button.Size = new System.Drawing.Size(158, 53);
            this.order_button.TabIndex = 1;
            this.order_button.Text = "🛒 Đơn hàng";
            this.order_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.materialButton1);
            this.panel2.Controls.Add(this.lb_greet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 81);
            this.panel2.TabIndex = 0;
            // 
            // lb_greet
            // 
            this.lb_greet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_greet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_greet.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_greet.Location = new System.Drawing.Point(0, 0);
            this.lb_greet.Name = "lb_greet";
            this.lb_greet.Size = new System.Drawing.Size(158, 56);
            this.lb_greet.TabIndex = 0;
            this.lb_greet.Text = "label1";
            this.lb_greet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_nameForm
            // 
            this.pn_nameForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pn_nameForm.Controls.Add(this.lb_nameForm);
            this.pn_nameForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_nameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_nameForm.ForeColor = System.Drawing.SystemColors.Control;
            this.pn_nameForm.Location = new System.Drawing.Point(158, 0);
            this.pn_nameForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_nameForm.Name = "pn_nameForm";
            this.pn_nameForm.Size = new System.Drawing.Size(826, 81);
            this.pn_nameForm.TabIndex = 13;
            // 
            // lb_nameForm
            // 
            this.lb_nameForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_nameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameForm.Location = new System.Drawing.Point(0, 0);
            this.lb_nameForm.Name = "lb_nameForm";
            this.lb_nameForm.Size = new System.Drawing.Size(826, 81);
            this.lb_nameForm.TabIndex = 0;
            this.lb_nameForm.Text = "label1";
            this.lb_nameForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashboard_panel
            // 
            this.dashboard_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_panel.Location = new System.Drawing.Point(158, 81);
            this.dashboard_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboard_panel.Name = "dashboard_panel";
            this.dashboard_panel.Size = new System.Drawing.Size(826, 630);
            this.dashboard_panel.TabIndex = 14;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(23, 45);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(116, 28);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Đổi mật khẩu";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.dashboard_panel);
            this.Controls.Add(this.pn_nameForm);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash Board";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoard_FormClosed);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pn_nameForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button account_button;
        private System.Windows.Forms.Button employee_button;
        private System.Windows.Forms.Button product_button;
        private System.Windows.Forms.Button voucher_button;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_nameForm;
        private System.Windows.Forms.Panel dashboard_panel;
        private System.Windows.Forms.Button selling_button;
        private System.Windows.Forms.Button revenue_button;
        private System.Windows.Forms.Label lb_nameForm;
        private System.Windows.Forms.Label lb_greet;
        private System.Windows.Forms.Button logout_button;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

