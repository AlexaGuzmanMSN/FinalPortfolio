//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalPortfolio3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Screenshot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Screenshot()
        {
            this.Descriptions = new HashSet<Description>();
        }
    
        public int ScreenshotID { get; set; }
        public int ProjectID { get; set; }
        public string Screenshot1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Description> Descriptions { get; set; }
        public virtual Project Project { get; set; }
    }
}
