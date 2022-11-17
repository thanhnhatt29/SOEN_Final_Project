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
            this.bt_payBill = new System.Windows.Forms.Panel();
            this.textBox_moneyPay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_finalPrice = new System.Windows.Forms.Label();
            this.bt_checkVoucher = new System.Windows.Forms.Button();
            this.textBox_voucher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_offPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_totalAmount = new System.Windows.Forms.Label();
            this.dataGridView_bill = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_billID = new System.Windows.Forms.Label();
            this.lb_totalPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_productID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_deleteProduct = new System.Windows.Forms.Button();
            this.lb_productName = new System.Windows.Forms.Label();
            this.bt_addProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_productPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_cancelBill = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_payBill.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_payBill
            // 
            this.bt_payBill.Controls.Add(this.textBox_moneyPay);
            this.bt_payBill.Controls.Add(this.label7);
            this.bt_payBill.Controls.Add(this.label4);
            this.bt_payBill.Controls.Add(this.lb_finalPrice);
            this.bt_payBill.Controls.Add(this.bt_checkVoucher);
            this.bt_payBill.Controls.Add(this.textBox_voucher);
            this.bt_payBill.Controls.Add(this.label9);
            this.bt_payBill.Controls.Add(this.lb_offPrice);
            this.bt_payBill.Controls.Add(this.groupBox2);
            this.bt_payBill.Controls.Add(this.groupBox1);
            this.bt_payBill.Controls.Add(this.bt_cancelBill);
            this.bt_payBill.Controls.Add(this.button2);
            this.bt_payBill.Controls.Add(this.label1);
            this.bt_payBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_payBill.Location = new System.Drawing.Point(440, 0);
            this.bt_payBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_payBill.Name = "bt_payBill";
            this.bt_payBill.Size = new System.Drawing.Size(314, 506);
            this.bt_payBill.TabIndex = 0;
            // 
            // textBox_moneyPay
            // 
            this.textBox_moneyPay.Location = new System.Drawing.Point(88, 401);
            this.textBox_moneyPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_moneyPay.Name = "textBox_moneyPay";
            this.textBox_moneyPay.Size = new System.Drawing.Size(122, 20);
            this.textBox_moneyPay.TabIndex = 19;
            this.textBox_moneyPay.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tiền nhận:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 379);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng thu:";
            // 
            // lb_finalPrice
            // 
            this.lb_finalPrice.AutoSize = true;
            this.lb_finalPrice.Location = new System.Drawing.Point(242, 379);
            this.lb_finalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_finalPrice.Name = "lb_finalPrice";
            this.lb_finalPrice.Size = new System.Drawing.Size(13, 13);
            this.lb_finalPrice.TabIndex = 10;
            this.lb_finalPrice.Text = "0";
            // 
            // bt_checkVoucher
            // 
            this.bt_checkVoucher.Location = new System.Drawing.Point(221, 345);
            this.bt_checkVoucher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_checkVoucher.Name = "bt_checkVoucher";
            this.bt_checkVoucher.Size = new System.Drawing.Size(54, 23);
            this.bt_checkVoucher.TabIndex = 17;
            this.bt_checkVoucher.Text = "Check";
            this.bt_checkVoucher.UseVisualStyleBackColor = true;
            this.bt_checkVoucher.Click += new System.EventHandler(this.bt_checkVoucher_Click);
            // 
            // textBox_voucher
            // 
            this.textBox_voucher.Location = new System.Drawing.Point(88, 348);
            this.textBox_voucher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_voucher.Name = "textBox_voucher";
            this.textBox_voucher.Size = new System.Drawing.Size(122, 20);
            this.textBox_voucher.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 379);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Khuyến mãi:";
            // 
            // lb_offPrice
            // 
            this.lb_offPrice.AutoSize = true;
            this.lb_offPrice.Location = new System.Drawing.Point(102, 379);
            this.lb_offPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_offPrice.Name = "lb_offPrice";
            this.lb_offPrice.Size = new System.Drawing.Size(13, 13);
            this.lb_offPrice.TabIndex = 15;
            this.lb_offPrice.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_totalAmount);
            this.groupBox2.Controls.Add(this.dataGridView_bill);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lb_billID);
            this.groupBox2.Controls.Add(this.lb_totalPrice);
            this.groupBox2.Location = new System.Drawing.Point(2, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 229);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoá đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng:";
            // 
            // lb_totalAmount
            // 
            this.lb_totalAmount.AutoSize = true;
            this.lb_totalAmount.Location = new System.Drawing.Point(276, 184);
            this.lb_totalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_totalAmount.Name = "lb_totalAmount";
            this.lb_totalAmount.Size = new System.Drawing.Size(25, 13);
            this.lb_totalAmount.TabIndex = 8;
            this.lb_totalAmount.Text = "123";
            // 
            // dataGridView_bill
            // 
            this.dataGridView_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bill.Location = new System.Drawing.Point(4, 17);
            this.dataGridView_bill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_bill.Name = "dataGridView_bill";
            this.dataGridView_bill.RowHeadersWidth = 51;
            this.dataGridView_bill.RowTemplate.Height = 24;
            this.dataGridView_bill.Size = new System.Drawing.Size(300, 164);
            this.dataGridView_bill.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã hoá đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng tiền:";
            // 
            // lb_billID
            // 
            this.lb_billID.Location = new System.Drawing.Point(86, 184);
            this.lb_billID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_billID.Name = "lb_billID";
            this.lb_billID.Size = new System.Drawing.Size(64, 13);
            this.lb_billID.TabIndex = 4;
            this.lb_billID.Text = "123";
            // 
            // lb_totalPrice
            // 
            this.lb_totalPrice.AutoSize = true;
            this.lb_totalPrice.Location = new System.Drawing.Point(168, 206);
            this.lb_totalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_totalPrice.Name = "lb_totalPrice";
            this.lb_totalPrice.Size = new System.Drawing.Size(13, 13);
            this.lb_totalPrice.TabIndex = 6;
            this.lb_totalPrice.Text = "0";
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
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(309, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // lb_productID
            // 
            this.lb_productID.AutoSize = true;
            this.lb_productID.Location = new System.Drawing.Point(158, 24);
            this.lb_productID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_productID.Name = "lb_productID";
            this.lb_productID.Size = new System.Drawing.Size(57, 13);
            this.lb_productID.TabIndex = 17;
            this.lb_productID.Text = "product_id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã món:";
            // 
            // bt_deleteProduct
            // 
            this.bt_deleteProduct.Location = new System.Drawing.Point(185, 74);
            this.bt_deleteProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_deleteProduct.Name = "bt_deleteProduct";
            this.bt_deleteProduct.Size = new System.Drawing.Size(70, 24);
            this.bt_deleteProduct.TabIndex = 15;
            this.bt_deleteProduct.Text = "-";
            this.bt_deleteProduct.UseVisualStyleBackColor = true;
            this.bt_deleteProduct.Click += new System.EventHandler(this.bt_deleteProduct_Click);
            // 
            // lb_productName
            // 
            this.lb_productName.AutoSize = true;
            this.lb_productName.Location = new System.Drawing.Point(65, 50);
            this.lb_productName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.Size = new System.Drawing.Size(75, 13);
            this.lb_productName.TabIndex = 11;
            this.lb_productName.Text = "product_name";
            // 
            // bt_addProduct
            // 
            this.bt_addProduct.Location = new System.Drawing.Point(31, 74);
            this.bt_addProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_addProduct.Name = "bt_addProduct";
            this.bt_addProduct.Size = new System.Drawing.Size(70, 24);
            this.bt_addProduct.TabIndex = 14;
            this.bt_addProduct.Text = "+";
            this.bt_addProduct.UseVisualStyleBackColor = true;
            this.bt_addProduct.Click += new System.EventHandler(this.bt_addProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên món:";
            // 
            // lb_productPrice
            // 
            this.lb_productPrice.AutoSize = true;
            this.lb_productPrice.Location = new System.Drawing.Point(207, 50);
            this.lb_productPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_productPrice.Name = "lb_productPrice";
            this.lb_productPrice.Size = new System.Drawing.Size(13, 13);
            this.lb_productPrice.TabIndex = 9;
            this.lb_productPrice.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giá tiền:";
            // 
            // bt_cancelBill
            // 
            this.bt_cancelBill.Location = new System.Drawing.Point(202, 443);
            this.bt_cancelBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_cancelBill.Name = "bt_cancelBill";
            this.bt_cancelBill.Size = new System.Drawing.Size(70, 32);
            this.bt_cancelBill.TabIndex = 7;
            this.bt_cancelBill.Text = "Hủy đơn";
            this.bt_cancelBill.UseVisualStyleBackColor = true;
            this.bt_cancelBill.Click += new System.EventHandler(this.bt_cancelBill_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 443);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voucher:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 506);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // OrderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 506);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bt_payBill);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderManage";
            this.Text = "OrderManage";
            this.Load += new System.EventHandler(this.OrderManage_Load);
            this.bt_payBill.ResumeLayout(false);
            this.bt_payBill.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bt_payBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_cancelBill;
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
        private System.Windows.Forms.Label lb_totalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_totalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_offPrice;
        private System.Windows.Forms.Button bt_checkVoucher;
        private System.Windows.Forms.TextBox textBox_voucher;
        private System.Windows.Forms.Label lb_productID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_finalPrice;
        private System.Windows.Forms.TextBox textBox_moneyPay;
        private System.Windows.Forms.Label label7;
    }
}