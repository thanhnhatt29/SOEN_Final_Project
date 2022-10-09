namespace UI
{
    partial class OrderManage
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
            this.bt_checkVoucher = new System.Windows.Forms.Button();
            this.textBox_voucher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_offPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_totalAmount = new System.Windows.Forms.Label();
            this.dataGridView_bill = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_billID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_productID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_deleteProduct = new System.Windows.Forms.Button();
            this.lb_productName = new System.Windows.Forms.Label();
            this.bt_addProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_productPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_checkVoucher);
            this.panel1.Controls.Add(this.textBox_voucher);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lb_offPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(578, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 599);
            this.panel1.TabIndex = 0;
            // 
            // bt_checkVoucher
            // 
            this.bt_checkVoucher.Location = new System.Drawing.Point(291, 457);
            this.bt_checkVoucher.Name = "bt_checkVoucher";
            this.bt_checkVoucher.Size = new System.Drawing.Size(72, 28);
            this.bt_checkVoucher.TabIndex = 17;
            this.bt_checkVoucher.Text = "Check";
            this.bt_checkVoucher.UseVisualStyleBackColor = true;
            // 
            // textBox_voucher
            // 
            this.textBox_voucher.Location = new System.Drawing.Point(113, 460);
            this.textBox_voucher.Name = "textBox_voucher";
            this.textBox_voucher.Size = new System.Drawing.Size(162, 22);
            this.textBox_voucher.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Khuyến mãi:";
            // 
            // lb_offPrice
            // 
            this.lb_offPrice.AutoSize = true;
            this.lb_offPrice.Location = new System.Drawing.Point(132, 499);
            this.lb_offPrice.Name = "lb_offPrice";
            this.lb_offPrice.Size = new System.Drawing.Size(45, 16);
            this.lb_offPrice.TabIndex = 15;
            this.lb_offPrice.Text = "0 VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng tiền:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_totalAmount);
            this.groupBox2.Controls.Add(this.dataGridView_bill);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lb_billID);
            this.groupBox2.Location = new System.Drawing.Point(3, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 262);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoá đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng:";
            // 
            // lb_totalAmount
            // 
            this.lb_totalAmount.AutoSize = true;
            this.lb_totalAmount.Location = new System.Drawing.Point(361, 234);
            this.lb_totalAmount.Name = "lb_totalAmount";
            this.lb_totalAmount.Size = new System.Drawing.Size(28, 16);
            this.lb_totalAmount.TabIndex = 8;
            this.lb_totalAmount.Text = "123";
            // 
            // dataGridView_bill
            // 
            this.dataGridView_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bill.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_bill.Name = "dataGridView_bill";
            this.dataGridView_bill.RowHeadersWidth = 51;
            this.dataGridView_bill.RowTemplate.Height = 24;
            this.dataGridView_bill.Size = new System.Drawing.Size(400, 201);
            this.dataGridView_bill.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã hoá đơn:";
            // 
            // lb_billID
            // 
            this.lb_billID.AutoSize = true;
            this.lb_billID.Location = new System.Drawing.Point(106, 234);
            this.lb_billID.Name = "lb_billID";
            this.lb_billID.Size = new System.Drawing.Size(28, 16);
            this.lb_billID.TabIndex = 4;
            this.lb_billID.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "0 VNĐ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_productID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.bt_deleteProduct);
            this.groupBox1.Controls.Add(this.lb_productName);
            this.groupBox1.Controls.Add(this.bt_addProduct);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_productPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(3, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 161);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // lb_productID
            // 
            this.lb_productID.AutoSize = true;
            this.lb_productID.Location = new System.Drawing.Point(211, 30);
            this.lb_productID.Name = "lb_productID";
            this.lb_productID.Size = new System.Drawing.Size(70, 16);
            this.lb_productID.TabIndex = 17;
            this.lb_productID.Text = "product_id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã món:";
            // 
            // bt_deleteProduct
            // 
            this.bt_deleteProduct.Location = new System.Drawing.Point(247, 91);
            this.bt_deleteProduct.Name = "bt_deleteProduct";
            this.bt_deleteProduct.Size = new System.Drawing.Size(93, 55);
            this.bt_deleteProduct.TabIndex = 15;
            this.bt_deleteProduct.Text = "-";
            this.bt_deleteProduct.UseVisualStyleBackColor = true;
            this.bt_deleteProduct.Click += new System.EventHandler(this.bt_deleteProduct_Click);
            // 
            // lb_productName
            // 
            this.lb_productName.AutoSize = true;
            this.lb_productName.Location = new System.Drawing.Point(87, 61);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.Size = new System.Drawing.Size(93, 16);
            this.lb_productName.TabIndex = 11;
            this.lb_productName.Text = "product_name";
            // 
            // bt_addProduct
            // 
            this.bt_addProduct.Location = new System.Drawing.Point(41, 91);
            this.bt_addProduct.Name = "bt_addProduct";
            this.bt_addProduct.Size = new System.Drawing.Size(93, 55);
            this.bt_addProduct.TabIndex = 14;
            this.bt_addProduct.Text = "+";
            this.bt_addProduct.UseVisualStyleBackColor = true;
            this.bt_addProduct.Click += new System.EventHandler(this.bt_addProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên món:";
            // 
            // lb_productPrice
            // 
            this.lb_productPrice.AutoSize = true;
            this.lb_productPrice.Location = new System.Drawing.Point(276, 61);
            this.lb_productPrice.Name = "lb_productPrice";
            this.lb_productPrice.Size = new System.Drawing.Size(45, 16);
            this.lb_productPrice.TabIndex = 9;
            this.lb_productPrice.Text = "0 VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giá tiền:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 529);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 55);
            this.button3.TabIndex = 7;
            this.button3.Text = "Hủy đơn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voucher:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 599);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // OrderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 623);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "OrderManage";
            this.Text = "OrderManage";
            this.Load += new System.EventHandler(this.OrderManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_billID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_productName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_productPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_bill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_deleteProduct;
        private System.Windows.Forms.Button bt_addProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_totalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_offPrice;
        private System.Windows.Forms.Button bt_checkVoucher;
        private System.Windows.Forms.TextBox textBox_voucher;
        private System.Windows.Forms.Label lb_productID;
        private System.Windows.Forms.Label label10;
    }
}