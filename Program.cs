
string nev = "Tóth Bence";
int osszeg = 8500;
bool torzs = false;

int szallDij;

if (osszeg >= 10000 || torzs==true) { szallDij = 0; }
else if (osszeg >=5000) { szallDij = 500; }
else { szallDij = 1200; }

int vegossz = osszeg + szallDij;
