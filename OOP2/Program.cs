using OOP2;

class Program
{
    private static void Main(string[] args)
    {
        GercekMusteri musteri1 = new GercekMusteri();
        
        musteri1.Id = 1;
        musteri1.Adi = "Enes";
        musteri1.Soyadi = "Eroglu";
        musteri1.TcNo = "123456789523";
        musteri1.MusteriNo = "123456";
        TuzelMusteri  musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "1234561";
        musteri2.SirketAdi = "Erogluholding";
        musteri2.VergiNo = "516516535";

        Musteri musteri3= new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(musteri4);


    }
}