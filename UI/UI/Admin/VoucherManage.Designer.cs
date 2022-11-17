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
            this.search_Button = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.exit_Button = new System.Windows.Forms.Button();
            this.update_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataVoucher = new System.Windows.Forms.DataGridView();
            this.Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // used_Box
            // 
            this.used_Box.Cursor = System.Windows.Forms.Cursors.Default;
            this.used_Box.FormattingEnabled = true;
            this.used_Box.Items.AddRange(new object[] {
            "True",
            "False"});
            this.used_Box.Location = new System.Drawing.Point(276, 165);
            this.used_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.used_Box.Name = "used_Box";
            this.used_Box.Size = new System.Drawing.Size(135, 24);
            this.used_Box.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "used:";
            // 
            // max_money
            // 
            this.max_money.AutoSize = true;
            this.max_money.Location = new System.Drawing.Point(389, 117);
            this.max_money.Name = "max_money";
            this.max_money.Size = new System.Drawing.Size(83, 16);
            this.max_money.TabIndex = 3;
            this.max_money.Text = "max_money:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(392, 58);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(76, 16);
            this.lb.TabIndex = 2;
            this.lb.Text = "percent_off:";
            // 
            // apply_price
            // 
            this.apply_price.AutoSize = true;
            this.apply_price.Location = new System.Drawing.Point(37, 122);
            this.apply_price.Name = "apply_price";
            this.apply_price.Size = new System.Drawing.Size(81, 16);
            this.apply_price.TabIndex = 1;
            this.apply_price.Text = "apply_price:";
            // 
            // voucher_id
            // 
            this.voucher_id.AutoSize = true;
            this.voucher_id.Location = new System.Drawing.Point(42, 58);
            this.voucher_id.Name = "voucher_id";
            this.voucher_id.Size = new System.Drawing.Size(76, 16);
            this.voucher_id.TabIndex = 0;
            this.voucher_id.Text = "voucher_id:";
            // 
            // Information
            // 
            this.Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Information.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.Information.Location = new System.Drawing.Point(12, 503);
            this.Information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Information.Name = "Information";
            this.Information.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Information.Size = new System.Drawing.Size(935, 212);
            this.Information.TabIndex = 18;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // voucherId_Box
            // 
            this.voucherId_Box.Location = new System.Drawing.Point(135, 55);
            this.voucherId_Box.Name = "voucherId_Box";
            this.voucherId_Box.Size = new System.Drawing.Size(100, 22);
            this.voucherId_Box.TabIndex = 13;
            // 
            // price_Box
            // 
            this.price_Box.Location = new System.Drawing.Point(135, 122);
            this.price_Box.Name = "price_Box";
            this.price_Box.Size = new System.Drawing.Size(100, 22);
            this.price_Box.TabIndex = 12;
            // 
            // money_Box
            // 
            this.money_Box.Location = new System.Drawing.Point(489, 111);
            this.money_Box.Name = "money_Box";
            this.money_Box.Size = new System.Drawing.Size(100, 22);
            this.money_Box.TabIndex = 11;
            // 
            // percent_Box
            // 
            this.percent_Box.Location = new System.Drawing.Point(489, 55);
            this.percent_Box.Name = "percent_Box";
            this.percent_Box.Size = new System.Drawing.Size(100, 22);
            this.percent_Box.TabIndex = 10;
            // 
            // search_Button
            // 
            this.search_Button.Location = new System.Drawing.Point(329, 12);
            this.search_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(81, 25);
            this.search_Button.TabIndex = 17;
            this.search_Button.Text = "search";
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(112, 12);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(196, 22);
            this.searchBox.TabIndex = 16;
            // 
            // exit_Button
            // 
            this.exit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_Button.Location = new System.Drawing.Point(964, 667);
            this.exit_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(96, 37);
            this.exit_Button.TabIndex = 15;
            this.exit_Button.Text = "exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.update_Button.Location = new System.Drawing.Point(964, 570);
            this.update_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(96, 37);
            this.update_Button.TabIndex = 14;
            this.update_Button.Text = "update";
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_Button.Location = new System.Drawing.Point(964, 619);
            this.delete_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(96, 37);
            this.delete_Button.TabIndex = 13;
            this.delete_Button.Text = "delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Button.Location = new System.Drawing.Point(964, 521);
            this.add_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(96, 37);
            this.add_Button.TabIndex = 12;
            this.add_Button.Text = "add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Voucher:";
            // 
            // dataVoucher
            // 
            this.dataVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataVoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVoucher.BackgroundColor = System.Drawing.Color.White;
            this.dataVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVoucher.Location = new System.Drawing.Point(12, 52);
            this.dataVoucher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataVoucher.Name = "dataVoucher";
            this.dataVoucher.RowHeadersWidth = 51;
            this.dataVoucher.RowTemplate.Height = 24;
            this.dataVoucher.Size = new System.Drawing.Size(1047, 433);
            this.dataVoucher.TabIndex = 10;
            // 
            // VoucherManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 727);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.search_Button);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.update_Button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataVoucher);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VoucherManage";
            this.Text = "VourcherManage";
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVoucher)).EndInit();
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
        private System.Windows.Forms.Button search_Button;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataVoucher;
        private System.Windows.Forms.TextBox voucherId_Box;
        private System.Windows.Forms.TextBox price_Box;
        private System.Windows.Forms.TextBox money_Box;
        private System.Windows.Forms.TextBox percent_Box;
    }
}