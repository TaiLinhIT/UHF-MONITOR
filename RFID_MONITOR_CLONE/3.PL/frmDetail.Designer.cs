namespace RFID_MONITOR_CLONE._3.PL
{
    partial class frmDetail
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            comboBox1 = new ComboBox();
            lbl_ShoeStyle_value = new Label();
            dtg_showDetail = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            lbl_shoeStyle = new Label();
            lbl_OrderQuantity = new Label();
            lbl_CountOnDay = new Label();
            lbl_DupOnDay = new Label();
            lbl_OrderQuantity_value = new Label();
            lbl_CountOnDay_value = new Label();
            lbl_Dup_On_Day = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtg_showDetail).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 19);
            label1.Name = "label1";
            label1.Size = new Size(110, 45);
            label1.TabIndex = 0;
            label1.Text = "Mono";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 53);
            comboBox1.TabIndex = 1;
            // 
            // lbl_ShoeStyle_value
            // 
            lbl_ShoeStyle_value.AutoSize = true;
            lbl_ShoeStyle_value.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ShoeStyle_value.Location = new Point(57, 79);
            lbl_ShoeStyle_value.Name = "lbl_ShoeStyle_value";
            lbl_ShoeStyle_value.Size = new Size(108, 45);
            lbl_ShoeStyle_value.TabIndex = 2;
            lbl_ShoeStyle_value.Text = "Value";
            // 
            // dtg_showDetail
            // 
            dtg_showDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_showDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtg_showDetail.BackgroundColor = Color.White;
            dtg_showDetail.BorderStyle = BorderStyle.None;
            dtg_showDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_showDetail.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dtg_showDetail.GridColor = Color.Black;
            dtg_showDetail.Location = new Point(28, 162);
            dtg_showDetail.Name = "dtg_showDetail";
            dtg_showDetail.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_showDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_showDetail.Size = new Size(1420, 618);
            dtg_showDetail.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "EPC";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "SIZE";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "MONO";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // lbl_shoeStyle
            // 
            lbl_shoeStyle.AutoSize = true;
            lbl_shoeStyle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_shoeStyle.Location = new Point(46, 19);
            lbl_shoeStyle.Name = "lbl_shoeStyle";
            lbl_shoeStyle.Size = new Size(175, 45);
            lbl_shoeStyle.TabIndex = 4;
            lbl_shoeStyle.Text = "Shoe Style";
            // 
            // lbl_OrderQuantity
            // 
            lbl_OrderQuantity.AutoSize = true;
            lbl_OrderQuantity.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_OrderQuantity.Location = new Point(18, 19);
            lbl_OrderQuantity.Name = "lbl_OrderQuantity";
            lbl_OrderQuantity.Size = new Size(245, 45);
            lbl_OrderQuantity.TabIndex = 5;
            lbl_OrderQuantity.Text = "Order Quantity";
            // 
            // lbl_CountOnDay
            // 
            lbl_CountOnDay.AutoSize = true;
            lbl_CountOnDay.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CountOnDay.Location = new Point(34, 19);
            lbl_CountOnDay.Name = "lbl_CountOnDay";
            lbl_CountOnDay.Size = new Size(229, 45);
            lbl_CountOnDay.TabIndex = 6;
            lbl_CountOnDay.Text = "Count On Day";
            // 
            // lbl_DupOnDay
            // 
            lbl_DupOnDay.AutoSize = true;
            lbl_DupOnDay.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DupOnDay.Location = new Point(6, 19);
            lbl_DupOnDay.Name = "lbl_DupOnDay";
            lbl_DupOnDay.Size = new Size(281, 45);
            lbl_DupOnDay.TabIndex = 7;
            lbl_DupOnDay.Text = "Duplicate On Day";
            // 
            // lbl_OrderQuantity_value
            // 
            lbl_OrderQuantity_value.AutoSize = true;
            lbl_OrderQuantity_value.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_OrderQuantity_value.Location = new Point(48, 82);
            lbl_OrderQuantity_value.Name = "lbl_OrderQuantity_value";
            lbl_OrderQuantity_value.Size = new Size(108, 45);
            lbl_OrderQuantity_value.TabIndex = 8;
            lbl_OrderQuantity_value.Text = "Value";
            // 
            // lbl_CountOnDay_value
            // 
            lbl_CountOnDay_value.AutoSize = true;
            lbl_CountOnDay_value.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CountOnDay_value.Location = new Point(49, 82);
            lbl_CountOnDay_value.Name = "lbl_CountOnDay_value";
            lbl_CountOnDay_value.Size = new Size(108, 45);
            lbl_CountOnDay_value.TabIndex = 9;
            lbl_CountOnDay_value.Text = "Value";
            // 
            // lbl_Dup_On_Day
            // 
            lbl_Dup_On_Day.AutoSize = true;
            lbl_Dup_On_Day.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Dup_On_Day.Location = new Point(19, 87);
            lbl_Dup_On_Day.Name = "lbl_Dup_On_Day";
            lbl_Dup_On_Day.Size = new Size(108, 45);
            lbl_Dup_On_Day.TabIndex = 10;
            lbl_Dup_On_Day.Text = "Value";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(28, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 132);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbl_shoeStyle);
            groupBox2.Controls.Add(lbl_ShoeStyle_value);
            groupBox2.Location = new Point(322, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(269, 136);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_OrderQuantity);
            groupBox3.Controls.Add(lbl_OrderQuantity_value);
            groupBox3.Location = new Point(597, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(269, 136);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbl_CountOnDay);
            groupBox4.Controls.Add(lbl_CountOnDay_value);
            groupBox4.Location = new Point(872, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(269, 136);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lbl_DupOnDay);
            groupBox5.Controls.Add(lbl_Dup_On_Day);
            groupBox5.Location = new Point(1147, 20);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(301, 136);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            // 
            // frmDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 809);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtg_showDetail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetail";
            ((System.ComponentModel.ISupportInitialize)dtg_showDetail).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label lbl_ShoeStyle_value;
        private DataGridView dtg_showDetail;
        private Label lbl_shoeStyle;
        private Label lbl_OrderQuantity;
        private Label lbl_CountOnDay;
        private Label lbl_DupOnDay;
        private Label lbl_OrderQuantity_value;
        private Label lbl_CountOnDay_value;
        private Label lbl_Dup_On_Day;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}