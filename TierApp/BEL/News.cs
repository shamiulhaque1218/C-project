
namespace BEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News()
        {
            this.Comments = new HashSet<Comment>();
            this.Reacts = new HashSet<React>();
        }
    
        public int Id { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public int Fk_User_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<React> Reacts { get; set; }
    }
}
