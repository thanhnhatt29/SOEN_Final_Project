namespace UI
{
    partial class Message
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Confirm_bt = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Exit_bt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 49);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG BÁO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Exit_bt
            // 
            this.Exit_bt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Exit_bt.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_bt.ForeColor = System.Drawing.Color.White;
            this.Exit_bt.Location = new System.Drawing.Point(308, 0);
            this.Exit_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.Size = new System.Drawing.Size(56, 47);
            this.Exit_bt.TabIndex = 8;
            this.Exit_bt.Text = "✖️";
            this.Exit_bt.UseVisualStyleBackColor = false;
            this.Exit_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Confirm_bt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 155);
            this.panel1.TabIndex = 4;
            // 
            // Confirm_bt
            // 
            this.Confirm_bt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Confirm_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_bt.ForeColor = System.Drawing.Color.White;
            this.Confirm_bt.Location = new System.Drawing.Point(111, 88);
            this.Confirm_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm_bt.Name = "Confirm_bt";
            this.Confirm_bt.Size = new System.Drawing.Size(151, 47);
            this.Confirm_bt.TabIndex = 9;
            this.Confirm_bt.Text = "OK";
            this.Confirm_bt.UseVisualStyleBackColor = false;
            this.Confirm_bt.Click += new System.EventHandler(this.Confirm_bt_Click);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 204);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Confirm_bt;
    }
}