using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RFID_MONITOR_CLONE._1_DAL.Models;

public partial class DvDataLakeContext : DbContext
{
    public DvDataLakeContext()
    {
    }

    public DvDataLakeContext(DbContextOptions<DvDataLakeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DvRfidreader> DvRfidreaders { get; set; }

    public virtual DbSet<DvRfidrecordmst> DvRfidrecordmsts { get; set; }

    public virtual DbSet<DvRfidrecordmstCust> DvRfidrecordmstCusts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.30.0.21;Database=DV_DATA_LAKE;TrustServerCertificate=True;User ID=sa;Password=greenland@VN;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DvRfidreader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dv_rfidreader_keyid");

            entity.ToTable("dv_rfidreader");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CofactoryCode)
                .HasMaxLength(20)
                .HasColumnName("cofactory_code");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(10)
                .HasColumnName("dept_code");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .HasColumnName("dept_name");
            entity.Property(e => e.DeviceAnt)
                .HasMaxLength(255)
                .HasColumnName("device_ant");
            entity.Property(e => e.DeviceName)
                .HasMaxLength(500)
                .HasColumnName("device_name");
            entity.Property(e => e.DeviceSn)
                .HasMaxLength(255)
                .HasColumnName("device_sn");
            entity.Property(e => e.English).HasMaxLength(1000);
            entity.Property(e => e.FC)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("F_C");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(200)
                .HasColumnName("ip_address");
            entity.Property(e => e.IpPort)
                .HasMaxLength(10)
                .HasColumnName("ip_port");
            entity.Property(e => e.Isactive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("isactive");
            entity.Property(e => e.Khmer).HasMaxLength(1000);
            entity.Property(e => e.Remark)
                .HasColumnType("ntext")
                .HasColumnName("remark");
            entity.Property(e => e.SimplifiedChinese).HasMaxLength(1000);
            entity.Property(e => e.State)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("state");
            entity.Property(e => e.TraditionalChinese).HasMaxLength(1000);
            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasColumnName("updated");
            entity.Property(e => e.UserCodeCreated)
                .HasMaxLength(20)
                .HasColumnName("user_code_created");
            entity.Property(e => e.UserCodeUpdated)
                .HasMaxLength(20)
                .HasColumnName("user_code_updated");
            entity.Property(e => e.UserNameCreated)
                .HasMaxLength(50)
                .HasColumnName("user_name_created");
            entity.Property(e => e.UserNameUpdated)
                .HasMaxLength(50)
                .HasColumnName("user_name_updated");
            entity.Property(e => e.Vietnamese).HasMaxLength(1000);
        });

        modelBuilder.Entity<DvRfidrecordmst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dv_RFIDrecordmst");

            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.EpcCode)
                .HasMaxLength(50)
                .HasColumnName("EPC_Code");
            entity.Property(e => e.FcServerCode)
                .HasMaxLength(20)
                .HasColumnName("FC_server_code");
            entity.Property(e => e.Isactive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("isactive");
            entity.Property(e => e.Keyid)
                .ValueGeneratedOnAdd()
                .HasColumnName("keyid");
            entity.Property(e => e.MoNo)
                .HasMaxLength(100)
                .HasColumnName("mo_no");
            entity.Property(e => e.RecordTime)
                .HasColumnType("datetime")
                .HasColumnName("record_time");
            entity.Property(e => e.Remark)
                .HasColumnType("ntext")
                .HasColumnName("remark");
            entity.Property(e => e.StationNo)
                .HasMaxLength(20)
                .HasColumnName("stationNO");
            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasColumnName("updated");
            entity.Property(e => e.UserCodeCreated)
                .HasMaxLength(20)
                .HasColumnName("user_code_created");
            entity.Property(e => e.UserCodeUpdated)
                .HasMaxLength(20)
                .HasColumnName("user_code_updated");
            entity.Property(e => e.UserNameCreated)
                .HasMaxLength(50)
                .HasColumnName("user_name_created");
            entity.Property(e => e.UserNameUpdated)
                .HasMaxLength(50)
                .HasColumnName("user_name_updated");
        });

        modelBuilder.Entity<DvRfidrecordmstCust>(entity =>
        {
            entity.HasKey(e => e.Keyid).HasName("PK_dv_RFIDrecordmst_keyid_copy1");

            entity.ToTable("dv_RFIDrecordmst_cust");

            entity.Property(e => e.Keyid).HasColumnName("keyid");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.EpcCode)
                .HasMaxLength(50)
                .HasColumnName("EPC_Code");
            entity.Property(e => e.FcServerCode)
                .HasMaxLength(20)
                .HasColumnName("FC_server_code");
            entity.Property(e => e.Isactive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y")
                .IsFixedLength()
                .HasColumnName("isactive");
            entity.Property(e => e.MoNo)
                .HasMaxLength(100)
                .HasColumnName("mo_no");
            entity.Property(e => e.RecordTime)
                .HasColumnType("datetime")
                .HasColumnName("record_time");
            entity.Property(e => e.Remark)
                .HasColumnType("ntext")
                .HasColumnName("remark");
            entity.Property(e => e.StationNo)
                .HasMaxLength(20)
                .HasColumnName("stationNO");
            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasColumnName("updated");
            entity.Property(e => e.UserCodeCreated)
                .HasMaxLength(20)
                .HasColumnName("user_code_created");
            entity.Property(e => e.UserCodeUpdated)
                .HasMaxLength(20)
                .HasColumnName("user_code_updated");
            entity.Property(e => e.UserNameCreated)
                .HasMaxLength(50)
                .HasColumnName("user_name_created");
            entity.Property(e => e.UserNameUpdated)
                .HasMaxLength(50)
                .HasColumnName("user_name_updated");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
