
string nev = "Tóth Bence";
int osszeg = 8500;
bool torzs = false;

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
