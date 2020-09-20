using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCCoreLoginRegister.Data
{
    public partial class JobBagContext : DbContext
    {
        public JobBagContext()
        {
        }

        public JobBagContext(DbContextOptions<JobBagContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QryActiveCavitationRecords> QryActiveCavitationRecords { get; set; }
        public virtual DbSet<QryAuthorisationToRunRecords> QryAuthorisationToRunRecords { get; set; }
        public virtual DbSet<QryCavitationRecordAction> QryCavitationRecordAction { get; set; }
        public virtual DbSet<QryCavitationRecordReason> QryCavitationRecordReason { get; set; }
        public virtual DbSet<QryDataArchiveQuery> QryDataArchiveQuery { get; set; }
        public virtual DbSet<QryFunctionalTestRecords> QryFunctionalTestRecords { get; set; }
        public virtual DbSet<QryLineClearanceRecords> QryLineClearanceRecords { get; set; }
        public virtual DbSet<QryLot> QryLot { get; set; }
        public virtual DbSet<QryMachine> QryMachine { get; set; }
        public virtual DbSet<QryMachineDowntimeRecords> QryMachineDowntimeRecords { get; set; }
        public virtual DbSet<QryMaterialTraceabilityData> QryMaterialTraceabilityData { get; set; }
        public virtual DbSet<QryProduct> QryProduct { get; set; }
        public virtual DbSet<QryProductCheckPointData> QryProductCheckPointData { get; set; }
        public virtual DbSet<QryQualityRecordAction> QryQualityRecordAction { get; set; }
        public virtual DbSet<QryQualityRecordObservation> QryQualityRecordObservation { get; set; }
        public virtual DbSet<QryQualityRecords> QryQualityRecords { get; set; }
        public virtual DbSet<QryTechnology> QryTechnology { get; set; }
        public virtual DbSet<QryUser> QryUser { get; set; }
        public virtual DbSet<TblAuthorisationToRun> TblAuthorisationToRun { get; set; }
        public virtual DbSet<TblCavitationRecord> TblCavitationRecord { get; set; }
        public virtual DbSet<TblCavitationRecordAction> TblCavitationRecordAction { get; set; }
        public virtual DbSet<TblCavitationRecordReason> TblCavitationRecordReason { get; set; }
        public virtual DbSet<TblDataArchiveQuery> TblDataArchiveQuery { get; set; }
        public virtual DbSet<TblFunctionalTest> TblFunctionalTest { get; set; }
        public virtual DbSet<TblFunctionalTestResult> TblFunctionalTestResult { get; set; }
        public virtual DbSet<TblFunctionalTestType> TblFunctionalTestType { get; set; }
        public virtual DbSet<TblLineClearance> TblLineClearance { get; set; }
        public virtual DbSet<TblLot> TblLot { get; set; }
        public virtual DbSet<TblMachine> TblMachine { get; set; }
        public virtual DbSet<TblMachineDowntimeRecord> TblMachineDowntimeRecord { get; set; }
        public virtual DbSet<TblMaterialLotControl> TblMaterialLotControl { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblProductCheckPoint> TblProductCheckPoint { get; set; }
        public virtual DbSet<TblQualityRecord> TblQualityRecord { get; set; }
        public virtual DbSet<TblQualityRecordAction> TblQualityRecordAction { get; set; }
        public virtual DbSet<TblQualityRecordObservation> TblQualityRecordObservation { get; set; }
        public virtual DbSet<TblTechnology> TblTechnology { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(Startup.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QryActiveCavitationRecords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_ActiveCavitationRecords");

                entity.Property(e => e.Action)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CavityId).HasColumnName("CavityID");

                entity.Property(e => e.LotName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PcptimeStamp)
                    .HasColumnName("PCPTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QryAuthorisationToRunRecords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_AuthorisationToRunRecords");

                entity.Property(e => e.AtrtimeStamp)
                    .HasColumnName("ATRTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Qcusername)
                    .HasColumnName("QCUsername")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TechUsername)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QryCavitationRecordAction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_CavitationRecordAction");

                entity.Property(e => e.CavitationRecordAction)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CavitationRecordActionId)
                    .HasColumnName("CavitationRecordActionID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QryCavitationRecordReason>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_CavitationRecordReason");

                entity.Property(e => e.CavitationRecordReason)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CavitationRecordReasonId)
                    .HasColumnName("CavitationRecordReasonID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QryDataArchiveQuery>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_DataArchiveQuery");

                entity.Property(e => e.DataArchiveQuery)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.DataArchiveQueryId)
                    .HasColumnName("DataArchiveQueryID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QryFunctionalTestRecords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_FunctionalTestRecords");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FttimeStamp)
                    .HasColumnName("FTTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TestType)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QryLineClearanceRecords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_LineClearanceRecords");

                entity.Property(e => e.LctimeStamp)
                    .HasColumnName("LCTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Qcusername)
                    .HasColumnName("QCUsername")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TechUsername)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QryLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_Lot");

                entity.Property(e => e.Ca)
                    .HasColumnName("CA")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Caq).HasColumnName("CAQ");

                entity.Property(e => e.Cav).HasColumnName("CAV");

                entity.Property(e => e.Cl)
                    .HasColumnName("CL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Clq).HasColumnName("CLQ");

                entity.Property(e => e.Coa).HasColumnName("COA");

                entity.Property(e => e.Coc).HasColumnName("COC");

                entity.Property(e => e.Col)
                    .HasColumnName("COL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Cph)
                    .HasColumnName("CPH")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Cyc)
                    .HasColumnName("CYC")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Dwg)
                    .HasColumnName("DWG")
                    .IsUnicode(false);

                entity.Property(e => e.Ens).HasColumnName("ENS");

                entity.Property(e => e.Fut).HasColumnName("FUT");

                entity.Property(e => e.Ib)
                    .HasColumnName("IB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ibq).HasColumnName("IBQ");

                entity.Property(e => e.Loh)
                    .HasColumnName("LOH")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Loq)
                    .HasColumnName("LOQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LotId).HasColumnName("LotID");

                entity.Property(e => e.LotName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Mb)
                    .HasColumnName("MB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Mbq).HasColumnName("MBQ");

                entity.Property(e => e.P1)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.P1q).HasColumnName("P1Q");

                entity.Property(e => e.P2)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.P2q).HasColumnName("P2Q");

                entity.Property(e => e.Pa)
                    .HasColumnName("PA")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Paq).HasColumnName("PAQ");

                entity.Property(e => e.Por).HasColumnName("POR");

                entity.Property(e => e.Pps)
                    .HasColumnName("PPS")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Pqis)
                    .HasColumnName("PQIS")
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ps)
                    .HasColumnName("PS")
                    .IsUnicode(false);

                entity.Property(e => e.Rtq).HasColumnName("RTQ");

                entity.Property(e => e.Sa)
                    .HasColumnName("SA")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Saq).HasColumnName("SAQ");

                entity.Property(e => e.Spc).HasColumnName("SPC");

                entity.Property(e => e.Sts).HasColumnName("STS");

                entity.Property(e => e.TechnologyName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Tol)
                    .HasColumnName("TOL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QryMachine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_Machine");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MachineName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TechnologyId).HasColumnName("TechnologyID");
            });

            modelBuilder.Entity<QryMachineDowntimeRecords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_MachineDowntimeRecords");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.LotName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PcptimeStamp)
                    .HasColumnName("PCPTimeStamp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QryMaterialTraceabilityData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_MaterialTraceabilityData");

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LotName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Mblot)
                    .HasColumnName("MBLot")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.MlctimeStamp)
                    .HasColumnName("MLCTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.P1lot)
                    .HasColumnName("P1Lot")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.P2lot)
                    .HasColumnName("P2Lot")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Salot)
                    .HasColumnName("SALot")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QryProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_Product");

                entity.Property(e => e.Ca)
                    .HasColumnName("CA")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Caq).HasColumnName("CAQ");

                entity.Property(e => e.Cav).HasColumnName("CAV");

                entity.Property(e => e.Cl)
                    .HasColumnName("CL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Clq).HasColumnName("CLQ");

                entity.Property(e => e.Coa).HasColumnName("COA");

                entity.Property(e => e.Coc).HasColumnName("COC");

                entity.Property(e => e.Col)
                    .HasColumnName("COL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Cph)
                    .HasColumnName("CPH")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Cyc)
                    .HasColumnName("CYC")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Dwg)
                    .HasColumnName("DWG")
                    .IsUnicode(false);

                entity.Property(e => e.Ens).HasColumnName("ENS");

                entity.Property(e => e.Fut).HasColumnName("FUT");

                entity.Property(e => e.Ib)
                    .HasColumnName("IB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ibq).HasColumnName("IBQ");

                entity.Property(e => e.Mb)
                    .HasColumnName("MB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Mbq).HasColumnName("MBQ");

                entity.Property(e => e.P1)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.P1q).HasColumnName("P1Q");

                entity.Property(e => e.P2)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.P2q).HasColumnName("P2Q");

                entity.Property(e => e.Pa)
                    .HasColumnName("PA")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Paq).HasColumnName("PAQ");

                entity.Property(e => e.Por).HasColumnName("POR");

                entity.Property(e => e.Pps)
                    .HasColumnName("PPS")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Pqis)
                    .HasColumnName("PQIS")
                    .IsUnicode(false);

                entity.Property(e => e.ProduceId)
                    .HasColumnName("ProduceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ps)
                    .HasColumnName("PS")
                    .IsUnicode(false);

                entity.Property(e => e.Rtq).HasColumnName("RTQ");

                entity.Property(e => e.Sa)
                    .HasColumnName("SA")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Saq).HasColumnName("SAQ");

                entity.Property(e => e.Spc).HasColumnName("SPC");

                entity.Property(e => e.Sts).HasColumnName("STS");

                entity.Property(e => e.Tol)
                    .HasColumnName("TOL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QryProductCheckPointData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_ProductCheckPointData");

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LotName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PcptimeStamp)
                    .HasColumnName("PCPTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ShotWeight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<QryQualityRecordAction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_QualityRecordAction");

                entity.Property(e => e.QualityRecordAction)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.QualityRecordActionId)
                    .HasColumnName("QualityRecordActionID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QryQualityRecordObservation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_QualityRecordObservation");

                entity.Property(e => e.QualityRecordObservation)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.QualityRecordObservationId)
                    .HasColumnName("QualityRecordObservationID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QryQualityRecords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_QualityRecords");

                entity.Property(e => e.Action)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CavityId).HasColumnName("CavityID");

                entity.Property(e => e.LotName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PcptimeStamp)
                    .HasColumnName("PCPTimeStamp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QryTechnology>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_Technology");

                entity.Property(e => e.TechnologyId)
                    .HasColumnName("TechnologyID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TechnologyName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QryUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qry_User");

                entity.Property(e => e.Email)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Rfid)
                    .HasColumnName("RFID")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Username)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAuthorisationToRun>(entity =>
            {
                entity.HasKey(e => e.AuthorisationToRunId);

                entity.ToTable("tbl_AuthorisationToRun");

                entity.Property(e => e.AuthorisationToRunId).HasColumnName("AuthorisationToRunID");

                entity.Property(e => e.AtrtimeStamp)
                    .HasColumnName("ATRTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.LotName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qcrfid)
                    .HasColumnName("QCRFID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qcusername)
                    .HasColumnName("QCUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TechRfid)
                    .HasColumnName("TechRFID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TechUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCavitationRecord>(entity =>
            {
                entity.HasKey(e => e.CavitationRecordId);

                entity.ToTable("tbl_CavitationRecord");

                entity.Property(e => e.CavitationRecordId).HasColumnName("CavitationRecordID");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cav)
                    .HasColumnName("CAV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CavityId).HasColumnName("CavityID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.LotName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcptimeStamp)
                    .HasColumnName("PCPTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCavitationRecordAction>(entity =>
            {
                entity.HasKey(e => e.CavitationRecordActionId);

                entity.ToTable("tbl_CavitationRecordAction");

                entity.Property(e => e.CavitationRecordActionId).HasColumnName("CavitationRecordActionID");

                entity.Property(e => e.CavitationRecordAction)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCavitationRecordReason>(entity =>
            {
                entity.HasKey(e => e.CavitationRecordReasonId);

                entity.ToTable("tbl_CavitationRecordReason");

                entity.Property(e => e.CavitationRecordReasonId).HasColumnName("CavitationRecordReasonID");

                entity.Property(e => e.CavitationRecordReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDataArchiveQuery>(entity =>
            {
                entity.HasKey(e => e.DataArchiveQueryId);

                entity.ToTable("tbl_DataArchiveQuery");

                entity.Property(e => e.DataArchiveQueryId).HasColumnName("DataArchiveQueryID");

                entity.Property(e => e.DataArchiveQuery)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFunctionalTest>(entity =>
            {
                entity.HasKey(e => e.FunctionalTestId);

                entity.ToTable("tbl_FunctionalTest");

                entity.Property(e => e.FunctionalTestId).HasColumnName("FunctionalTestID");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FttimeStamp)
                    .HasColumnName("FTTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFunctionalTestResult>(entity =>
            {
                entity.HasKey(e => e.FunctioanlTestResultsId);

                entity.ToTable("tbl_FunctionalTestResult");

                entity.Property(e => e.FunctioanlTestResultsId).HasColumnName("FunctioanlTestResultsID");

                entity.Property(e => e.TestResult)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFunctionalTestType>(entity =>
            {
                entity.HasKey(e => e.FunctionalTestTypeId);

                entity.ToTable("tbl_FunctionalTestType");

                entity.Property(e => e.FunctionalTestTypeId).HasColumnName("FunctionalTestTypeID");

                entity.Property(e => e.TestType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLineClearance>(entity =>
            {
                entity.HasKey(e => e.LineClearanceId);

                entity.ToTable("tbl_LineClearance");

                entity.Property(e => e.LineClearanceId).HasColumnName("LineClearanceID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.LctimeStamp)
                    .HasColumnName("LCTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qcrfid)
                    .HasColumnName("QCRFID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qcusername)
                    .HasColumnName("QCUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TechRfid)
                    .HasColumnName("TechRFID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TechUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLot>(entity =>
            {
                entity.HasKey(e => e.LotId);

                entity.ToTable("tbl_Lot");

                entity.Property(e => e.LotId).HasColumnName("LotID");

                entity.Property(e => e.Loq)
                    .HasColumnName("LOQ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LotName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMachine>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("tbl_Machine");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TechnologyId).HasColumnName("TechnologyID");
            });

            modelBuilder.Entity<TblMachineDowntimeRecord>(entity =>
            {
                entity.HasKey(e => e.MachineDowntimeId);

                entity.ToTable("tbl_MachineDowntimeRecord");

                entity.Property(e => e.MachineDowntimeId).HasColumnName("MachineDowntimeID");

                entity.Property(e => e.Cav)
                    .HasColumnName("CAV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.LotName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcptimeStamp)
                    .HasColumnName("PCPTimeStamp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMaterialLotControl>(entity =>
            {
                entity.HasKey(e => e.MaterialLotControlId);

                entity.ToTable("tbl_MaterialLotControl");

                entity.Property(e => e.MaterialLotControlId).HasColumnName("MaterialLotControlID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mblot)
                    .HasColumnName("MBLot")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MlctimeStamp)
                    .HasColumnName("MLCTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.P1lot)
                    .HasColumnName("P1Lot")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2lot)
                    .HasColumnName("P2Lot")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salot)
                    .HasColumnName("SALot")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProduceId);

                entity.ToTable("tbl_Product");

                entity.Property(e => e.ProduceId).HasColumnName("ProduceID");

                entity.Property(e => e.Ca)
                    .HasColumnName("CA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Caq).HasColumnName("CAQ");

                entity.Property(e => e.Cav).HasColumnName("CAV");

                entity.Property(e => e.Cl)
                    .HasColumnName("CL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clq).HasColumnName("CLQ");

                entity.Property(e => e.Coa).HasColumnName("COA");

                entity.Property(e => e.Coc).HasColumnName("COC");

                entity.Property(e => e.Col)
                    .HasColumnName("COL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cph)
                    .HasColumnName("CPH")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Cyc)
                    .HasColumnName("CYC")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dwg)
                    .HasColumnName("DWG")
                    .IsUnicode(false);

                entity.Property(e => e.Ens).HasColumnName("ENS");

                entity.Property(e => e.Fut).HasColumnName("FUT");

                entity.Property(e => e.Ib)
                    .HasColumnName("IB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ibq).HasColumnName("IBQ");

                entity.Property(e => e.Mb)
                    .HasColumnName("MB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mbq).HasColumnName("MBQ");

                entity.Property(e => e.P1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1q).HasColumnName("P1Q");

                entity.Property(e => e.P2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2q).HasColumnName("P2Q");

                entity.Property(e => e.Pa)
                    .HasColumnName("PA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paq).HasColumnName("PAQ");

                entity.Property(e => e.Por).HasColumnName("POR");

                entity.Property(e => e.Pps)
                    .HasColumnName("PPS")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Pqis)
                    .HasColumnName("PQIS")
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ps)
                    .HasColumnName("PS")
                    .IsUnicode(false);

                entity.Property(e => e.Rtq).HasColumnName("RTQ");

                entity.Property(e => e.Sa)
                    .HasColumnName("SA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Saq).HasColumnName("SAQ");

                entity.Property(e => e.Spc).HasColumnName("SPC");

                entity.Property(e => e.Sts).HasColumnName("STS");

                entity.Property(e => e.Tol)
                    .HasColumnName("TOL")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProductCheckPoint>(entity =>
            {
                entity.HasKey(e => e.ProductCheckpointId);

                entity.ToTable("tbl_ProductCheckPoint");

                entity.Property(e => e.ProductCheckpointId).HasColumnName("ProductCheckpointID");

                entity.Property(e => e.CheckPoint).HasColumnType("time(0)");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.Des)
                    .HasColumnName("DES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcptimeStamp)
                    .HasColumnName("PCPTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShotWeight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblQualityRecord>(entity =>
            {
                entity.HasKey(e => e.QualityRecordId);

                entity.ToTable("tbl_QualityRecord");

                entity.Property(e => e.QualityRecordId).HasColumnName("QualityRecordID");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cav)
                    .HasColumnName("CAV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CavityId).HasColumnName("CavityID");

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.LotName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcptimeStamp)
                    .HasColumnName("PCPTimeStamp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblQualityRecordAction>(entity =>
            {
                entity.HasKey(e => e.QualityRecordActionId);

                entity.ToTable("tbl_QualityRecordAction");

                entity.Property(e => e.QualityRecordActionId).HasColumnName("QualityRecordActionID");

                entity.Property(e => e.QualityRecordAction)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQualityRecordObservation>(entity =>
            {
                entity.HasKey(e => e.QualityRecordObservationId);

                entity.ToTable("tbl_QualityRecordObservation");

                entity.Property(e => e.QualityRecordObservationId).HasColumnName("QualityRecordObservationID");

                entity.Property(e => e.QualityRecordObservation)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTechnology>(entity =>
            {
                entity.HasKey(e => e.TechnologyId);

                entity.ToTable("tbl_Technology");

                entity.Property(e => e.TechnologyId).HasColumnName("TechnologyID");

                entity.Property(e => e.TechnologyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tbl_User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rfid)
                    .HasColumnName("RFID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
