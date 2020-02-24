﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVE.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using System.Collections.Generic;

    public partial class EVEEntities : DbContext
    {
        public EVEEntities()
            : base("name=EVEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<EduDepartment> EduDepartments { get; set; }
        public virtual DbSet<EduLevel> EduLevels { get; set; }
        public virtual DbSet<EduMinistry> EduMinistries { get; set; }
        public virtual DbSet<EduProvince> EduProvinces { get; set; }
        public virtual DbSet<EvalCriteria> EvalCriterias { get; set; }
        public virtual DbSet<EvalGuide> EvalGuides { get; set; }
        public virtual DbSet<EvalResult> EvalResults { get; set; }
        public virtual DbSet<EvalStandard> EvalStandards { get; set; }
        public virtual DbSet<EvalState> EvalStates { get; set; }
        public virtual DbSet<EvalType> EvalTypes { get; set; }
        public virtual DbSet<FormGroup> FormGroups { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<SchoolLevel> SchoolLevels { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserGroup_Employee> UserGroup_Employee { get; set; }
        public virtual DbSet<UserGroup_Form> UserGroup_Form { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<LoginUser> LoginUsers { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<EvalMaster> EvalMasters { get; set; }
        public virtual DbSet<EvalPeriod> EvalPeriods { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<SchoolDepartment> SchoolDepartments { get; set; }
        public virtual DbSet<EvalDetail> EvalDetails { get; set; }
    
        public virtual List<usp_GetPeriodByYearAndSchool_Result> usp_GetPeriodByYearAndSchool(Nullable<int> year, Nullable<int> schoolId, string evalTypeCode)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var schoolIdParameter = schoolId.HasValue ?
                new ObjectParameter("schoolId", schoolId) :
                new ObjectParameter("schoolId", typeof(int));
    
            var evalTypeCodeParameter = evalTypeCode != null ?
                new ObjectParameter("evalTypeCode", evalTypeCode) :
                new ObjectParameter("evalTypeCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetPeriodByYearAndSchool_Result>("usp_GetPeriodByYearAndSchool", yearParameter, schoolIdParameter, evalTypeCodeParameter).ToList();
        }
    }
}
