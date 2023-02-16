using System.Diagnostics.Metrics;

int[] oceny = new int[365];
string[] dniTygodnia = new string[7];
dniTygodnia[0] = "poniedzialek";
dniTygodnia[1] = "wtorek";
dniTygodnia[2] = "sroda";
dniTygodnia[3] = "czwartek";
dniTygodnia[4] = "piatek";
dniTygodnia[5] = "sobota";
dniTygodnia[6] = "niedziela";


for (int i=0 ;i<dniTygodnia.Length; i =i+2 ) 
{
    //Console.WriteLine(dniTygodnia[i]);
}






List<string> dniiTygodnia = new List<string>();
dniiTygodnia.Add("poniedzialek");
dniiTygodnia.Add("wtorek");
dniiTygodnia.Add("sroda");
dniiTygodnia.Add("czwartek");
dniiTygodnia.Add("piatek");
dniiTygodnia.Add("sobota");
dniiTygodnia.Add("niedziela");


foreach (string dnii in dniiTygodnia)
{
    //Console.WriteLine(dnii);
}


int numer = 4566;
string numerInString = numer.ToString();
char[] listy = numerInString.ToArray();

//Console.WriteLine(numerInString);





int liczba = 8442;
string liczbaNaTekst = liczba.ToString();
char[] letters = liczbaNaTekst.ToArray();

int licznik0 = 0;
int licznik1 = 0;
int licznik2 = 0;
int licznik3 = 0;
int licznik4 = 0;
int licznik5 = 0;
int licznik6 = 0;
int licznik7 = 0;
int licznik8 = 0;
int licznik9 = 0;

foreach (char list in letters)
{
    if (list == '0')
    {
        licznik0++;
    }
    else if (list == '1')
    {
        licznik1++;
    }
    else if (list == '2')
    {
        licznik2++;
    }
    else if (list == '3')
    {
        licznik3++;
    }
    else if (list == '4')
    {
        licznik4++;
    }
    else if (list == '5')
    {
        licznik5++;
    }
    else if (list == '6')
    {
        licznik6++;
    }
    else if (list == '7')
    {
        licznik7++;
    }
    else if (list == '8')
    {
        licznik8++;
    }
    else if (list == '9')
    {
        licznik9++;
    }
    
}

Console.WriteLine("0 w tej liczbie jest " + licznik0);
Console.WriteLine("1 w tej liczbie jest " + licznik1);
Console.WriteLine("2 w tej liczbie jest " + licznik2);
Console.WriteLine("3 w tej liczbie jest " + licznik3);
Console.WriteLine("4 w tej liczbie jest " + licznik4);
Console.WriteLine("5 w tej liczbie jest " + licznik5);
Console.WriteLine("6 w tej liczbie jest " + licznik6);
Console.WriteLine("7 w tej liczbie jest " + licznik7);
Console.WriteLine("8 w tej liczbie jest " + licznik8);
Console.WriteLine("9 w tej liczbie jest " + licznik9);