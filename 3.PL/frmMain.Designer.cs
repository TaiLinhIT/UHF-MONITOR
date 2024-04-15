namespace RFID_MONITOR_CLONE
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbb_Language = new ComboBox();
            cbb_ViewType = new ComboBox();
            cbb_station = new ComboBox();
            lb_SelectDisplay = new Label();
            lb_Station = new Label();
            label3 = new Label();
            btn_start = new Button();
            gb_function = new GroupBox();
            gb_function.SuspendLayout();
            SuspendLayout();
            // 
            // cbb_Language
            // 
            cbb_Language.BackColor = Color.White;
            cbb_Language.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_Language.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_Language.FormattingEnabled = true;
            cbb_Language.Items.AddRange(new object[] { "Tiếng Việt", "English", "中文繁體", "ភាសាកម្ពុជា" });
            cbb_Language.Location = new Point(6, 67);
            cbb_Language.Name = "cbb_Language";
            cbb_Language.Size = new Size(256, 38);
            cbb_Language.TabIndex = 0;
            cbb_Language.SelectedIndexChanged += cbb_Language_SelectedIndexChanged;
            // 
            // cbb_ViewType
            // 
            cbb_ViewType.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_ViewType.FormattingEnabled = true;
            cbb_ViewType.Location = new Point(15, 165);
            cbb_ViewType.Name = "cbb_ViewType";
            cbb_ViewType.Size = new Size(247, 38);
            cbb_ViewType.TabIndex = 1;
            cbb_ViewType.SelectedIndexChanged += cbb_ViewType_SelectedIndexChanged;
            // 
            // cbb_station
            // 
            cbb_station.DropDownHeight = 100;
            cbb_station.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_station.FormattingEnabled = true;
            cbb_station.IntegralHeight = false;
            cbb_station.Location = new Point(15, 253);
            cbb_station.Name = "cbb_station";
            cbb_station.Size = new Size(247, 38);
            cbb_station.TabIndex = 2;
            cbb_station.Text = " ";
            // 
            // lb_SelectDisplay
            // 
            lb_SelectDisplay.AutoSize = true;
            lb_SelectDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_SelectDisplay.Location = new Point(15, 123);
            lb_SelectDisplay.Name = "lb_SelectDisplay";
            lb_SelectDisplay.Size = new Size(172, 32);
            lb_SelectDisplay.TabIndex = 3;
            lb_SelectDisplay.Text = "Select Display";
            lb_SelectDisplay.Click += lb_SelectDisplay_Click;
            // 
            // lb_Station
            // 
            lb_Station.AutoSize = true;
            lb_Station.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Station.Location = new Point(15, 206);
            lb_Station.Name = "lb_Station";
            lb_Station.Size = new Size(94, 32);
            lb_Station.TabIndex = 4;
            lb_Station.Text = "Station";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 32);
            label3.Name = "label3";
            label3.Size = new Size(199, 32);
            label3.TabIndex = 6;
            label3.Text = "Select Language";
            // 
            // btn_start
            // 
            btn_start.Location = new Point(80, 306);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(107, 52);
            btn_start.TabIndex = 7;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            btn_start.MouseDown += btn_start_MouseDown;
            btn_start.MouseEnter += btn_start_MouseEnter;
            btn_start.MouseLeave += btn_start_MouseLeave;
            btn_start.MouseHover += btn_start_MouseHover;
            btn_start.MouseUp += btn_start_MouseUp;
            // 
            // gb_function
            // 
            gb_function.Controls.Add(cbb_ViewType);
            gb_function.Controls.Add(label3);
            gb_function.Controls.Add(btn_start);
            gb_function.Controls.Add(cbb_Language);
            gb_function.Controls.Add(cbb_station);
            gb_function.Controls.Add(lb_SelectDisplay);
            gb_function.Controls.Add(lb_Station);
            gb_function.Location = new Point(50, 46);
            gb_function.Name = "gb_function";
            gb_function.Size = new Size(281, 373);
            gb_function.TabIndex = 8;
            gb_function.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(380, 466);
            Controls.Add(gb_function);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMain_Load;
            gb_function.ResumeLayout(false);
            gb_function.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbb_Language;
        private ComboBox cbb_ViewType;
        private ComboBox cbb_station;
        private Label lb_SelectDisplay;
        private Label lb_Station;
        private Label label3;
        private Button btn_start;
        private GroupBox gb_function;
    }
}
