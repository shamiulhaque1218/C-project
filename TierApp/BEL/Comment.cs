//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int Id { get; set; }
        public string CText { get; set; }
        public int Fk_User_Id { get; set; }
        public int Fk_News_Id { get; set; }
    
        public virtual User User { get; set; }
        public virtual News News { get; set; }
    }
}
