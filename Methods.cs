void lyrics() // Şarkı sözü yazdıran method
{
    Console.WriteLine("So burn down this room");
}

int returnInteger() // Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı döndüren method
{
    Random rnd = new Random();
    int randomNumber = rnd.Next(0, 100);
    int remainder = randomNumber % 2;
    return remainder;
}

int multiply(int a, int b) // Kullanıcıdan alınan 2 sayının çarpımını döndüren method
{
    return a * b;
}

void welcome(string name, string surname) // Kullanıcıdan isim ve soyisim bilgisi alıp bunu Hoş Geldiniz mesajında kullana method
{
    Console.WriteLine($"Hoş Geldiniz {name} {surname}");
}

lyrics(); // Şarkı sözü yazdıran methodu çağırıyoruz
Console.WriteLine("Rastgele üretilen sayının 2'ye bölümünden kalan: " + returnInteger()); // Rastgele üretilen sayının bölümünden kalan methodu çağırıyoruz
Console.WriteLine("Lütfen çarpmak istediğiniz 2 sayı giriniz:");
int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yazdığınız sayıların çarpımı: " + multiply(first,second)); // Kullanıcıdan alınan 2 sayıyla çarpma işlemi yapan methodu çağırıyoruz
Console.WriteLine("Lütfen isim ve soyisminizi yazınız");
string firstName = Console.ReadLine();
string lastName = Console.ReadLine();
welcome(firstName, lastName); // Kullanıcıya hoş geldin yazdıran methodu çağırıyoruz
