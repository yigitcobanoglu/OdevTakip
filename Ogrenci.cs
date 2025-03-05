using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTakip
{
    public class Ogrenci
    {
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        public string No {  get; set; }
        public string Sınıf {  get; set; }
        public string DersAdı {  get; set; }
        public string OdevKonusu {  get; set; }
        public string OdevKontrol {  get;  set; }
        public string OdevPuan {  get; set; }
        public string FullName => $"{Ad} {Soyad}";

    }
}
