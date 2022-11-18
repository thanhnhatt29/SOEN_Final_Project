namespace UI
{
    partial class DeleteBill
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
            this.bt_deleteByName = new System.Windows.Forms.Button();
            this.bt_deleteByWeek = new System.Windows.Forms.Button();
            this.bt_deleteByMonth = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_deleteByDay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_deleteDataInTable = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xoá theo id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xoá theo tuần:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xoá theo tháng:";
            // 
            // bt_deleteByName
            // 
            this.bt_deleteByName.Location = new System.Drawing.Point(210, 29);
            this.bt_deleteByName.Name = "bt_deleteByName";
            this.bt_deleteByName.Size = new System.Drawing.Size(75, 24);
            this.bt_deleteByName.TabIndex = 3;
            this.bt_deleteByName.Text = "Check";
            this.bt_deleteByName.UseVisualStyleBackColor = true;
            this.bt_deleteByName.Click += new System.EventHandler(this.bt_deleteByName_Click);
            // 
            // bt_deleteByWeek
            // 
            this.bt_deleteByWeek.Location = new System.Drawing.Point(161, 91);
            this.bt_deleteByWeek.Name = "bt_deleteByWeek";
            this.bt_deleteByWeek.Size = new System.Drawing.Size(75, 23);
            this.bt_deleteByWeek.TabIndex = 4;
            this.bt_deleteByWeek.Text = "Check";
            this.bt_deleteByWeek.UseVisualStyleBackColor = true;
            this.bt_deleteByWeek.Click += new System.EventHandler(this.bt_deleteByWeek_Click);
            // 
            // bt_deleteByMonth
            // 
            this.bt_deleteByMonth.Location = new System.Drawing.Point(161, 116);
            this.bt_deleteByMonth.Name = "bt_deleteByMonth";
            this.bt_deleteByMonth.Size = new System.Drawing.Size(75, 23);
            this.bt_deleteByMonth.TabIndex = 5;
            this.bt_deleteByMonth.Text = "Check";
            this.bt_deleteByMonth.UseVisualStyleBackColor = true;
            this.bt_deleteByMonth.Click += new System.EventHandler(this.bt_deleteByMonth_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 22);
            this.textBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_deleteDataInTable);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bt_deleteByDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_deleteByMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bt_deleteByWeek);
            this.groupBox1.Controls.Add(this.bt_deleteByName);
            this.groupBox1.Location = new System.Drawing.Point(417, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Xoá theo ngày:";
            // 
            // bt_deleteByDay
            // 
            this.bt_deleteByDay.Location = new System.Drawing.Point(161, 61);
            this.bt_deleteByDay.Name = "bt_deleteByDay";
            this.bt_deleteByDay.Size = new System.Drawing.Size(75, 23);
            this.bt_deleteByDay.TabIndex = 8;
            this.bt_deleteByDay.Text = "Check";
            this.bt_deleteByDay.UseVisualStyleBackColor = true;
            this.bt_deleteByDay.Click += new System.EventHandler(this.bt_deleteByDay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chú thích";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Xoá theo ngày: Giữ lại hoá đơn mới thêm trong hôm nay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Xoá theo tháng: Giữ lại hoá đơn mới thêm trong 30 ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Xoá theo tuần: Giữ lại hoá đơn mới thêm trong 7 ngày";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 262);
            this.dataGridView1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Danh sách hoá đơn bị xoá";
            // 
            // bt_deleteDataInTable
            // 
            this.bt_deleteDataInTable.Location = new System.Drawing.Point(283, 77);
            this.bt_deleteDataInTable.Name = "bt_deleteDataInTable";
            this.bt_deleteDataInTable.Size = new System.Drawing.Size(75, 50);
            this.bt_deleteDataInTable.TabIndex = 9;
            this.bt_deleteDataInTable.Text = "Xoá dữ liệu";
            this.bt_deleteDataInTable.UseVisualStyleBackColor = true;
            this.bt_deleteDataInTable.Click += new System.EventHandler(this.bt_deleteDataInTable_Click);
            // 
            // DeleteBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteBill";
            this.Text = "DeleteBill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_deleteByName;
        private System.Windows.Forms.Button bt_deleteByWeek;
        private System.Windows.Forms.Button bt_deleteByMonth;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_deleteByDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_deleteDataInTable;
    }
}