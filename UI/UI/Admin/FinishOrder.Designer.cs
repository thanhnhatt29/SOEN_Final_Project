namespace UI
{
    partial class FinishOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_totalPrice = new System.Windows.Forms.Label();
            this.lb_offPrice = new System.Windows.Forms.Label();
            this.lb_finalPrice = new System.Windows.Forms.Label();
            this.lb_moneyGet = new System.Windows.Forms.Label();
            this.lb_moneyReturn = new System.Windows.Forms.Label();
            this.bt_yes = new System.Windows.Forms.Button();
            this.bt_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giảm giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng thu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiền nhận:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiền trả:";
            // 
            // lb_totalPrice
            // 
            this.lb_totalPrice.AutoSize = true;
            this.lb_totalPrice.Location = new System.Drawing.Point(222, 27);
            this.lb_totalPrice.Name = "lb_totalPrice";
            this.lb_totalPrice.Size = new System.Drawing.Size(44, 16);
            this.lb_totalPrice.TabIndex = 5;
            this.lb_totalPrice.Text = "label6";
            // 
            // lb_offPrice
            // 
            this.lb_offPrice.AutoSize = true;
            this.lb_offPrice.Location = new System.Drawing.Point(222, 69);
            this.lb_offPrice.Name = "lb_offPrice";
            this.lb_offPrice.Size = new System.Drawing.Size(44, 16);
            this.lb_offPrice.TabIndex = 8;
            this.lb_offPrice.Text = "label7";
            // 
            // lb_finalPrice
            // 
            this.lb_finalPrice.AutoSize = true;
            this.lb_finalPrice.Location = new System.Drawing.Point(222, 112);
            this.lb_finalPrice.Name = "lb_finalPrice";
            this.lb_finalPrice.Size = new System.Drawing.Size(44, 16);
            this.lb_finalPrice.TabIndex = 7;
            this.lb_finalPrice.Text = "label8";
            // 
            // lb_moneyGet
            // 
            this.lb_moneyGet.AutoSize = true;
            this.lb_moneyGet.Location = new System.Drawing.Point(222, 152);
            this.lb_moneyGet.Name = "lb_moneyGet";
            this.lb_moneyGet.Size = new System.Drawing.Size(44, 16);
            this.lb_moneyGet.TabIndex = 10;
            this.lb_moneyGet.Text = "label9";
            // 
            // lb_moneyReturn
            // 
            this.lb_moneyReturn.AutoSize = true;
            this.lb_moneyReturn.Location = new System.Drawing.Point(222, 193);
            this.lb_moneyReturn.Name = "lb_moneyReturn";
            this.lb_moneyReturn.Size = new System.Drawing.Size(51, 16);
            this.lb_moneyReturn.TabIndex = 9;
            this.lb_moneyReturn.Text = "label10";
            // 
            // bt_yes
            // 
            this.bt_yes.Location = new System.Drawing.Point(53, 239);
            this.bt_yes.Name = "bt_yes";
            this.bt_yes.Size = new System.Drawing.Size(95, 34);
            this.bt_yes.TabIndex = 11;
            this.bt_yes.Text = "Xác nhận";
            this.bt_yes.UseVisualStyleBackColor = true;
            this.bt_yes.Click += new System.EventHandler(this.bt_yes_Click);
            // 
            // bt_no
            // 
            this.bt_no.Location = new System.Drawing.Point(201, 239);
            this.bt_no.Name = "bt_no";
            this.bt_no.Size = new System.Drawing.Size(95, 34);
            this.bt_no.TabIndex = 12;
            this.bt_no.Text = "Huỷ";
            this.bt_no.UseVisualStyleBackColor = true;
            this.bt_no.Click += new System.EventHandler(this.bt_no_Click);
            // 
            // FinishOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 307);
            this.Controls.Add(this.bt_no);
            this.Controls.Add(this.bt_yes);
            this.Controls.Add(this.lb_moneyGet);
            this.Controls.Add(this.lb_moneyReturn);
            this.Controls.Add(this.lb_offPrice);
            this.Controls.Add(this.lb_finalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_totalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FinishOrder";
            this.Text = "FinishOrder";
            this.Load += new System.EventHandler(this.FinishOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_totalPrice;
        private System.Windows.Forms.Label lb_offPrice;
        private System.Windows.Forms.Label lb_finalPrice;
        private System.Windows.Forms.Label lb_moneyGet;
        private System.Windows.Forms.Label lb_moneyReturn;
        private System.Windows.Forms.Button bt_yes;
        private System.Windows.Forms.Button bt_no;
    }
}