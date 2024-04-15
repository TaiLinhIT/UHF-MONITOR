using System;
using System.Collections.Generic;

namespace RFID_MONITOR_CLONE._1_DAL.Models;

public partial class DvRfidrecordmst
{
    public int Keyid { get; set; }

    public string Isactive { get; set; } = null!;

    public DateTime Created { get; set; }

    public string? UserCodeCreated { get; set; }

    public string? UserNameCreated { get; set; }

    public DateTime? Updated { get; set; }

    public string? UserCodeUpdated { get; set; }

    public string? UserNameUpdated { get; set; }

    public string StationNo { get; set; } = null!;

    public DateTime? RecordTime { get; set; }

    public string? MoNo { get; set; }

    public string EpcCode { get; set; } = null!;

    public string? FcServerCode { get; set; }

    public string? Remark { get; set; }
}
