using Abstraction;

public class Program
{
    public static void Main()
    {
        Dokuman calisan1 = new Dokuman("Edward", "Cullen", "Bilgi Teknolojileri");
        calisan1.Tanıtma();
        calisan1.Gorev("Yazılım Geliştirici");

        Dokuman calisan2 = new Dokuman("Bella", "Swan", "Proje Geliştirme");
        calisan2.Tanıtma();
        calisan2.Gorev("Proje Yöneticisi");

        Dokuman calisan3 = new Dokuman("Jacob", "Black", "Ürün Yönetimi");
        calisan3.Tanıtma();
        calisan3.Gorev("Satış Temsilcisi");
    }
}
