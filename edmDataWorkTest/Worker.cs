//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace edmDataWorkTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Worker
    {
        public int WorkerId { get; set; }
        public string Name { get; set; }
        public short Age { get; set; }
    
        public virtual Division Division { get; set; }
    }
}
