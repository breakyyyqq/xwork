using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class kimlik
    {
        string ad;
        string soyad;
        string memleket;
        int yas;
        char cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value.ToUpper();}
    }
        public string MEMELEKET
        {
            get { return memleket; }
            set { memleket = value; }
        }
        public int YAS
        {
            get => yas;
            set => yas = Math.Abs(value);


            public char CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        public kimlik()
        {
            ad = "";
            soyad = "";
            yas = 18;
            cinsiyet = 'K';
            memleket = "Ankara";
        }
    }
}
