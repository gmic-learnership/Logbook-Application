//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogBookWPFApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendanceMaster
    {
        public AttendanceMaster()
        {
            this.AttendanceDetails = new HashSet<AttendanceDetail>();
        }
    
        public int MasterID { get; set; }
        public System.DateTime Date { get; set; }
        public string TrainedIn { get; set; }
    
        public virtual ICollection<AttendanceDetail> AttendanceDetails { get; set; }
    }
}
