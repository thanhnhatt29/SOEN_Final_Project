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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productImg = new System.Windows.Forms.PictureBox();
            this.productID_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productPrice_box = new System.Windows.Forms.TextBox();
            this.productDetail = new System.Windows.Forms.RichTextBox();
            this.productName_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancel_Button = new MaterialSkin.Controls.MaterialButton();
            this.update_Button = new MaterialSkin.Controls.MaterialButton();
            this.remove_Button = new MaterialSkin.Controls.MaterialButton();
            this.add_Button = new MaterialSkin.Controls.MaterialButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchName_Box = new MaterialSkin.Controls.MaterialTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.productData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(677, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 727);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(161)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.productImg);
            this.groupBox1.Controls.Add(this.productID_Box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.productPrice_box);
            this.groupBox1.Controls.Add(this.productDetail);
            this.groupBox1.Controls.Add(this.productName_Box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(377, 415);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 30);
            this.label8.TabIndex = 37;
            this.label8.Text = "Hình ảnh";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // productImg
            // 
            this.productImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productImg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImg.Location = new System.Drawing.Point(225, 262);
            this.productImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(146, 140);
            this.productImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImg.TabIndex = 36;
            this.productImg.TabStop = false;
            this.productImg.Click += new System.EventHandler(this.productImg_Click);
            // 
            // productID_Box
            // 
            this.productID_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productID_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productID_Box.Enabled = false;
            this.productID_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID_Box.Location = new System.Drawing.Point(9, 82);
            this.productID_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productID_Box.Name = "productID_Box";
            this.productID_Box.Size = new System.Drawing.Size(211, 32);
            this.productID_Box.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã sản phẩm";
            // 
            // productPrice_box
            // 
            this.productPrice_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productPrice_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productPrice_box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice_box.Location = new System.Drawing.Point(249, 82);
            this.productPrice_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPrice_box.Name = "productPrice_box";
            this.productPrice_box.Size = new System.Drawing.Size(121, 32);
            this.productPrice_box.TabIndex = 24;
            // 
            // productDetail
            // 
            this.productDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productDetail.Font = new System.Drawing.Font("#LQC01 Quicksand Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDetail.Location = new System.Drawing.Point(9, 262);
            this.productDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDetail.Name = "productDetail";
            this.productDetail.Size = new System.Drawing.Size(164, 139);
            this.productDetail.TabIndex = 27;
            this.productDetail.Text = "";
            // 
            // productName_Box
            // 
            this.productName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productName_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productName_Box.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_Box.Location = new System.Drawing.Point(8, 169);
            this.productName_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productName_Box.Name = "productName_Box";
            this.productName_Box.Size = new System.Drawing.Size(363, 32);
            this.productName_Box.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "Chi tiết sản phẩm";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giá tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.groupBox2.Controls.Add(this.cancel_Button);
            this.groupBox2.Controls.Add(this.update_Button);
            this.groupBox2.Controls.Add(this.remove_Button);
            this.groupBox2.Controls.Add(this.add_Button);
            this.groupBox2.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 494);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(377, 178);
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
            this.cancel_Button.Location = new System.Drawing.Point(196, 36);
            this.cancel_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cancel_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancel_Button.Size = new System.Drawing.Size(137, 44);
            this.cancel_Button.TabIndex = 40;
            this.cancel_Button.Text = "làm mới";
            this.cancel_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancel_Button.UseAccentColor = false;
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.AutoSize = false;
            this.update_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.update_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.update_Button.Depth = 0;
            this.update_Button.HighEmphasis = true;
            this.update_Button.Icon = null;
            this.update_Button.Location = new System.Drawing.Point(196, 106);
            this.update_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.update_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.update_Button.Name = "update_Button";
            this.update_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.update_Button.Size = new System.Drawing.Size(137, 44);
            this.update_Button.TabIndex = 39;
            this.update_Button.Text = "Sửa";
            this.update_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.update_Button.UseAccentColor = false;
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // remove_Button
            // 
            this.remove_Button.AutoSize = false;
            this.remove_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.remove_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.remove_Button.Depth = 0;
            this.remove_Button.HighEmphasis = true;
            this.remove_Button.Icon = null;
            this.remove_Button.Location = new System.Drawing.Point(27, 106);
            this.remove_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.remove_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.remove_Button.Size = new System.Drawing.Size(137, 44);
            this.remove_Button.TabIndex = 38;
            this.remove_Button.Text = "Xoá";
            this.remove_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.remove_Button.UseAccentColor = false;
            this.remove_Button.UseVisualStyleBackColor = true;
            this.remove_Button.Click += new System.EventHandler(this.remove_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.AutoSize = false;
            this.add_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.add_Button.Depth = 0;
            this.add_Button.HighEmphasis = true;
            this.add_Button.Icon = null;
            this.add_Button.Location = new System.Drawing.Point(27, 36);
            this.add_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.add_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_Button.Name = "add_Button";
            this.add_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.add_Button.Size = new System.Drawing.Size(137, 44);
            this.add_Button.TabIndex = 37;
            this.add_Button.Text = "Thêm";
            this.add_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.add_Button.UseAccentColor = false;
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "VNĐ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.searchName_Box);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.productData);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(677, 727);
            this.panel4.TabIndex = 3;
            // 
            // searchName_Box
            // 
            this.searchName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchName_Box.AnimateReadOnly = false;
            this.searchName_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchName_Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchName_Box.Depth = 0;
            this.searchName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchName_Box.HideSelection = true;
            this.searchName_Box.LeadingIcon = null;
            this.searchName_Box.Location = new System.Drawing.Point(11, 613);
            this.searchName_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchName_Box.MaxLength = 32767;
            this.searchName_Box.MouseState = MaterialSkin.MouseState.OUT;
            this.searchName_Box.Name = "searchName_Box";
            this.searchName_Box.PasswordChar = '\0';
            this.searchName_Box.PrefixSuffixText = null;
            this.searchName_Box.ReadOnly = false;
            this.searchName_Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchName_Box.SelectedText = "";
            this.searchName_Box.SelectionLength = 0;
            this.searchName_Box.SelectionStart = 0;
            this.searchName_Box.ShortcutsEnabled = true;
            this.searchName_Box.Size = new System.Drawing.Size(667, 48);
            this.searchName_Box.TabIndex = 28;
            this.searchName_Box.TabStop = false;
            this.searchName_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchName_Box.TrailingIcon = null;
            this.searchName_Box.UseSystemPasswordChar = false;
            this.searchName_Box.TextChanged += new System.EventHandler(this.searchName_Box_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "Danh sách sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.productData.Location = new System.Drawing.Point(11, 44);
            this.productData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productData.Name = "productData";
            this.productData.RowHeadersWidth = 51;
            this.productData.RowTemplate.Height = 70;
            this.productData.Size = new System.Drawing.Size(652, 489);
            this.productData.TabIndex = 16;
            this.productData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productData_CellContentClick);
            this.productData.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productData_ColumnHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tìm theo tên sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 727);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductManage";
            this.Text = "ProductManage";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox productID_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox productImg;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton cancel_Button;
        private MaterialSkin.Controls.MaterialButton update_Button;
        private MaterialSkin.Controls.MaterialButton remove_Button;
        private MaterialSkin.Controls.MaterialButton add_Button;
        private MaterialSkin.Controls.MaterialTextBox2 searchName_Box;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}