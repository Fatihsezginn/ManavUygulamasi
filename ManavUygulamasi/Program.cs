
    Console.WriteLine("Rüya Manavına Hoş Geldiniz! \n Elma = 2TL \n Armut = 3 TL \n Çilek = 2 TL \n Muz = 3 TL \n Diğer bütün meyveler =  4 TL");
Console.WriteLine("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer):");
string meyve =  Console.ReadLine();


switch (meyve.ToLower())
{
    case "Elma":
        Console.WriteLine("2 TL");
        break;

    case "Armut":
        Console.WriteLine("3 TL");
        break;

    case "Çilek":
        Console.WriteLine("2 TL");
        break;

    case "Muz":
        Console.WriteLine("3 TL");
        break;

    default:
        Console.WriteLine("4 TL");
        break;

}

if (meyve.ToLower() == "Elma" || meyve.ToLower() == "Çilek") Console.WriteLine("Seçtiginiz meyvenin fiyati: 2 TL");
else if (meyve.ToLower() == "Armut" || meyve.ToLower() == "Muz") Console.WriteLine("Seçtiginiz meyvenin fiyati: 3 TL");
else Console.WriteLine("Seçtiginiz meyvenin fiyati: 4 TL");