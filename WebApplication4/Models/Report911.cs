using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication4.Models
{
    public class TimeOfEmergency
    {
        public int TimeOfEmergencyID { get; set; }
        public long Ticks { get; set; }
        public int Days { get; set; }
        public int Hours { get; set; }
        public int Milliseconds { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public double TotalDays { get; set; }
        public int TotalHours { get; set; }
        public int TotalMilliseconds { get; set; }
        public int TotalMinutes { get; set; }
        public int TotalSeconds { get; set; }
    }

    public class IncidentCreatedTime
    {
        public int IncidentCreatedTimeID { get; set; }
        public long Ticks { get; set; }
        public int Days { get; set; }
        public int Hours { get; set; }
        public int Milliseconds { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public double TotalDays { get; set; }
        public double TotalHours { get; set; }
        public int TotalMilliseconds { get; set; }
        public double TotalMinutes { get; set; }
        public int TotalSeconds { get; set; }
    }

    public class Report911
    {
        public int Report911ID { get; set; }
        public string CallerName { get; set; }
        public string CallerNRIC { get; set; }
        public int CallBackNo { get; set; }
        public string LocationofEmergency { get; set; }
        public TimeOfEmergency TimeOfEmergency { get; set; }
        public string TypeOfSuperBeing { get; set; }
        public int EstimatedNoOfBeings { get; set; }
        public int EstimatedNoOfInjuries { get; set; }
        public int EstimatedNoOfDeath { get; set; }
        public string DescOfEmergency { get; set; }
        public string StaffId { get; set; }
        public string AlertedCMOId { get; set; }
        public IncidentCreatedTime IncidentCreatedTime { get; set; }
        public DateTime IncidentCreatedDate { get; set; }
        public string NatureOfEmergency { get; set; }
        public string NameOfEmergency { get; set; }
    }
    public class DBReport911 : DbContext
    {
        public DbSet<Report911> Report911s { get; set; }
        public DbSet<IncidentCreatedTime> IncidentCreatedTimes { get; set; }
        public DbSet<TimeOfEmergency> TimeOfEmergencys { get; set; }
    }
}