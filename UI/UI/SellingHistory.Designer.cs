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
            this.bt_exportCSV = new MaterialSkin.Controls.MaterialButton();
            this.bt_Refresh = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 582);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // bt_exportCSV
            // 
            this.bt_exportCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exportCSV.AutoSize = false;
            this.bt_exportCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_exportCSV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_exportCSV.Depth = 0;
            this.bt_exportCSV.HighEmphasis = true;
            this.bt_exportCSV.Icon = null;
            this.bt_exportCSV.Location = new System.Drawing.Point(725, 22);
            this.bt_exportCSV.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.bt_exportCSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_exportCSV.Name = "bt_exportCSV";
            this.bt_exportCSV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_exportCSV.Size = new System.Drawing.Size(129, 44);
            this.bt_exportCSV.TabIndex = 8;
            this.bt_exportCSV.Text = "Xuất File";
            this.bt_exportCSV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_exportCSV.UseAccentColor = false;
            this.bt_exportCSV.UseVisualStyleBackColor = true;
            this.bt_exportCSV.Click += new System.EventHandler(this.bt_exportCSV_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Refresh.AutoSize = false;
            this.bt_Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Refresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Refresh.Depth = 0;
            this.bt_Refresh.HighEmphasis = true;
            this.bt_Refresh.Icon = null;
            this.bt_Refresh.Location = new System.Drawing.Point(903, 22);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.bt_Refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Refresh.Size = new System.Drawing.Size(129, 44);
            this.bt_Refresh.TabIndex = 10;
            this.bt_Refresh.Text = "Làm mới";
            this.bt_Refresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Refresh.UseAccentColor = false;
            this.bt_Refresh.UseVisualStyleBackColor = true;
            this.bt_Refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.bt_Refresh);
            this.panel1.Controls.Add(this.bt_exportCSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 635);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 92);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::UI.Properties.Resources.search45;
            this.label5.Location = new System.Drawing.Point(24, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 59);
            this.label5.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.AnimateReadOnly = false;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Depth = 0;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.LeadingIcon = null;
            this.textBox1.Location = new System.Drawing.Point(96, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 50;
            this.textBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(437, 50);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "";
            this.textBox1.TrailingIcon = null;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 635);
            this.panel2.TabIndex = 12;
            // 
            // SellingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SellingHistory";
            this.Text = "SellingHistory";
            this.Load += new System.EventHandler(this.SellingHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton bt_exportCSV;
        private MaterialSkin.Controls.MaterialButton bt_Refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}