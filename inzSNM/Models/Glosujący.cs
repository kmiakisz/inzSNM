//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inzSNM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Glosujący
    {
        public Glosujący()
        {
            this.Bierze_udzial = new HashSet<Bierze_udzial>();
        }
    
        public int Id_Osoba { get; set; }
        public string Email { get; set; }
        public int Id_Narod { get; set; }
        public int Id_Wiek { get; set; }
        public int Id_Plec { get; set; }
    
        public virtual ICollection<Bierze_udzial> Bierze_udzial { get; set; }
        public virtual Narodowosc Narodowosc { get; set; }
        public virtual Plec Plec { get; set; }
        public virtual Wiek Wiek { get; set; }
    }
}
