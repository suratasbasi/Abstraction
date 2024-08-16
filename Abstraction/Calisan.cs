using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }
        public void Tanıtma()
        {
            Console.Write("Adım " + Ad + " soyadım " + Soyad + ". " + Departman + " departmanında ");
        }
    }

    public interface IGorev
    {
        public void Gorev(string gorev);
    }

    public class Dokuman : Calisan, IGorev
    {

        public Dokuman(string ad, string soyad, string departman) : base(ad, soyad, departman) { }


        public void Gorev(string gorev)
        {
            Console.WriteLine(gorev + " olarak çalışıyorum.");
        }
    }

}

