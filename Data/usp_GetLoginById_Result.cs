//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    
    public partial class usp_GetLoginById_Result
    {
        public long id { get; set; }
        public string login { get; set; }
        public long id_company { get; set; }
        public string email { get; set; }
        public bool confirmed_email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public long acces_failed_count { get; set; }
        public bool locked { get; set; }
        public bool suspended { get; set; }
        public Nullable<long> Customer { get; set; }
        public Nullable<long> seller { get; set; }
    }
}
