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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.percent = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.voucher = new System.Windows.Forms.TextBox();
            this.max_money = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.apply_price = new System.Windows.Forms.Label();
            this.voucher_id = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Information.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox1.Location = new System.Drawing.Point(276, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "used:";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(524, 117);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(133, 22);
            this.money.TabIndex = 7;
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(524, 53);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(133, 22);
            this.percent.TabIndex = 6;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(128, 117);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(130, 22);
            this.price.TabIndex = 5;
            // 
            // voucher
            // 
            this.voucher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voucher.Location = new System.Drawing.Point(104, 40);
            this.voucher.Name = "voucher";
            this.voucher.Size = new System.Drawing.Size(130, 22);
            this.voucher.TabIndex = 4;
            // 
            // max_money
            // 
            this.max_money.AutoSize = true;
            this.max_money.Location = new System.Drawing.Point(389, 117);
            this.max_money.Name = "max_money";
            this.max_money.Size = new System.Drawing.Size(87, 17);
            this.max_money.TabIndex = 3;
            this.max_money.Text = "max_money:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(392, 58);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(84, 17);
            this.lb.TabIndex = 2;
            this.lb.Text = "percent_off:";
            // 
            // apply_price
            // 
            this.apply_price.AutoSize = true;
            this.apply_price.Location = new System.Drawing.Point(37, 122);
            this.apply_price.Name = "apply_price";
            this.apply_price.Size = new System.Drawing.Size(85, 17);
            this.apply_price.TabIndex = 1;
            this.apply_price.Text = "apply_price:";
            // 
            // voucher_id
            // 
            this.voucher_id.AutoSize = true;
            this.voucher_id.Location = new System.Drawing.Point(16, 45);
            this.voucher_id.Name = "voucher_id";
            this.voucher_id.Size = new System.Drawing.Size(82, 17);
            this.voucher_id.TabIndex = 0;
            this.voucher_id.Text = "voucher_id:";
            // 
            // Information
            // 
            this.Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Information.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Information.Controls.Add(this.panel1);
            this.Information.Controls.Add(this.comboBox1);
            this.Information.Controls.Add(this.label2);
            this.Information.Controls.Add(this.money);
            this.Information.Controls.Add(this.percent);
            this.Information.Controls.Add(this.price);
            this.Information.Controls.Add(this.max_money);
            this.Information.Controls.Add(this.lb);
            this.Information.Controls.Add(this.apply_price);
            this.Information.Location = new System.Drawing.Point(12, 352);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(685, 212);
            this.Information.TabIndex = 18;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.voucher_id);
            this.panel1.Controls.Add(this.voucher);
            this.panel1.Location = new System.Drawing.Point(24, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 77);
            this.panel1.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(329, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 25);
            this.button6.TabIndex = 17;
            this.button6.Text = "search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(714, 516);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 37);
            this.button5.TabIndex = 15;
            this.button5.Text = "exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(714, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 37);
            this.button4.TabIndex = 14;
            this.button4.Text = "update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(714, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(714, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 282);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VoucherManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.pngtree_fashion_gold_voucher_template_image_261964;
            this.ClientSize = new System.Drawing.Size(831, 576);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VoucherManage";
            this.Text = "VourcherManage";
            this.Load += new System.EventHandler(this.VoucherManage_Load);
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox percent;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox voucher;
        private System.Windows.Forms.Label max_money;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label apply_price;
        private System.Windows.Forms.Label voucher_id;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}