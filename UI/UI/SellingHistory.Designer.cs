namespace UI
{
    partial class SellingHistory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_exportCSV = new MaterialSkin.Controls.MaterialButton();
            this.bt_deleteHoaDona = new MaterialSkin.Controls.MaterialButton();
            this.bt_Refresh = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(112, 540);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 543);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm:";
            // 
            // bt_exportCSV
            // 
            this.bt_exportCSV.AutoSize = false;
            this.bt_exportCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_exportCSV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_exportCSV.Depth = 0;
            this.bt_exportCSV.HighEmphasis = true;
            this.bt_exportCSV.Icon = null;
            this.bt_exportCSV.Location = new System.Drawing.Point(476, 540);
            this.bt_exportCSV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_exportCSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_exportCSV.Name = "bt_exportCSV";
            this.bt_exportCSV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_exportCSV.Size = new System.Drawing.Size(97, 36);
            this.bt_exportCSV.TabIndex = 8;
            this.bt_exportCSV.Text = "Xuất File";
            this.bt_exportCSV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_exportCSV.UseAccentColor = false;
            this.bt_exportCSV.UseVisualStyleBackColor = true;
            this.bt_exportCSV.Click += new System.EventHandler(this.bt_exportCSV_Click);
            // 
            // bt_deleteHoaDona
            // 
            this.bt_deleteHoaDona.AutoSize = false;
            this.bt_deleteHoaDona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_deleteHoaDona.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_deleteHoaDona.Depth = 0;
            this.bt_deleteHoaDona.HighEmphasis = true;
            this.bt_deleteHoaDona.Icon = null;
            this.bt_deleteHoaDona.Location = new System.Drawing.Point(581, 540);
            this.bt_deleteHoaDona.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_deleteHoaDona.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_deleteHoaDona.Name = "bt_deleteHoaDona";
            this.bt_deleteHoaDona.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_deleteHoaDona.Size = new System.Drawing.Size(97, 36);
            this.bt_deleteHoaDona.TabIndex = 9;
            this.bt_deleteHoaDona.Text = "Xoá hoá đơn";
            this.bt_deleteHoaDona.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_deleteHoaDona.UseAccentColor = false;
            this.bt_deleteHoaDona.UseVisualStyleBackColor = true;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.AutoSize = false;
            this.bt_Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Refresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Refresh.Depth = 0;
            this.bt_Refresh.HighEmphasis = true;
            this.bt_Refresh.Icon = null;
            this.bt_Refresh.Location = new System.Drawing.Point(686, 540);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Refresh.Size = new System.Drawing.Size(97, 36);
            this.bt_Refresh.TabIndex = 10;
            this.bt_Refresh.Text = "Làm mới";
            this.bt_Refresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Refresh.UseAccentColor = false;
            this.bt_Refresh.UseVisualStyleBackColor = true;
            this.bt_Refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 591);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_deleteHoaDona);
            this.Controls.Add(this.bt_exportCSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SellingHistory";
            this.Text = "SellingHistory";
            this.Load += new System.EventHandler(this.SellingHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton bt_exportCSV;
        private MaterialSkin.Controls.MaterialButton bt_deleteHoaDona;
        private MaterialSkin.Controls.MaterialButton bt_Refresh;
    }
}