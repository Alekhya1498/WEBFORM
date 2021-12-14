﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBFORMSAssignment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class formdbEntities : DbContext
    {
        public formdbEntities()
            : base("name=formdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<newuserreg> newuserregs { get; set; }
    
        public virtual int Userreg(string username, string pwd, string repwd, string email, string gender, string maritalstatus, Nullable<System.DateTime> joindate)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("Pwd", pwd) :
                new ObjectParameter("Pwd", typeof(string));
    
            var repwdParameter = repwd != null ?
                new ObjectParameter("Repwd", repwd) :
                new ObjectParameter("Repwd", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var maritalstatusParameter = maritalstatus != null ?
                new ObjectParameter("Maritalstatus", maritalstatus) :
                new ObjectParameter("Maritalstatus", typeof(string));
    
            var joindateParameter = joindate.HasValue ?
                new ObjectParameter("Joindate", joindate) :
                new ObjectParameter("Joindate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Userreg", usernameParameter, pwdParameter, repwdParameter, emailParameter, genderParameter, maritalstatusParameter, joindateParameter);
        }
    
        public virtual ObjectResult<newuserreg> UserRegistration(string username, string pwd, string repwd, string email, string gender, string maritalstatus, Nullable<System.DateTime> joindate)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("Pwd", pwd) :
                new ObjectParameter("Pwd", typeof(string));
    
            var repwdParameter = repwd != null ?
                new ObjectParameter("Repwd", repwd) :
                new ObjectParameter("Repwd", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var maritalstatusParameter = maritalstatus != null ?
                new ObjectParameter("Maritalstatus", maritalstatus) :
                new ObjectParameter("Maritalstatus", typeof(string));
    
            var joindateParameter = joindate.HasValue ?
                new ObjectParameter("Joindate", joindate) :
                new ObjectParameter("Joindate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<newuserreg>("UserRegistration", usernameParameter, pwdParameter, repwdParameter, emailParameter, genderParameter, maritalstatusParameter, joindateParameter);
        }
    
        public virtual ObjectResult<newuserreg> UserRegistration(string username, string pwd, string repwd, string email, string gender, string maritalstatus, Nullable<System.DateTime> joindate, MergeOption mergeOption)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("Pwd", pwd) :
                new ObjectParameter("Pwd", typeof(string));
    
            var repwdParameter = repwd != null ?
                new ObjectParameter("Repwd", repwd) :
                new ObjectParameter("Repwd", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var maritalstatusParameter = maritalstatus != null ?
                new ObjectParameter("Maritalstatus", maritalstatus) :
                new ObjectParameter("Maritalstatus", typeof(string));
    
            var joindateParameter = joindate.HasValue ?
                new ObjectParameter("Joindate", joindate) :
                new ObjectParameter("Joindate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<newuserreg>("UserRegistration", mergeOption, usernameParameter, pwdParameter, repwdParameter, emailParameter, genderParameter, maritalstatusParameter, joindateParameter);
        }
    }
}
