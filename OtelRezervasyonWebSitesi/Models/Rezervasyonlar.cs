//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelRezervasyonWebSitesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezervasyonlar
    {
        public Rezervasyonlar()
        {
            this.Odemelers = new HashSet<Odemeler>();
        }
    
        public int RezervasyonID { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public Nullable<int> OdaID { get; set; }
        public Nullable<System.DateTime> GirisTarihi { get; set; }
        public Nullable<System.DateTime> CikisTarihi { get; set; }
        public string Durum { get; set; }
    
        public virtual Musteriler Musteriler { get; set; }
        public virtual Odalar Odalar { get; set; }
        public virtual ICollection<Odemeler> Odemelers { get; set; }
    }
}
