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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tx_findAcc = new System.Windows.Forms.TextBox();
            this.addAccount = new System.Windows.Forms.Button();
            this.accData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.accData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 485);
            this.panel1.TabIndex = 12;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(610, 446);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(2);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(83, 38);
            this.bt_delete.TabIndex = 11;
            this.bt_delete.Text = "- Xoá";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tx_findAcc
            // 
            this.tx_findAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_findAcc.Location = new System.Drawing.Point(522, 10);
            this.tx_findAcc.Margin = new System.Windows.Forms.Padding(2);
            this.tx_findAcc.Name = "tx_findAcc";
            this.tx_findAcc.Size = new System.Drawing.Size(171, 28);
            this.tx_findAcc.TabIndex = 9;
            this.tx_findAcc.TextChanged += new System.EventHandler(this.tx_findAcc_TextChanged);
            // 
            // addAccount
            // 
            this.addAccount.Location = new System.Drawing.Point(522, 446);
            this.addAccount.Margin = new System.Windows.Forms.Padding(2);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(83, 38);
            this.addAccount.TabIndex = 8;
            this.addAccount.Text = "+ Thêm";
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // accData
            // 
            this.accData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accData.Location = new System.Drawing.Point(11, 42);
            this.accData.Margin = new System.Windows.Forms.Padding(2);
            this.accData.Name = "accData";
            this.accData.RowHeadersWidth = 51;
            this.accData.RowTemplate.Height = 24;
            this.accData.Size = new System.Drawing.Size(682, 400);
            this.accData.TabIndex = 7;
            // 
            // AccountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.tx_findAcc);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.accData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountManage";
            this.Text = "AccountManage";
            ((System.ComponentModel.ISupportInitialize)(this.accData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox tx_findAcc;
        private System.Windows.Forms.Button addAccount;
        private System.Windows.Forms.DataGridView accData;
    }
}