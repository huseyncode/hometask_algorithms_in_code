using System.Runtime.Intrinsics.X86;

// Task 0
Console.WriteLine("eded daxil edin");
int eded0 = Convert.ToInt32(Console.ReadLine());
if (eded0 < 0)
{
    Console.WriteLine("eded menfidir");
}
else if (eded0 == 0)
{
    Console.WriteLine("eded 0dir");
}
else
{
    Console.WriteLine("eded musbetdir");
}

// Task 1
Console.WriteLine("5 eded daxil edin");
int eded11 = Convert.ToInt32(Console.ReadLine());
int eded12 = Convert.ToInt32(Console.ReadLine());
int eded13 = Convert.ToInt32(Console.ReadLine());
int eded14 = Convert.ToInt32(Console.ReadLine());
int eded15 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(eded11 + eded12 + eded13 + eded14 + eded15);

// Task 2
Console.WriteLine("eded daxil edin");
int eded21 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(eded21 * eded21);

// Task 3
Console.WriteLine("3 eded daxil edin");
int eded31 = Convert.ToInt32(Console.ReadLine());
int eded32 = Convert.ToInt32(Console.ReadLine());
int eded33 = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(eded31, Math.Max(eded32, eded33));
Console.WriteLine("en boyuk eded " + max + "dir");

// Task 4
Console.WriteLine("2 eded daxil edin");
int eded41 = Convert.ToInt32(Console.ReadLine());
int eded42 = Convert.ToInt32(Console.ReadLine());
if (Math.Pow(eded41, 3) > eded42)
{
    Console.WriteLine("birinci ededin kubu ikinci ededden boyukdur");
}
else
{
    Console.WriteLine("birinci ededin kubu ikinci ededden kickdir");
}

// Task 5
Console.WriteLine("eded daxil edin");
int eded51 = Convert.ToInt32(Console.ReadLine());
if (eded51 % 3 == 0 && eded51 % 5 == 0)
{
    Console.WriteLine("eded hem 3e hem 5 e bolunendir");
}
else
{
    Console.WriteLine("eded hem 3e hem 5 e bolunen deyildir");
}

// Task 6
Console.WriteLine("Kart balansini dail edin");
int eded61 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Mehsulun meblegini  daxil edin");
int eded62 = Convert.ToInt32(Console.ReadLine());
if (eded61 >= eded62)
{
    Console.WriteLine("Kartda yeterli mebleg var");
}
else
{
    Console.WriteLine("Kartda yeterli mebleg yoxdur");
}

// Task 7
Console.WriteLine("5 fenin qiymetlerin daxil edin");
int eded71 = Convert.ToInt32(Console.ReadLine());
int eded72 = Convert.ToInt32(Console.ReadLine());
int eded73 = Convert.ToInt32(Console.ReadLine());
int eded74 = Convert.ToInt32(Console.ReadLine());
int eded75 = Convert.ToInt32(Console.ReadLine());
int ortalam7 = (eded71 + eded72 + eded73 + eded74 + eded75) / 5;
if (100 > ortalam7 && ortalam7 > 65)
{
    Console.WriteLine("oraltamaniz " + ortalam7 + "dir imtahandan kecmisiniz");
}
else if (0 < ortalam7 && ortalam7 < 65)
{
    Console.WriteLine("oraltamaniz " + ortalam7 + "dir imtahandan kecmediniz");
}
else
{
    Console.WriteLine("qiymetler 0 ve 100 araliginda olmalidir!");
}

// Task 8
Console.WriteLine("iki natural eded daxil edin");
int eded81 = Convert.ToInt32(Console.ReadLine());
int eded82 = Convert.ToInt32(Console.ReadLine());
if (eded81 < 0 || eded82 < 0)
{
    Console.WriteLine("eded natural deyil");
}
else if (eded81 < eded82)
{
    Console.WriteLine(eded82 + "ededi daha boyukdur");
}
else if (eded82 < eded81)
{
    Console.WriteLine(eded81 + " ededi daha boyukdur");
}
else
{
    Console.WriteLine("Ededler beraberdir");
}

// Task 9
Console.WriteLine("Temperaturu selsi olarag daxil edin");
int eded91 = Convert.ToInt32(Console.ReadLine());
if (eded91 < 0)
{
    Console.WriteLine("suyun donma temeperaturundan asagidir");
}
else if (eded91 > 0)
{
    Console.WriteLine("suyun donma temeperaturundan yuxaridir");
}
else
{
    Console.WriteLine("suyun donma temeperaturuna beraberdir");
}

// Task 1
int num11 = 0;
while (num11 < 50)
{
    num11++;
    Console.WriteLine(num11);
}

// Task 2
int num21 = 0;
int say2 = 0;
while (num21 < 40)
{
    if (num21 % 3 == 0)
    {
        say2++;
    }
    num21++;
}
Console.WriteLine(say2);

// Task 3
int num31 = 0;
while (num31 <= 100)
{
    if (num31 % 3 == 0 && num31 % 7 == 0)
    {
        Console.WriteLine(num31);
    }
    num31++;
}

// Task 4
Console.WriteLine("eded daxil et");
int num41 = Convert.ToInt32(Console.ReadLine());
int say = 0;
while (num41 > 0)
{
    num41 = num41 / 10;
    say++;

}
Console.WriteLine("reqemlerinin sayi " + say + "dir");

// Task 5
Console.WriteLine("eded daxil et");
int num51 = Convert.ToInt32(Console.ReadLine());
int reqem = 0;
int reverese5 = 0;
while (num51 > 0)
{
    reqem = num51 % 10;
    reverese5 = reverese5 * 10 + reqem;
    num51 = num51 / 10;
}
Console.WriteLine(reverese5);

// Task 6
Console.WriteLine("eded daxil et");
int num61 = Convert.ToInt32(Console.ReadLine());
int fakt = 1;
while (num61 > 0)
{
    fakt = fakt * num61;
    num61 = num61 - 1;
}
Console.WriteLine(fakt);

// Task 7
Console.WriteLine("eded daxil et");
int num71 = Convert.ToInt32(Console.ReadLine());
bool isPrime = true;
for (int i = 2; i < num71; i++)
{
    if (num71 % i == 0)
    {
        isPrime = false;
        break;
    }
}
if (isPrime)
{
    Console.WriteLine("eded sade ededdir");
}
else
{
    Console.WriteLine("eded murekkeb ededdir");
}

// Task 8
Console.WriteLine("eded daxil et");
int num81 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num81 > 0)
{
    sum += num81 % 10;
    num81 /= 10;
}
Console.WriteLine("reqemlerinin cemi " + sum + "dir");

// Task 9
Console.WriteLine("eded daxil et");
int num91 = Convert.ToInt32(Console.ReadLine());
int maxDigit = 0;
while (num91 > 0)
{
    int digit = num91 % 10;
    if (digit > maxDigit)
    {
        maxDigit = digit;
    }
    num91 /= 10;
}
Console.WriteLine("reqemlerinin icinde en boyuk reqem " + maxDigit + "dir");

// Task 10
int num101 = 70;
while (num101 > 0)
{
    if (num101 % 2 == 0)
    {
        Console.WriteLine(num101);
    }
    num101--;
}

// Task 11
Console.WriteLine("ilin feslini daxil edin");
int month = Convert.ToInt32(Console.ReadLine());
string season = "";
switch (month)
{
    case 12:
    case 1:
    case 2:
        season = "Qis";
        break;
    case 3:
    case 4:
    case 5:
        season = "Yaz";
        break;
    case 6:
    case 7:
    case 8:
        season = "Yay";
        break;
    case 9:
    case 10:
    case 11:
        season = "Payiz";
        break;
}
Console.WriteLine(month + ". ay " + season + " feslidir");

// Task 11
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Task 12
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Task 13
for (int i = 9; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
}