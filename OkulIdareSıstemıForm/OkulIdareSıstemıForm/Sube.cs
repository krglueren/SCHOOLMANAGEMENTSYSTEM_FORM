//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OkulIdareSıstemıForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sube
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> BankaId { get; set; }
    
        public virtual Banka Banka { get; set; }
    }
}
