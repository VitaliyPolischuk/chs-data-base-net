//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plane
    {
        public Plane()
        {
            this.Flight_Plane = new HashSet<Flight_Plane>();
        }
    
        public int PlaneId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    
        public virtual ICollection<Flight_Plane> Flight_Plane { get; set; }
    }
}