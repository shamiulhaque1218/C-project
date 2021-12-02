

namespace BEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class React
    {
        public int Id { get; set; }
        public int Fk_Users_Id { get; set; }
        public int Fk_News_Id { get; set; }
    
        public virtual News News { get; set; }
        public virtual User User { get; set; }
    }
}
