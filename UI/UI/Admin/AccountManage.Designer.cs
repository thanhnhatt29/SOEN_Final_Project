namespace UI.Admin
{
    partial class AccountManage
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
            this.accData = new System.Windows.Forms.DataGridView();
            this.addAccount = new MaterialSkin.Controls.MaterialButton();
            this.bt_Delele = new MaterialSkin.Controls.MaterialButton();
            this.tx_findAcc = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_capquyen = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accData
            // 
            this.accData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accData.Location = new System.Drawing.Point(18, 11);
            this.accData.Margin = new System.Windows.Forms.Padding(2);
            this.accData.Name = "accData";
            this.accData.RowHeadersWidth = 51;
            this.accData.RowTemplate.Height = 24;
            this.accData.Size = new System.Drawing.Size(766, 475);
            this.accData.TabIndex = 7;
            this.accData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.accData_CellMouseClick);
            // 
            // addAccount
            // 
            this.addAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAccount.AutoSize = false;
            this.addAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addAccount.Depth = 0;
            this.addAccount.HighEmphasis = true;
            this.addAccount.Icon = null;
            this.addAccount.Location = new System.Drawing.Point(558, 26);
            this.addAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.addAccount.Name = "addAccount";
            this.addAccount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addAccount.Size = new System.Drawing.Size(105, 36);
            this.addAccount.TabIndex = 13;
            this.addAccount.Text = "Thêm";
            this.addAccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addAccount.UseAccentColor = false;
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // bt_Delele
            // 
            this.bt_Delele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Delele.AutoSize = false;
            this.bt_Delele.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Delele.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Delele.Depth = 0;
            this.bt_Delele.HighEmphasis = true;
            this.bt_Delele.Icon = null;
            this.bt_Delele.Location = new System.Drawing.Point(669, 26);
            this.bt_Delele.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Delele.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Delele.Name = "bt_Delele";
            this.bt_Delele.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Delele.Size = new System.Drawing.Size(105, 36);
            this.bt_Delele.TabIndex = 14;
            this.bt_Delele.Text = "Xoá";
            this.bt_Delele.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Delele.UseAccentColor = true;
            this.bt_Delele.UseVisualStyleBackColor = true;
            this.bt_Delele.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tx_findAcc
            // 
            this.tx_findAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tx_findAcc.AnimateReadOnly = false;
            this.tx_findAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_findAcc.Depth = 0;
            this.tx_findAcc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tx_findAcc.LeadingIcon = null;
            this.tx_findAcc.Location = new System.Drawing.Point(72, 19);
            this.tx_findAcc.MaxLength = 50;
            this.tx_findAcc.MouseState = MaterialSkin.MouseState.OUT;
            this.tx_findAcc.Multiline = false;
            this.tx_findAcc.Name = "tx_findAcc";
            this.tx_findAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tx_findAcc.Size = new System.Drawing.Size(328, 50);
            this.tx_findAcc.TabIndex = 16;
            this.tx_findAcc.Text = "";
            this.tx_findAcc.TrailingIcon = null;
            this.tx_findAcc.TextChanged += new System.EventHandler(this.tx_findAcc_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.accData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 591);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_capquyen);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tx_findAcc);
            this.panel2.Controls.Add(this.bt_Delele);
            this.panel2.Controls.Add(this.addAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 86);
            this.panel2.TabIndex = 18;
            // 
            // bt_capquyen
            // 
            this.bt_capquyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_capquyen.AutoSize = false;
            this.bt_capquyen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_capquyen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_capquyen.Depth = 0;
            this.bt_capquyen.HighEmphasis = true;
            this.bt_capquyen.Icon = null;
            this.bt_capquyen.Location = new System.Drawing.Point(445, 26);
            this.bt_capquyen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_capquyen.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_capquyen.Name = "bt_capquyen";
            this.bt_capquyen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_capquyen.Size = new System.Drawing.Size(105, 36);
            this.bt_capquyen.TabIndex = 22;
            this.bt_capquyen.Text = "Cấp Quyền";
            this.bt_capquyen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_capquyen.UseAccentColor = false;
            this.bt_capquyen.UseVisualStyleBackColor = true;
            this.bt_capquyen.Click += new System.EventHandler(this.bt_capquyen_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("#LQC01 Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::UI.Properties.Resources.search45;
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 48);
            this.label5.TabIndex = 21;
            // 
            // AccountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountManage";
            this.Text = "AccountManage";
            ((System.ComponentModel.ISupportInitialize)(this.accData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView accData;
        private MaterialSkin.Controls.MaterialButton addAccount;
        private MaterialSkin.Controls.MaterialButton bt_Delele;
        private MaterialSkin.Controls.MaterialTextBox tx_findAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton bt_capquyen;
    }
}