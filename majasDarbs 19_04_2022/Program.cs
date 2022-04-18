// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("===================MĀJAS DARBS 2==========================");
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("===================I uzdevums==========================");
Console.WriteLine();


Console.WriteLine("Kā Tevi sauc?");
string vardskaSauc = Console.ReadLine();
Console.WriteLine("Sveiks, " + vardskaSauc);


Console.WriteLine();
Console.WriteLine("===================II uzdevums==========================");
Console.WriteLine();

Console.WriteLine("Kāds ir tavs vecums?");
string vecums1arvardiem = Console.ReadLine();
int vecumsSkaitli2 = int.Parse(vecums1arvardiem);
int palielinamskaitliparviens = vecumsSkaitli2 + 1;



Console.WriteLine("Nākamgad tev paliks: " + palielinamskaitliparviens);


if (vecumsSkaitli2 >= 18)
    Console.WriteLine("Tu esi pilngadīgs");
else
    Console.WriteLine("Tu esi nepilngadīgs");




Console.WriteLine();
Console.WriteLine("===================III uzdevums==========================");
Console.WriteLine();

Console.WriteLine("Programma atradīs lielāko skaitli");
Console.WriteLine("Ievadi pirmo skaitli:");
string Skaitlis1L = Console.ReadLine();
int Skaitliscipars1L = int.Parse(Skaitlis1L);

Console.WriteLine("Ievadi otro skaitli:");
string Skaitlis2L = Console.ReadLine();
int Skaitliscipars2L = int.Parse(Skaitlis2L);
int lielakaisSkaitlisNoAbiem = Math.Max(Skaitliscipars2L, Skaitliscipars1L);
Console.WriteLine("Lielākais no abiem skaitļiem ir: " + lielakaisSkaitlisNoAbiem);


Console.WriteLine();
Console.WriteLine("===================IV uzdevums==========================");
Console.WriteLine();

Console.WriteLine("Programma atradīs mazāko skaitli");
Console.WriteLine("Ievadi pirmo skaitli:");
string Skaitlis1 = Console.ReadLine();
int Skaitliscipars1 = int.Parse(Skaitlis1);

Console.WriteLine("Ievadi otro skaitli:");
string Skaitlis2 = Console.ReadLine();
int Skaitliscipars2 = int.Parse(Skaitlis2);
int mazakaisSkaitlisNoAbiem = Math.Min(Skaitliscipars2, Skaitliscipars1);
Console.WriteLine("Mazākais no abiem skaitļiem ir: " + mazakaisSkaitlisNoAbiem);

Console.WriteLine();
Console.WriteLine("===================V uzdevums==========================");
Console.WriteLine();

Console.WriteLine("Programma atradīs skaitļu dalījuma atlikumu!");
Console.WriteLine("Ievadi dalāmu skaitli:");
string dalamais = Console.ReadLine();
int dalamaisint = int.Parse(dalamais);

Console.WriteLine("Ievadi dalītāju (skaitli):");
string dalitajs = Console.ReadLine();
int dalitajsint = int.Parse(dalitajs);

int rezultatsSKdal = dalamaisint % dalitajsint;
Console.WriteLine("Skaitļu dalījuma atlikums ir : " + rezultatsSKdal);


Console.WriteLine();
Console.WriteLine("===================VI uzdevums==========================");
Console.WriteLine();


Console.WriteLine("Programma pateiks vai skaitlis ir pāra vai nepāra skaitlis!");
Console.WriteLine("Ievadi skaitli:");
string PvNskaitlis = Console.ReadLine();
int PvNskaitlisint = int.Parse(PvNskaitlis);
int PvNatlikums = (PvNskaitlisint % 2);


if (PvNatlikums == 1)
    Console.WriteLine("Tas ir nepāra skaitlis");
else
    Console.WriteLine("Tas ir pāra skaitlis");



Console.WriteLine();
Console.WriteLine("===================VII uzdevums==========================");
Console.WriteLine();

Console.WriteLine("Taisnstūra laukuma aprēķinātajs? (cm2)");
Console.WriteLine("Pirmā malu pāra vienas malas garumu (cm):");
string pirMaluparis = Console.ReadLine();
double pirMaluparisInt = double.Parse(pirMaluparis);


Console.WriteLine("Otrā malu pāra vienas malas garumu (cm):");
string otrMaluparis = Console.ReadLine();
double otrMaluparisInt = double.Parse(otrMaluparis);


double laukumsTS = (pirMaluparisInt * otrMaluparisInt);
double apalotslaukumsTS = Math.Round(laukumsTS, 2);
Console.WriteLine($"Taisnstūra laukums ir {apalotslaukumsTS} cm2.");



Console.WriteLine();
Console.WriteLine("===================VIII uzdevums==========================");
Console.WriteLine();

Console.WriteLine("Taisnleņķa vienādsānu trijstūra laukuma aprēķinātajs? (cm2)");
Console.WriteLine("Ievadi katetes garumu (cm):");
string katetesGarums = Console.ReadLine();
double katetesGarumsInt = double.Parse(katetesGarums);

//double rounded = Math.Round(roundableNumber, 2);

double laukums = ((katetesGarumsInt * katetesGarumsInt) / 2);
double apalotslaukums = Math.Round(laukums, 2);
Console.WriteLine($"Taisnleņķa vienādsānu trijstūra laukums ir {apalotslaukums} cm2.");

Console.WriteLine();
Console.WriteLine("===================IX uzdevums==========================");
Console.WriteLine();


Console.WriteLine("Kā Tevi sauc?");
string vards2 = Console.ReadLine();
Console.WriteLine("Kāds ir tavs vecums?");
string vecums2arvardiem = Console.ReadLine();
int vecumsSkaitli = int.Parse(vecums2arvardiem);
Console.WriteLine($"Sveiks {vards2}, tavs vecums ir {vecums2arvardiem}");