using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatooRentACar.Models
{
    public class siteBilgileri
    {
        RentACarEntities baglan = new RentACarEntities();
        public List<AKategori> anakategori { get; set; }
        public List<Bkategori> altkategori { get; set; }
        public List<ARAC> araclar { get; set; }
        public List<ARAC> aracFiltre { get; set; }
        public Int32 aracsayisi { get; set; }
        
    
        
        public void bilgiler()
        {
            anakategori = baglan.AKategori.ToList();
            altkategori = baglan.Bkategori.ToList();
            araclar = baglan.ARAC.Where(m => m.durum == "Aktif").ToList();
            aracsayisi = baglan.ARAC.Where(m => m.durum == "Aktif").Count();
            
        }
    }
}