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
    
    public partial class Odalar
    {
        public Odalar()
        {
            this.Rezervasyonlars = new HashSet<Rezervasyonlar>();
        }
    
        public int OdaID { get; set; }
        public Nullable<int> OtelID { get; set; }
        public string OdaNumarasi { get; set; }
        public string Tip { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public string Durum { get; set; }
    
        public virtual Oteller Oteller { get; set; }
        public virtual ICollection<Rezervasyonlar> Rezervasyonlars { get; set; }
    }
}
