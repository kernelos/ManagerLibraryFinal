//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookLending
    {
        public int Id { get; set; }
        public int BooIdOne { get; set; }
        public Nullable<int> BookIdTwo { get; set; }
        public int StudentId { get; set; }
        public Nullable<System.DateTime> LendingDay { get; set; }
        public Nullable<System.DateTime> ReturnDay { get; set; }
        public Nullable<bool> IsReturn { get; set; }
        public int LendingManagerId { get; set; }
        public Nullable<int> ReturnManagerId { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Book Book1 { get; set; }
        public virtual LibManager LibManager { get; set; }
        public virtual LibManager LibManager1 { get; set; }
        public virtual Student Student { get; set; }
    }
}
