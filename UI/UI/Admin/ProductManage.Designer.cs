namespace UI
{
    partial class ProductManage
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
            this.productImg = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.remove_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.update_Button = new System.Windows.Forms.Button();
            this.productID_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productPrice_box = new System.Windows.Forms.TextBox();
            this.productDetail = new System.Windows.Forms.RichTextBox();
            this.productName_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.productData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.searchName_Box = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.productImg);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.remove_Button);
            this.panel3.Controls.Add(this.add_Button);
            this.panel3.Controls.Add(this.cancel_Button);
            this.panel3.Controls.Add(this.update_Button);
            this.panel3.Controls.Add(this.productID_Box);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.productPrice_box);
            this.panel3.Controls.Add(this.productDetail);
            this.panel3.Controls.Add(this.productName_Box);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(443, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 591);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Hình ảnh";
            // 
            // productImg
            // 
            this.productImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productImg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImg.Location = new System.Drawing.Point(194, 236);
            this.productImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(156, 114);
            this.productImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImg.TabIndex = 36;
            this.productImg.TabStop = false;
            this.productImg.Click += new System.EventHandler(this.productImg_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "VNĐ";
            // 
            // remove_Button
            // 
            this.remove_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.remove_Button.Location = new System.Drawing.Point(33, 438);
            this.remove_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.Size = new System.Drawing.Size(146, 57);
            this.remove_Button.TabIndex = 34;
            this.remove_Button.Text = "XÓA";
            this.remove_Button.UseVisualStyleBackColor = false;
            this.remove_Button.Click += new System.EventHandler(this.remove_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.add_Button.Location = new System.Drawing.Point(33, 370);
            this.add_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(146, 57);
            this.add_Button.TabIndex = 31;
            this.add_Button.Text = "THÊM";
            this.add_Button.UseVisualStyleBackColor = false;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_Button.Location = new System.Drawing.Point(194, 438);
            this.cancel_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(146, 57);
            this.cancel_Button.TabIndex = 32;
            this.cancel_Button.Text = "LÀM MỚI";
            this.cancel_Button.UseVisualStyleBackColor = false;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.update_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.update_Button.Location = new System.Drawing.Point(194, 370);
            this.update_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(146, 57);
            this.update_Button.TabIndex = 33;
            this.update_Button.Text = "SỬA";
            this.update_Button.UseVisualStyleBackColor = false;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // productID_Box
            // 
            this.productID_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productID_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productID_Box.Enabled = false;
            this.productID_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID_Box.Location = new System.Drawing.Point(14, 113);
            this.productID_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productID_Box.Name = "productID_Box";
            this.productID_Box.Size = new System.Drawing.Size(166, 28);
            this.productID_Box.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã sản phẩm";
            // 
            // productPrice_box
            // 
            this.productPrice_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productPrice_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productPrice_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice_box.Location = new System.Drawing.Point(194, 113);
            this.productPrice_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productPrice_box.Name = "productPrice_box";
            this.productPrice_box.Size = new System.Drawing.Size(119, 28);
            this.productPrice_box.TabIndex = 24;
            // 
            // productDetail
            // 
            this.productDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDetail.Location = new System.Drawing.Point(14, 236);
            this.productDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productDetail.Name = "productDetail";
            this.productDetail.Size = new System.Drawing.Size(166, 114);
            this.productDetail.TabIndex = 27;
            this.productDetail.Text = "";
            // 
            // productName_Box
            // 
            this.productName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_Box.Location = new System.Drawing.Point(14, 173);
            this.productName_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productName_Box.Name = "productName_Box";
            this.productName_Box.Size = new System.Drawing.Size(337, 28);
            this.productName_Box.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Chi tiết sản phẩm";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giá tiền";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.productData);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.searchName_Box);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 591);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Danh sách sản phẩm";
            // 
            // productData
            // 
            this.productData.AllowUserToOrderColumns = true;
            this.productData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.productData.ColumnHeadersHeight = 29;
            this.productData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productData.Location = new System.Drawing.Point(8, 36);
            this.productData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productData.Name = "productData";
            this.productData.RowHeadersWidth = 51;
            this.productData.RowTemplate.Height = 70;
            this.productData.Size = new System.Drawing.Size(422, 389);
            this.productData.TabIndex = 16;
            this.productData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productData_CellContentClick);
            this.productData.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productData_ColumnHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 468);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tìm theo tên sản phẩm";
            // 
            // searchName_Box
            // 
            this.searchName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchName_Box.Location = new System.Drawing.Point(8, 483);
            this.searchName_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchName_Box.Name = "searchName_Box";
            this.searchName_Box.Size = new System.Drawing.Size(423, 28);
            this.searchName_Box.TabIndex = 15;
            this.searchName_Box.TextChanged += new System.EventHandler(this.searchName_Box_TextChanged);
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 591);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductManage";
            this.Text = "ProductManage";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox productPrice_box;
        private System.Windows.Forms.RichTextBox productDetail;
        private System.Windows.Forms.TextBox productName_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView productData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchName_Box;
        private System.Windows.Forms.TextBox productID_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_Button;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox productImg;
    }
}