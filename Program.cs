// .NET Geliştirici Yol Haritası: Kariyerimin Başında Keşke Bilseydim Dediklerim
// Bu örnek, bir .NET geliştiricisinin kariyer yolculuğunda karşılaşabileceği temel teknik konuları adım adım gösterir.
// Her metod, yol haritasındaki farklı bir öğrenme aşamasını temsil eder.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- .NET Developer Yol Haritası Simülasyonu ---");
        Console.WriteLine("Bu program, bir .NET geliştiricisinin öğrenme yolculuğundaki temel adımları gösterir.");
        Console.WriteLine("Her bölüm, farklı bir teknik konuya odaklanır.
");

        // Adım 1: C# Temelleri - Değişkenler, Veri Tipleri, Konsol G/Ç
        // Kariyerin başında öğrenilmesi gereken en temel yapı taşları.
        DemonstrateCSharpBasics();

        // Adım 2: Nesne Yönelimli Programlama (OOP) - Sınıflar, Nesneler, Metotlar
        // Daha karmaşık uygulamalar geliştirmek için vazgeçilmez bir temel.
        DemonstrateOOPConcepts();

        // Adım 3: Koleksiyonlar - Listeler, Diziler
        // Veri depolama ve yönetimi için sıkça kullanılan yapılar.
        DemonstrateCollections();

        // Adım 4: Hata Yönetimi - Try-Catch Blokları
        // Sağlam ve güvenilir uygulamalar yazmak için kritik bir beceri.
        DemonstrateErrorHandling();

        Console.WriteLine("
--- Yol Haritası Tamamlandı ---");
        Console.WriteLine("Bu temel adımlar, daha ileri konular (ASP.NET Core, Veritabanları, Bulut vb.) için sağlam bir zemin oluşturur.");
        Console.WriteLine("Her adımı derinlemesine öğrenmek, başarılı bir .NET kariyerinin anahtarıdır.");
    }

    static void DemonstrateCSharpBasics()
    {
        Console.WriteLine("\n--- Adım 1: C# Temelleri ---");
        // Değişken tanımlama ve veri tipleri
        string developerName = "Ayşe Yılmaz"; // Metin (string)
        int yearsOfExperience = 0;           // Tam sayı (int)
        double salaryExpectation = 50000.0;  // Ondalıklı sayı (double)
        bool isNewToDotNet = true;           // Mantıksal (bool)

        Console.WriteLine($"Merhaba, ben {developerName}. .NET dünyasına yeni adım atıyorum.");
        Console.WriteLine($"Tecrübem: {yearsOfExperience} yıl. Yeni başlayan biri miyim? {isNewToDotNet}");

        // Kullanıcıdan girdi alma
        Console.Write("Kaç yıl tecrübeniz var? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int actualExperience))
        {
            yearsOfExperience = actualExperience;
            Console.WriteLine($"Anladım, {yearsOfExperience} yıl tecrübeniz var.");
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Tecrübe 0 olarak kabul edildi.");
        }

        // Koşullu ifadeler (if-else)
        if (yearsOfExperience < 1)
        {
            Console.WriteLine("Harika! Temelleri öğrenmek için en doğru yerdesiniz.");
        }
        else
        {
            Console.WriteLine("Tecrübeli bir geliştiricisiniz, yine de temelleri pekiştirmek her zaman iyidir.");
        }

        // Döngüler (for loop)
        Console.WriteLine("\nÖğrenme hedefleri:");
        string[] goals = { "C# Syntax", "Data Types", "Control Flow" };
        for (int i = 0; i < goals.Length; i++)
        {
            Console.WriteLine($"  - {goals[i]}");
        }
    }

    // Bir sınıf tanımı - OOP'nin temel yapı taşı
    public class Developer
    {
        public string Name { get; set; } // Özellik (Property)
        public string Role { get; set; }
        public int ExperienceYears { get; private set; }

        // Yapıcı metot (Constructor)
        public Developer(string name, string role)
        {
            Name = name;
            Role = role;
            ExperienceYears = 0;
        }

        // Metot (Method) - Davranış
        public void LearnNewSkill(string skillName)
        {
            Console.WriteLine($"{Name}, '{skillName}' becerisini öğreniyor.");
            ExperienceYears++; // Deneyim artırılıyor
        }

        public void Introduce()
        {
            Console.WriteLine($"Ben {Name}, bir {Role} geliştiricisiyim. {ExperienceYears} yıl tecrübem var.");
        }
    }

    static void DemonstrateOOPConcepts()
    {
        Console.WriteLine("\n--- Adım 2: Nesne Yönelimli Programlama (OOP) ---");
        // Nesne oluşturma (Instantiation)
        Developer juniorDev = new Developer("Can Demir", ".NET Junior");
        juniorDev.Introduce();

        // Metot çağırma
        juniorDev.LearnNewSkill("ASP.NET Core");
        juniorDev.LearnNewSkill("Entity Framework Core");
        juniorDev.Introduce();

        Developer seniorDev = new Developer("Elif Kaya", ".NET Senior");
        seniorDev.Introduce();
        seniorDev.LearnNewSkill("Microservices Architecture");
        seniorDev.Introduce();
    }

    static void DemonstrateCollections()
    {
        Console.WriteLine("\n--- Adım 3: Koleksiyonlar ---");
        // List<T> kullanımı - Dinamik boyutlu koleksiyon
        List<string> technologies = new List<string>();
        technologies.Add("C#");
        technologies.Add("SQL Server");
        technologies.Add("Azure");
        technologies.Add("Git");

        Console.WriteLine("Öğrenilecek Teknolojiler:");
        foreach (string tech in technologies)
        {
            Console.WriteLine($"  - {tech}");
        }

        // Bir elemanı kaldırma
        technologies.Remove("SQL Server");
        Console.WriteLine("\nSQL Server öğrenildi, listeden çıkarıldı.");
        Console.WriteLine("Kalan Teknolojiler:");
        for (int i = 0; i < technologies.Count; i++)
        {
            Console.WriteLine($"  - {technologies[i]}");
        }

        // Diziler (Array) - Sabit boyutlu koleksiyon
        string[] coreSkills = new string[3];
        coreSkills[0] = "Problem Solving";
        coreSkills[1] = "Clean Code";
        coreSkills[2] = "Debugging";

        Console.WriteLine("\nTemel Geliştirici Becerileri:");
        foreach (string skill in coreSkills)
        {
            Console.WriteLine($"  - {skill}");
        }
    }

    static void DemonstrateErrorHandling()
    {
        Console.WriteLine("\n--- Adım 4: Hata Yönetimi (Try-Catch) ---");
        Console.WriteLine("Hata yönetimi, uygulamaların beklenmedik durumlarla başa çıkmasını sağlar.");

        // Bölme işlemi hatası örneği
        int numerator = 10;
        int denominator = 0;

        try
        {
            Console.WriteLine($"\n{numerator} / {denominator} işlemi deneniyor...");
            int result = numerator / denominator; // Burada bir DivideByZeroException fırlatılacak
            Console.WriteLine($"Sonuç: {result}"); // Bu satıra asla ulaşılamaz
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Hata yakalandı: Sıfıra bölme hatası! Detay: {ex.Message}");
            Console.WriteLine("Lütfen bölenin sıfır olmadığından emin olun.");
        }
        catch (Exception ex)
        {
            // Daha genel bir hata yakalama bloğu
            Console.WriteLine($"Beklenmedik bir hata oluştu: {ex.Message}");
        }
        finally
        {
            // Hata olsun veya olmasın her zaman çalışacak kod bloğu
            Console.WriteLine("Hata yönetimi bloğu tamamlandı. Kaynaklar serbest bırakılabilir.");
        }

        // Geçersiz sayı formatı hatası örneği
        string numberString = "abc";
        try
        {
            Console.WriteLine($"\n'{numberString}' ifadesi sayıya dönüştürülmeye çalışılıyor...");
            int parsedNumber = int.Parse(numberString); // Burada bir FormatException fırlatılacak
            Console.WriteLine($"Dönüştürülen sayı: {parsedNumber}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Hata yakalandı: Geçersiz sayı formatı! Detay: {ex.Message}");
            Console.WriteLine("Lütfen geçerli bir sayı formatı girin.");
        }
    }
}