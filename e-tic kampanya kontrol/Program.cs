using System;

class Program
{
    static void Main()
    {
        Console.Write("Üye misiniz? (evet/hayır): ");
        string uyelik = Console.ReadLine().ToLower();

        Console.Write("Alışveriş tutarını girin (TL): ");
        bool tutarOk = int.TryParse(Console.ReadLine(), out int tutar);

        if (!tutarOk || tutar < 0)
        {
            Console.WriteLine("Geçersiz tutar girdiniz.");
            return;
        }

        Console.Write("İlk defa alışveriş yapıyor musunuz? (evet/hayır): ");
        string ilkDefa = Console.ReadLine().ToLower();

        bool kampanyaKazandi = (uyelik == "evet" && tutar > 1000) || (ilkDefa == "evet");

        if (kampanyaKazandi)
        {
            double indirimliTutar = tutar * 0.85;
            Console.WriteLine($"\nKampanya kazandınız! %15 indirim uygulandı. Ödemeniz gereken tutar: {indirimliTutar} TL");
        }
        else
        {
            Console.WriteLine($"\nKampanyadan yararlanamıyorsunuz. Ödemeniz gereken tutar: {tutar} TL");
        }
    }
}