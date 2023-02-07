string imie = "Ewa";
bool kobieta = false;
int wiek = 9;

if (imie == "Ewa" && kobieta == true && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (kobieta == true && wiek < 30)
{
    Console.WriteLine("kobieta poniżej 30lat");
}
else if (kobieta == false && wiek < 10 || wiek > 60)
{
    Console.WriteLine("Mały chłopiec a być może dziaduś po 60ce");
}
else if (kobieta == false && wiek < 18 && wiek > 10)
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("jakaś inna osoba");
}