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
            this.panel3.Location = new System.Drawing.Point(445, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 620);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Picture";
            // 
            // productImg
            // 
            this.productImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productImg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImg.Location = new System.Drawing.Point(258, 237);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(208, 140);
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
            this.label7.Location = new System.Drawing.Point(421, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "VNĐ";
            // 
            // remove_Button
            // 
            this.remove_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.remove_Button.Location = new System.Drawing.Point(44, 486);
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.Size = new System.Drawing.Size(194, 70);
            this.remove_Button.TabIndex = 34;
            this.remove_Button.Text = "REMOVE";
            this.remove_Button.UseVisualStyleBackColor = false;
            this.remove_Button.Click += new System.EventHandler(this.remove_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.add_Button.Location = new System.Drawing.Point(44, 403);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(194, 70);
            this.add_Button.TabIndex = 31;
            this.add_Button.Text = "ADD";
            this.add_Button.UseVisualStyleBackColor = false;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_Button.Location = new System.Drawing.Point(258, 486);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(194, 70);
            this.cancel_Button.TabIndex = 32;
            this.cancel_Button.Text = "CANCEL";
            this.cancel_Button.UseVisualStyleBackColor = false;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.update_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.update_Button.Location = new System.Drawing.Point(258, 403);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(194, 70);
            this.update_Button.TabIndex = 33;
            this.update_Button.Text = "UPDATE";
            this.update_Button.UseVisualStyleBackColor = false;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // productID_Box
            // 
            this.productID_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productID_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productID_Box.Enabled = false;
            this.productID_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID_Box.Location = new System.Drawing.Point(18, 86);
            this.productID_Box.Name = "productID_Box";
            this.productID_Box.Size = new System.Drawing.Size(220, 34);
            this.productID_Box.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product ID";
            // 
            // productPrice_box
            // 
            this.productPrice_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productPrice_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productPrice_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice_box.Location = new System.Drawing.Point(258, 86);
            this.productPrice_box.Name = "productPrice_box";
            this.productPrice_box.Size = new System.Drawing.Size(157, 34);
            this.productPrice_box.TabIndex = 24;
            // 
            // productDetail
            // 
            this.productDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDetail.Location = new System.Drawing.Point(18, 237);
            this.productDetail.Name = "productDetail";
            this.productDetail.Size = new System.Drawing.Size(220, 140);
            this.productDetail.TabIndex = 27;
            this.productDetail.Text = "";
            // 
            // productName_Box
            // 
            this.productName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_Box.Location = new System.Drawing.Point(18, 160);
            this.productName_Box.Name = "productName_Box";
            this.productName_Box.Size = new System.Drawing.Size(448, 34);
            this.productName_Box.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Details";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Price";
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
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 620);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Product List";
            // 
            // productData
            // 
            this.productData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.productData.ColumnHeadersHeight = 29;
            this.productData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productData.Location = new System.Drawing.Point(11, 44);
            this.productData.Name = "productData";
            this.productData.RowHeadersWidth = 51;
            this.productData.RowTemplate.Height = 70;
            this.productData.Size = new System.Drawing.Size(417, 372);
            this.productData.TabIndex = 16;
            this.productData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productData_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search for name";
            // 
            // searchName_Box
            // 
            this.searchName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchName_Box.Location = new System.Drawing.Point(11, 488);
            this.searchName_Box.Name = "searchName_Box";
            this.searchName_Box.Size = new System.Drawing.Size(417, 34);
            this.searchName_Box.TabIndex = 15;
            this.searchName_Box.TextChanged += new System.EventHandler(this.searchName_Box_TextChanged);
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 620);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
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