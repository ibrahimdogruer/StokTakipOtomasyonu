
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DemirbasOtomasyon.Model
{

using System;
    using System.Collections.Generic;
    
public partial class Zimmetler
{

    public Zimmetler()
    {

        this.Atıklar = new HashSet<Atıklar>();

    }


    public int zimmetID { get; set; }

    public Nullable<System.DateTime> zimmetTarihi { get; set; }

    public Nullable<bool> zimmetDurum { get; set; }

    public Nullable<int> personelID { get; set; }

    public Nullable<int> kullaniciID { get; set; }

    public Nullable<int> urunID { get; set; }

    public Nullable<int> zimmetAdet { get; set; }



    public virtual Kullanıcılar Kullanıcılar { get; set; }

    public virtual Personeller Personeller { get; set; }

    public virtual Urunler Urunler { get; set; }

    public virtual ICollection<Atıklar> Atıklar { get; set; }

}

}
