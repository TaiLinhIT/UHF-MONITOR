using RFID_MONITOR_CLONE._1_DAL.Models;
using RFID_MONITOR_CLONE._2.BUS.IService;
using RFID_MONITOR_CLONE._2.BUS.Service;

namespace RFID_MONITOR_CLONE._3.PL
{
    public partial class frmTotal : Form
    {
        private VScrollBar vScrollBar;
        private string _factory;
        private List<Station> _lstStation;
        private string selectLanguage;
        private IStationService _iStationService;
        private IDuplicateCountService _iDuplicateCountService;
        private IEPCCountService _iEPCCountService;
        public frmTotal(string factory)
        {
            this.WindowState = FormWindowState.Maximized;
            _iStationService = new StationService();
            _iDuplicateCountService = new DuplicateCountService();
            _iEPCCountService = new EPCCountService();
            InitializeComponent();
            InitializeScrollBar();
            _factory = factory;
            selectLanguage = Properties.Settings.Default.Language;
            this.Icon = new Icon("D:\\Linh\\RFID_MONITOR_CLONE\\RFID_MONITOR_CLONE\\Monitor.ico");

        }

        private void frmTotal_Load(object sender, EventArgs e)
        {
            //Task.Run(async () => await LoadScreen(_factory));
            LoadScreen(_factory);
        }
        private void InitializeScrollBar()
        {
            vScrollBar = new VScrollBar();
            vScrollBar.Dock = DockStyle.Right;
            vScrollBar.Scroll += VScrollBar_Scroll;
            flpnl_ShowAll.AutoScroll = true;
            flpnl_ShowAll.Dock = DockStyle.Fill;
            flpnl_ShowAll.Controls.Add(vScrollBar);
        }
        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

            flpnl_ShowAll.VerticalScroll.Value = vScrollBar.Value;
        }

        void LoadScreen(string factory_code)
        {
            flpnl_ShowAll.Controls.Clear();
            vScrollBar.Value = 0;
            _lstStation = new List<Station>();
            if (string.IsNullOrEmpty(factory_code))
            {
                _lstStation = _iStationService.GetAll().ToList();
            }
            else
            {
                _lstStation = _iStationService.GetByFactory(factory_code).ToList();
            }
            int count = _lstStation.Count;
            if (_lstStation.Count > 0)
            {
                List<DuplicateCount> countDup = new List<DuplicateCount>();
                List<CountEPC> countEpc = new List<CountEPC>();
                for (int i = 0; i < _lstStation.Count; i++)
                {
                    string station = _lstStation[i].DeviceName.ToString();
                    if (station.Contains("CUS"))
                    {
                        countDup = _iDuplicateCountService.GetDuplicateOfCusStationOndate(station);
                        countEpc = _iEPCCountService.GetEPCOfCusStationOndate(station);
                    }
                    else
                    {
                        countDup = _iDuplicateCountService.GetDuplicateStationOndate(station);
                        countEpc = _iEPCCountService.GetEPCStationOndate(station);
                    }
                    string stationName;
                    switch (selectLanguage)
                    {
                        case "0":
                            if (_lstStation[i] != null && _lstStation[i].Vietnamese != null)
                            {
                                stationName = _lstStation[i].Vietnamese.ToString();
                            }
                            else
                            {
                                stationName = station;
                            }

                            break;
                        case "1":
                            if (_lstStation[i] != null && _lstStation[i].English != null)
                            {
                                stationName = _lstStation[i].English.ToString();
                            }
                            else
                            {
                                stationName = station;
                            }
                            break;
                        case "2":
                            if (_lstStation[i] != null && _lstStation[i].Simplified != null)
                            {
                                stationName = _lstStation[i].Simplified.ToString();
                            }
                            else
                            {
                                stationName = station;
                            }
                            break;
                        case "3":
                            if (_lstStation[i] != null && _lstStation[i].Khmer != null)
                            {
                                stationName = _lstStation[i].Khmer.ToString();
                            }
                            else
                            {
                                stationName = station;
                            }
                            break;
                        default:
                            if (_lstStation[i] != null && _lstStation[i].Vietnamese != null)
                            {
                                stationName = _lstStation[i].Vietnamese.ToString();
                            }
                            else
                            {
                                stationName = station;
                            }
                            break;
                    }
                    Panel pn = new Panel();

                    if (countDup.Count > 0)
                    {
                        pn = CreatePanel(stationName, countEpc[0].CountOnDay.ToString(), !string.IsNullOrEmpty(countDup[0].Count.ToString()) ? countDup[0].Count.ToString() : "0", station);
                    }
                    else
                    {
                        pn = CreatePanel(stationName, countEpc[0].CountOnDay.ToString(), "0", station);
                    }
                    flpnl_ShowAll.Controls.Add(pn);

                }

            }
            else
            {
                Label n = new Label();
                n.Text = "NO DATA !";
                n.Font = new Font("Arial", 55, FontStyle.Bold);
                n.Dock = DockStyle.Top;
                n.TextAlign = ContentAlignment.MiddleCenter;
                n.AutoSize = true;
                flpnl_ShowAll.Controls.Add(n);
            }

            // Tính toán giá trị tối đa cho thanh cuộn
            int maxValue = flpnl_ShowAll.VerticalScroll.Maximum;
            vScrollBar.Maximum = maxValue;

            // Hiển thị thanh cuộn nếu cần thiết
            vScrollBar.Visible = maxValue > 0;

            flpnl_ShowAll.AutoScroll = true;

        }
        private Panel CreatePanel(string station, string countOnday, string duplicateOnDay, string deviceCode)
        {
            Panel newPanel = new Panel();
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            //newPanel.Padding = new Padding(10);
            newPanel.Margin = new Padding(2);
            newPanel.BackColor = System.Drawing.Color.White;
            newPanel.Width = 370;
            newPanel.Height = 300;

            Label lblStation = new Label();
            lblStation.Text = station;
            lblStation.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            lblStation.Dock = DockStyle.Top;
            lblStation.Padding = new Padding(0, 0, 0, 0);
            //lblStation.AutoSize = true;
            lblStation.TextAlign = ContentAlignment.TopCenter;
            lblStation.AutoEllipsis = true;
            lblStation.Height = (int)Math.Ceiling(lblStation.CreateGraphics().MeasureString(lblStation.Text, lblStation.Font).Height);




            TableLayoutPanel tblp = new TableLayoutPanel();
            tblp.Dock = DockStyle.Fill;

            // Thiết lập 2 cột và 2 dòng
            tblp.ColumnCount = 2;
            tblp.RowCount = 2;

            // Thiết lập tỷ lệ kích thước của các cột và dòng
            tblp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tblp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tblp.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            tblp.RowStyles.Add(new RowStyle(SizeType.Percent, 30));

            // Labela và Labelb
            Label labela = new Label();
            labela.Name = deviceCode;
            labela.Text = "Số lượng\nQuantity\n當天讀取數量";
            labela.Dock = DockStyle.Fill;
            labela.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            labela.BackColor = Color.LightBlue;
            labela.TextAlign = ContentAlignment.MiddleCenter;

            Label labelb = new Label();
            labelb.Name = deviceCode;
            labelb.Text = "Trùng lặp\nDuplicate\n重複讀取數量";
            labelb.Dock = DockStyle.Fill;
            labelb.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            labelb.BackColor = Color.LightBlue;
            labelb.TextAlign = ContentAlignment.MiddleCenter;

            // Valuea và Valueb
            Label valuea = new Label();
            valuea.Text = countOnday;
            valuea.Dock = DockStyle.Fill;
            valuea.Font = new System.Drawing.Font("Arial", 40, System.Drawing.FontStyle.Regular);
            valuea.Name = deviceCode;
            valuea.TextAlign = ContentAlignment.MiddleCenter;

            Label valueb = new Label();
            valueb.Text = duplicateOnDay;
            valueb.Dock = DockStyle.Fill;
            valueb.Font = new System.Drawing.Font("Arial", 40, System.Drawing.FontStyle.Regular);
            valueb.ForeColor = Color.Red;
            valueb.Name = deviceCode;
            valueb.TextAlign = ContentAlignment.MiddleCenter;

            // Thêm các controls vào TableLayoutPanel
            tblp.Controls.Add(labela, 0, 0);
            tblp.Controls.Add(labelb, 1, 0);
            tblp.Controls.Add(valuea, 0, 1);
            tblp.Controls.Add(valueb, 1, 1);

            tblp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblp.Tag = deviceCode;
            tblp.Padding = new Padding(0, 35, 0, 0);


            labela.MouseDoubleClick += Control_DoubleClick;
            labelb.MouseDoubleClick += Control_DoubleClick;
            valuea.MouseDoubleClick += Control_DoubleClick;
            valueb.MouseDoubleClick += Control_DoubleClick;




            newPanel.Controls.Add(tblp);
            newPanel.Controls.Add(lblStation);

            newPanel.DoubleClick += NewPanel_DoubleClick;
            tblp.DoubleClick += Tblp_DoubleClick;
            newPanel.Name = station;
            newPanel.Controls.SetChildIndex(tblp, 1);
            newPanel.Controls.SetChildIndex(lblStation, 0);

            flpnl_ShowAll.FlowDirection = FlowDirection.LeftToRight;
            return newPanel;
        }

        private void Tblp_DoubleClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewPanel_DoubleClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Control_DoubleClick(object? sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
