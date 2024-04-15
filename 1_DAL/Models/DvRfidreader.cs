using System;
using System.Collections.Generic;

namespace RFID_MONITOR_CLONE._1_DAL.Models;

public partial class DvRfidreader
{
    public int Id { get; set; }

    public string Isactive { get; set; } = null!;

    public DateTime Created { get; set; }

    public string? UserCodeCreated { get; set; }

    public string? UserNameCreated { get; set; }

    public DateTime? Updated { get; set; }

    public string? UserCodeUpdated { get; set; }

    public string? UserNameUpdated { get; set; }

    public string? CofactoryCode { get; set; }

    public string? DeviceName { get; set; }

    public string? IpAddress { get; set; }

    public string? TraditionalChinese { get; set; }

    public string? SimplifiedChinese { get; set; }

    public string? Vietnamese { get; set; }

    public string? Khmer { get; set; }

    public string? English { get; set; }

    public string? IpPort { get; set; }

    public string? State { get; set; }

    public string? FC { get; set; }

    public string? DeviceSn { get; set; }

    public string? DeviceAnt { get; set; }

    public string? DeptCode { get; set; }

    public string? DeptName { get; set; }

    public string? Remark { get; set; }
}
