//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DG.DentneD.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class patientsattachmentstypes
    {
        public patientsattachmentstypes()
        {
            this.patientsattachments = new HashSet<patientsattachments>();
        }
    
        public int patientsattachmentstypes_id { get; set; }
        public string patientsattachmentstypes_name { get; set; }
        public string patientsattachmentstypes_valueautofunc { get; set; }
    
        public virtual ICollection<patientsattachments> patientsattachments { get; set; }
    }
}
