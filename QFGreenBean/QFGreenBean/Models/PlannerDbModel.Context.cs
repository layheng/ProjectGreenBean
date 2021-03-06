﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QFGreenBean.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PlannerDbEntities : DbContext
    {
        public PlannerDbEntities()
            : base("name=PlannerDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<StudentRecord> StudentRecords { get; set; }
        public virtual DbSet<IsEnrolledIn> IsEnrolledIns { get; set; }
        public virtual DbSet<AccountUser> AccountUsers { get; set; }
        public virtual DbSet<IsEnrollingIn> IsEnrollingIns { get; set; }
        public virtual DbSet<ProgramOption> ProgramOptions { get; set; }
        public virtual DbSet<SchoolUser> SchoolUsers { get; set; }
        public virtual DbSet<IsScheduledIn> IsScheduledIns { get; set; }
        public virtual DbSet<StudentSchedule> StudentSchedules { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<DepartmentAvdisor> DepartmentAvdisors { get; set; }
        public virtual DbSet<DepartmentDirector> DepartmentDirectors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<FallEvent> FallEvents { get; set; }
        public virtual DbSet<SummerEvent> SummerEvents { get; set; }
        public virtual DbSet<WinterEvent> WinterEvents { get; set; }
        public virtual DbSet<StudentConstraint> StudentConstraints { get; set; }
    }
}
