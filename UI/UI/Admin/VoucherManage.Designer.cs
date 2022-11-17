namespace UI
{
    partial class VoucherManage
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
            this.used_Box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.max_money = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.apply_price = new System.Windows.Forms.Label();
            this.voucher_id = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.GroupBox();
            this.voucherId_Box = new System.Windows.Forms.TextBox();
            this.price_Box = new System.Windows.Forms.TextBox();
            this.money_Box = new System.Windows.Forms.TextBox();
            this.percent_Box = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataVoucher = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancel_Button = new MaterialSkin.Controls.MaterialButton();
            this.update_Button = new MaterialSkin.Controls.MaterialButton();
            this.delete_Button = new MaterialSkin.Controls.MaterialButton();
            this.add_Button = new MaterialSkin.Controls.MaterialButton();
            this.search_Button = new MaterialSkin.Controls.MaterialButton();
            this.Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVoucher)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // used_Box
            // 
            this.used_Box.Cursor = System.Windows.Forms.Cursors.Default;
            this.used_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.used_Box.FormattingEnabled = true;
            this.used_Box.Items.AddRange(new object[] {
            "True",
            "False"});
            this.used_Box.Location = new System.Drawing.Point(207, 134);
            this.used_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.used_Box.Name = "used_Box";
            this.used_Box.Size = new System.Drawing.Size(102, 32);
            this.used_Box.TabIndex = 9;
            this.used_Box.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "used:";
            this.label2.Visible = false;
            // 
            // max_money
            // 
            this.max_money.AutoSize = true;
            this.max_money.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_money.Location = new System.Drawing.Point(265, 93);
            this.max_money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.max_money.Name = "max_money";
            this.max_money.Size = new System.Drawing.Size(98, 24);
            this.max_money.TabIndex = 3;
            this.max_money.Text = "Giảm tối đa:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(230, 47);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(133, 24);
            this.lb.TabIndex = 2;
            this.lb.Text = "Phần trăm giảm:";
            // 
            // apply_price
            // 
            this.apply_price.AutoSize = true;
            this.apply_price.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_price.Location = new System.Drawing.Point(16, 99);
            this.apply_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apply_price.Name = "apply_price";
            this.apply_price.Size = new System.Drawing.Size(105, 24);
            this.apply_price.TabIndex = 1;
            this.apply_price.Text = "Đơn tối thiểu:";
            // 
            // voucher_id
            // 
            this.voucher_id.AutoSize = true;
            this.voucher_id.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucher_id.Location = new System.Drawing.Point(16, 47);
            this.voucher_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.voucher_id.Name = "voucher_id";
            this.voucher_id.Size = new System.Drawing.Size(102, 24);
            this.voucher_id.TabIndex = 0;
            this.voucher_id.Text = "Mã giảm giá";
            // 
            // Information
            // 
            this.Information.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(161)))));
            this.Information.Controls.Add(this.voucherId_Box);
            this.Information.Controls.Add(this.price_Box);
            this.Information.Controls.Add(this.money_Box);
            this.Information.Controls.Add(this.percent_Box);
            this.Information.Controls.Add(this.voucher_id);
            this.Information.Controls.Add(this.used_Box);
            this.Information.Controls.Add(this.label2);
            this.Information.Controls.Add(this.max_money);
            this.Information.Controls.Add(this.lb);
            this.Information.Controls.Add(this.apply_price);
            this.Information.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(9, 409);
            this.Information.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Information.Name = "Information";
            this.Information.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Information.Size = new System.Drawing.Size(493, 172);
            this.Information.TabIndex = 18;
            this.Information.TabStop = false;
            this.Information.Text = "Thông tin";
            // 
            // voucherId_Box
            // 
            this.voucherId_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucherId_Box.Location = new System.Drawing.Point(122, 45);
            this.voucherId_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voucherId_Box.Name = "voucherId_Box";
            this.voucherId_Box.Size = new System.Drawing.Size(104, 27);
            this.voucherId_Box.TabIndex = 13;
            // 
            // price_Box
            // 
            this.price_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_Box.Location = new System.Drawing.Point(122, 99);
            this.price_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.price_Box.Name = "price_Box";
            this.price_Box.Size = new System.Drawing.Size(104, 27);
            this.price_Box.TabIndex = 12;
            // 
            // money_Box
            // 
            this.money_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_Box.Location = new System.Drawing.Point(367, 90);
            this.money_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.money_Box.Name = "money_Box";
            this.money_Box.Size = new System.Drawing.Size(104, 27);
            this.money_Box.TabIndex = 11;
            // 
            // percent_Box
            // 
            this.percent_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent_Box.Location = new System.Drawing.Point(367, 45);
            this.percent_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.percent_Box.Name = "percent_Box";
            this.percent_Box.Size = new System.Drawing.Size(104, 27);
            this.percent_Box.TabIndex = 10;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(539, 11);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(174, 27);
            this.searchBox.TabIndex = 16;
            // 
            // dataVoucher
            // 
            this.dataVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataVoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVoucher.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVoucher.Location = new System.Drawing.Point(9, 42);
            this.dataVoucher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataVoucher.Name = "dataVoucher";
            this.dataVoucher.RowHeadersWidth = 51;
            this.dataVoucher.RowTemplate.Height = 24;
            this.dataVoucher.Size = new System.Drawing.Size(785, 352);
            this.dataVoucher.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.groupBox2.Controls.Add(this.cancel_Button);
            this.groupBox2.Controls.Add(this.update_Button);
            this.groupBox2.Controls.Add(this.delete_Button);
            this.groupBox2.Controls.Add(this.add_Button);
            this.groupBox2.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(518, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 170);
            this.groupBox2.TabIndex = 43;
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
            this.cancel_Button.Location = new System.Drawing.Point(153, 45);
            this.cancel_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancel_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancel_Button.Size = new System.Drawing.Size(103, 36);
            this.cancel_Button.TabIndex = 40;
            this.cancel_Button.Text = "làm mới";
            this.cancel_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancel_Button.UseAccentColor = false;
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.AutoSize = false;
            this.update_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.update_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.update_Button.Depth = 0;
            this.update_Button.HighEmphasis = true;
            this.update_Button.Icon = null;
            this.update_Button.Location = new System.Drawing.Point(153, 102);
            this.update_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.update_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.update_Button.Name = "update_Button";
            this.update_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.update_Button.Size = new System.Drawing.Size(103, 36);
            this.update_Button.TabIndex = 39;
            this.update_Button.Text = "Sửa";
            this.update_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.update_Button.UseAccentColor = false;
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.AutoSize = false;
            this.delete_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.delete_Button.Depth = 0;
            this.delete_Button.HighEmphasis = true;
            this.delete_Button.Icon = null;
            this.delete_Button.Location = new System.Drawing.Point(26, 102);
            this.delete_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delete_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.delete_Button.Size = new System.Drawing.Size(103, 36);
            this.delete_Button.TabIndex = 38;
            this.delete_Button.Text = "Xoá";
            this.delete_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delete_Button.UseAccentColor = false;
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.AutoSize = false;
            this.add_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.add_Button.Depth = 0;
            this.add_Button.HighEmphasis = true;
            this.add_Button.Icon = null;
            this.add_Button.Location = new System.Drawing.Point(26, 45);
            this.add_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.add_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_Button.Name = "add_Button";
            this.add_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.add_Button.Size = new System.Drawing.Size(103, 36);
            this.add_Button.TabIndex = 37;
            this.add_Button.Text = "Thêm";
            this.add_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.add_Button.UseAccentColor = false;
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // search_Button
            // 
            this.search_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Button.AutoSize = false;
            this.search_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.search_Button.Depth = 0;
            this.search_Button.HighEmphasis = true;
            this.search_Button.Icon = null;
            this.search_Button.Location = new System.Drawing.Point(719, 11);
            this.search_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.search_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_Button.Name = "search_Button";
            this.search_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.search_Button.Size = new System.Drawing.Size(75, 27);
            this.search_Button.TabIndex = 44;
            this.search_Button.Text = "Tìm kiếm";
            this.search_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.search_Button.UseAccentColor = false;
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // VoucherManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 591);
            this.Controls.Add(this.search_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataVoucher);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VoucherManage";
            this.Text = "VourcherManage";
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVoucher)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox used_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label max_money;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label apply_price;
        private System.Windows.Forms.Label voucher_id;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataVoucher;
        private System.Windows.Forms.TextBox voucherId_Box;
        private System.Windows.Forms.TextBox price_Box;
        private System.Windows.Forms.TextBox money_Box;
        private System.Windows.Forms.TextBox percent_Box;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton cancel_Button;
        private MaterialSkin.Controls.MaterialButton update_Button;
        private MaterialSkin.Controls.MaterialButton delete_Button;
        private MaterialSkin.Controls.MaterialButton add_Button;
        private MaterialSkin.Controls.MaterialButton search_Button;
    }
}