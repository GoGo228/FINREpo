//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISharpConvertor.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbFromWho
    {
        public tbFromWho()
        {
            this.tbSystemComin = new HashSet<tbSystemComin>();
            this.tbUserComin = new HashSet<tbUserComin>();
        }
    
        public string cName { get; set; }
        public int cUserId { get; set; }
        public int cId { get; set; }
    
        public virtual tbUser tbUser { get; set; }
        public virtual ICollection<tbSystemComin> tbSystemComin { get; set; }
        public virtual ICollection<tbUserComin> tbUserComin { get; set; }
    }
}
