//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataSqlServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserToken
    {
        public string token { get; set; }
        public Nullable<long> expire_timestamp { get; set; }
        public int user_id { get; set; }
    
        public virtual User users { get; set; }
    }
}
