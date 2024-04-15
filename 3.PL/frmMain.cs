using RFID_MONITOR_CLONE._1_DAL.Models;
using RFID_MONITOR_CLONE._2.BUS.IService;
using RFID_MONITOR_CLONE._2.BUS.Service;
using RFID_MONITOR_CLONE._3.PL;

namespace RFID_MONITOR_CLONE
{
    public partial class frmMain : Form
    {
        IRfidReaderService _rfidReaderService;
        IFactoryService _ifactoriyService;
        IStationService _istationService;

        public frmMain()
        {
            InitializeComponent();
            _rfidReaderService = new RfidReaderService();
            _ifactoriyService = new FactoryService();
            _istationService = new StationService();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            cbb_Language.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_station.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_ViewType.DropDownStyle = ComboBoxStyle.DropDownList;
            defaultButtonColor = btn_start.BackColor; // Lưu màu mặc định của Button
            lb_Station.Visible = false;
            lb_SelectDisplay.Visible = false;
            cbb_ViewType.Visible = false;
            cbb_station.Visible = false;
        }

        private void cbb_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            var choose = cbb_Language.SelectedIndex;
            LoadCbbViewType(choose);
            Properties.Settings.Default.Language = choose.ToString();

        }
        private void LoadCbbViewType(int item)
        {
            lb_SelectDisplay.Visible = true;
            cbb_ViewType.Visible = true;
            lb_Station.Visible = false;
            cbb_station.Visible = false;
            switch (item)
            {

                case 1:
                    cbb_ViewType.Items.Clear();
                    lb_SelectDisplay.Text = "Select Display";
                    cbb_ViewType.Items.Add("All");
                    cbb_ViewType.Items.Add("Detail");
                    cbb_ViewType.Items.Add("Be factory");
                    btn_start.Text = "Start";

                    break;
                case 0:
                    cbb_ViewType.Items.Clear();
                    lb_SelectDisplay.Text = "Loại Hiển Thị";
                    cbb_ViewType.Items.Add("Tất cả");
                    cbb_ViewType.Items.Add("Chi tiết");
                    cbb_ViewType.Items.Add("Theo xưởng");
                    btn_start.Text = "Bắt Đầu";
                    break;
                case 2:
                    cbb_ViewType.Items.Clear();
                    lb_SelectDisplay.Text = "显示类型";
                    cbb_ViewType.Items.Add("全部");
                    cbb_ViewType.Items.Add("细节");
                    cbb_ViewType.Items.Add("厂别");
                    btn_start.Text = "开始";
                    break;
                case 3:
                    cbb_ViewType.Items.Clear();
                    lb_SelectDisplay.Text = "ប្រភេទបង្ហាញ";
                    cbb_ViewType.Items.Add("ទាំងអស់។");
                    cbb_ViewType.Items.Add("លម្អិត");
                    cbb_ViewType.Items.Add("ជ្រើសរើសរោងចក្រ");
                    btn_start.Text = "លេខ​ម៉ាស៊ីន";
                    lb_Station.Text = "";
                    break;
            }
        }
        private void LoadCbbFactory()
        {
            List<Factory> factories = new List<Factory>()
            {
                new Factory() { factoryName = "GL1-聯盈", factoryCode = "VA1" },
                new Factory() { factoryName = "GL2-聯舜一廠", factoryCode = "VB1" },
                new Factory() { factoryName = "GL3-聯舜二廠", factoryCode = "VB2" },
                new Factory() { factoryName = "GL4-金邊", factoryCode = "CA1" }
            };
            cbb_station.DataSource = null;
            // Xóa bỏ dữ liệu cũ của ComboBox
            cbb_station.Items.Clear();

            // Thêm từng tên nhà máy vào ComboBox
            foreach (Factory factory in factories)
            {
                cbb_station.Items.Add(factory.factoryName);
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cbb_station.SelectedIndex >= 0)
            {
                if (cbb_station.SelectedIndex == 1)
                {
                    frmDetail frmdt = new frmDetail();
                    this.Hide();
                    frmdt.ShowDialog();
                    this.Show();
                }

            }

            else if (cbb_ViewType.SelectedIndex == 0 || cbb_ViewType.SelectedIndex == 2)
            {
                List<Factory> _lstfactory = new List<Factory>();
                string? factory;

                switch (cbb_station.SelectedIndex)
                {
                    case 0:
                        factory = _lstfactory.Where(x => x.factoryCode == "VA1").Select(x => x.factoryName).FirstOrDefault();
                        frmTotal frmt = new frmTotal(factory);
                        this.Hide();
                        frmt.ShowDialog();
                        this.Show();
                        break;
                    case 1:
                        factory = _lstfactory.Where(x => x.factoryCode == "VB1").Select(x => x.factoryName).FirstOrDefault();
                        frmTotal frmtn = new frmTotal(factory);
                        this.Hide();
                        frmtn.ShowDialog();
                        this.Show();
                        break;
                    case 2:
                        factory = _lstfactory.Where(x => x.factoryCode == "VB2").Select(x => x.factoryName).FirstOrDefault();
                        frmTotal frmtnl = new frmTotal(factory);
                        this.Hide();
                        frmtnl.ShowDialog();
                        this.Show();
                        break;
                    case 3:
                        factory = _lstfactory.Where(x => x.factoryCode == "CA1").Select(x => x.factoryName).FirstOrDefault();
                        frmTotal frmtntl = new frmTotal(factory);
                        this.Hide();
                        frmtntl.ShowDialog();
                        this.Show();
                        break;
                    default:
                        factory = null;
                        frmTotal frmtntln = new frmTotal(factory);
                        this.Hide();
                        frmtntln.ShowDialog();
                        this.Show();
                        break;
                }

            }
        }

        private void lb_SelectDisplay_Click(object sender, EventArgs e)
        {

        }

        private void cbb_ViewType_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbb_ViewType.SelectedIndex >= 0)
            {
                if (cbb_ViewType.SelectedIndex == 0)
                {
                    lb_Station.Visible = false;
                    cbb_station.Visible = false;
                }
                else if (cbb_ViewType.SelectedIndex == 1)
                {
                    lb_Station.Visible = true;
                    cbb_station.Visible = true;
                    if (cbb_Language.SelectedIndex == 0)
                    {
                        lb_Station.Text = "Trạm";

                        cbb_station.Items.Clear();

                        var lststation = _istationService.GetAll().Where(x => x.Vietnamese != null).Select(x => x.Vietnamese).ToList();

                        lststation.AddRange(_istationService.GetAll().Where(x => x.DeviceName != null).Select(x => x.DeviceName).ToList());
                        List<Station> _lstStation = new List<Station>();
                        Station station = new Station();
                        foreach (string item in lststation)
                        {
                            station.Vietnamese = item;
                            _lstStation.Add(station);
                        }
                        if (lststation != null && lststation.Any())
                        {
                            foreach (var item in lststation)
                            {
                                cbb_station.Items.Add(item);
                            }
                        }

                    }
                    if (cbb_Language.SelectedIndex == 1)
                    {
                        lb_Station.Text = "Station";
                        cbb_station.Items.Clear();

                        var lststation = _istationService.GetAll().Where(x => x.English != null).Select(x => x.English).ToList();

                        lststation.AddRange(_istationService.GetAll().Where(x => x.DeviceName != null).Select(x => x.DeviceName).ToList());
                        List<Station> _lstStation = new List<Station>();
                        Station station = new Station();
                        foreach (string item in lststation)
                        {
                            station.Vietnamese = item;
                            _lstStation.Add(station);
                        }

                        if (lststation != null && lststation.Any())
                        {
                            foreach (var item in lststation)
                            {
                                cbb_station.Items.Add(item);
                            }
                        }
                    }
                    if (cbb_Language.SelectedIndex == 2)
                    {
                        lb_Station.Text = "站";
                        cbb_station.Items.Clear();

                        var lststation = _istationService.GetAll().Where(x => x.Simplified != null).Select(x => x.Simplified).ToList();
                        List<Station> _lstStation = new List<Station>();
                        Station station = new Station();
                        foreach (string item in lststation)
                        {
                            station.Vietnamese = item;
                            _lstStation.Add(station);
                        }
                        if (lststation != null && lststation.Any())
                        {
                            foreach (var item in lststation)
                            {
                                cbb_station.Items.Add(item);
                            }
                        }

                    }
                    if (cbb_Language.SelectedIndex == 3)
                    {
                        lb_Station.Text = "ចាប់ផ្តើម";
                        cbb_station.Items.Clear();

                        var lststation = _istationService.GetAll().Where(x => x.Khmer != null).Select(x => x.Khmer).ToList();
                        lststation.AddRange(_istationService.GetAll().Where(x => x.DeviceName != null).Select(x => x.DeviceName).ToList());
                        List<Station> _lstStation = new List<Station>();
                        Station station = new Station();
                        foreach (string? item in lststation)
                        {
                            station.Vietnamese = item;
                            _lstStation.Add(station);
                        }

                        if (lststation != null && lststation.Any())
                        {
                            foreach (var item in lststation)
                            {
                                cbb_station.Items.Add(item);
                            }
                        }
                    }
                }
                else if (cbb_ViewType.SelectedIndex == 2)
                {
                    cbb_station.Items.Clear();
                    lb_Station.Visible = true;
                    cbb_station.Visible = true;
                    cbb_station.DataSource = null;
                    cbb_station.DataSource = _ifactoriyService.GetFactories();
                    cbb_station.DisplayMember = "factoryName";
                    if (cbb_Language.SelectedIndex == 0)
                    {
                        lb_Station.Text = "Xưởng";
                    }
                    else if (cbb_Language.SelectedIndex == 1)
                    {
                        lb_Station.Text = "Factory";
                    }
                    else if (cbb_Language.SelectedIndex == 2)
                    {
                        lb_Station.Text = "厂别";
                    }
                    else
                    {
                        lb_Station.Text = "ជ្រើសរើសរោងចក្រ";
                    }
                    LoadCbbFactory();
                }
            }
        }

        private void btn_start_MouseEnter(object sender, EventArgs e)
        {
            //btn_start.BackColor = Color.Red;
        }
        Color defaultButtonColor;

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.BackColor = defaultButtonColor; // Trở lại màu ban đầu
        }

        private void btn_start_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btn_start_MouseUp(object sender, MouseEventArgs e)
        {
            //btn_start.BackColor = Color.Blue;
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.BackColor = Color.Green;
        }
    }
}
