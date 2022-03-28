// Telefon Rehberi Uygulaması
List<RehberVerileri> rehber = new List<RehberVerileri>();
rehber.Add(new RehberVerileri("Ömer","Saldıran","12345679"));
rehber.Add(new RehberVerileri("Ahmet","Vatansever","987654321"));
rehber.Add(new RehberVerileri("Ömer","Sayar","1212232334"));
rehber.Add(new RehberVerileri("Mehmet","Saldıran","846285927264"));
rehber.Add(new RehberVerileri("Veli","Öztürk","12345679"));

anaEkran();

void anaEkran()
{
    System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
    System.Console.WriteLine("*******************************************");
    System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
    System.Console.WriteLine("(2) Varolan Numarayı Silmek");
    System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
    System.Console.WriteLine("(4) Rehberi Listelemek");
    System.Console.WriteLine("(5) Rehberde Arama Yapmak");

    int secim = Int32.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            NumaraKaydet();
            break;

        case 2:
            NumaraSil();
            break;

        case 3:
            NumaraGuncelle();
            break;

        case 4:
            Listele();
            break;

        case 5:
            RehberdeAra();
            break;

        default:
            anaEkran();
            break;
    }
}


void NumaraKaydet()
{
    System.Console.WriteLine("Lütfen isim giriniz               :");
    string isim = Console.ReadLine();
    System.Console.WriteLine("Lütfen soyisim giriniz            :");
    string soyisim = Console.ReadLine();
    System.Console.WriteLine("Lütfen telefon numarası giriniz   :");
    string numara = Console.ReadLine();

    rehber.Add(new RehberVerileri(isim,soyisim,numara){});
    System.Console.WriteLine("Rehbere eklendi");
    System.Console.WriteLine();
    anaEkran();

}

void NumaraSil(){
    System.Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
    string girdi = Console.ReadLine();
    foreach (var item in rehber)
    {
        if(girdi == item.isim || girdi == item.soyIsim){
            rehber.Remove(item);
            System.Console.WriteLine("Rehberden silindi");
            System.Console.WriteLine();
        }
        else{
            System.Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            System.Console.WriteLine("* Silmeyi sonlandırmak için   : (1)");
            System.Console.WriteLine("* Yeniden denemek için        : (2)");
            int secim = int.Parse(Console.ReadLine());
            if(secim == 1)
                anaEkran();
            else
                NumaraSil();
        }
    }
}

void NumaraGuncelle(){
    System.Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
    string girdi = Console.ReadLine();
    foreach (var item in rehber)
    {
        if(girdi == item.isim || girdi == item.soyIsim){
            System.Console.WriteLine("Lütfen yeni numarayı giriniz :");
            item.numara = Console.ReadLine();
            System.Console.WriteLine("Numara güncellendi");
            System.Console.WriteLine();
        }
        else{
            System.Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            System.Console.WriteLine("* Güncellemeyi sonlandırmak için   : (1)");
            System.Console.WriteLine("* Yeniden denemek için             : (2)");
            int secim = int.Parse(Console.ReadLine());
            if(secim == 1)
                anaEkran();
            else
                NumaraGuncelle();
        }
    }

}

void Listele(){
    System.Console.WriteLine("Telefon Rehberi");
    System.Console.WriteLine("*************************************");
    foreach (var item in rehber)
    {
        System.Console.WriteLine("isim: " + item.isim);
        System.Console.WriteLine("Soyisim: " + item.soyIsim);
        System.Console.WriteLine("Telefon Numarası " + item.numara);
        System.Console.WriteLine("-");
    }

    anaEkran();

}

void RehberdeAra(){

}
