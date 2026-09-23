
Console.Write("Neve: ");
string nev = Console.ReadLine();
Console.Write("Rendelés összege: ");
int osszeg = int.Parse(Console.ReadLine());

bool torzs;

while (true)
{
    Console.Write("Törzsvásárló? (igen / nem) ");
    string torzsIn=Console.ReadLine();
    if (torzsIn == "igen")
    {
        torzs = true;
        break;
    }
    else if (torzsIn == "nem")
    {
        torzs = false; 
        break;
    }
    else Console.WriteLine("Hibás válasz");
}



int szallDij;

if (osszeg >= 10000 || torzs==true) { szallDij = 0; }
else if (osszeg >=5000) { szallDij = 500; }
else { szallDij = 1200; }

int vegossz = osszeg + szallDij;

Console.Write("======================================================");
Console.WriteLine();
Console.WriteLine($"Vásárló neve: {nev}");
Console.WriteLine($"Rendelés összege: {osszeg} Ft");
Console.WriteLine($"Szállítási díj: {szallDij} Ft (Törzsvásárlói / 10k feletti ingyenes szállítás)");
Console.WriteLine($"Fizetendő végösszeg: {vegossz} Ft");
Console.Write("======================================================");
