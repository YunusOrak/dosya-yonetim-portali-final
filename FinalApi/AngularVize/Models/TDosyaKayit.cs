
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AngularVize.Models
{

using System;
    using System.Collections.Generic;
    
public partial class TDosyaKayit
{

    public string dkId { get; set; }

    public string dkDersId { get; set; }

    public string dkDosyaId { get; set; }



    public virtual TDersler TDersler { get; set; }

    public virtual TDosyalar TDosyalar { get; set; }

}

}
