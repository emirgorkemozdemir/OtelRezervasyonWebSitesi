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
    
    public partial class Oteller
    {
        public Oteller()
        {
            this.Odalars = new HashSet<Odalar>();
        }
    
        public int OtelID { get; set; }
        public string OtelAdi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
    
        public virtual ICollection<Odalar> Odalars { get; set; }
    }
}
