namespace RFID_MONITOR_CLONE._3.PL
{
    partial class frmTotal
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
            flpnl_ShowAll = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpnl_ShowAll
            // 
            flpnl_ShowAll.Location = new Point(2, 2);
            flpnl_ShowAll.Name = "flpnl_ShowAll";
            flpnl_ShowAll.Size = new Size(1528, 805);
            flpnl_ShowAll.TabIndex = 0;
            // 
            // frmTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1564, 819);
            Controls.Add(flpnl_ShowAll);
            Name = "frmTotal";
            Load += frmTotal_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpnl_ShowAll;
    }
}