//Atama ve işlemli atama
int x = 3;
int y = 3;

y = y + 2;
Console.WriteLine(y);

y += 2;
Console.WriteLine(y);

y /= 1;
Console.WriteLine(y);

x *= 2;
Console.WriteLine(x);

//Mantıksal Operatörler
// ||, &&, !

bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
{
    Console.WriteLine("Perfect!");
}
else if (isSuccess || isCompleted)
{
    Console.WriteLine("Great!");
}
else if (isSuccess && !isCompleted)
{
    Console.WriteLine("Fine!");
}

//İlişkisel Operatörler
// <, >, <=, >=, ==, !=

int a = 3;
int b = 4;
bool sonuc = a < b;
Console.WriteLine(sonuc);

sonuc = a > b;
Console.WriteLine(sonuc);

sonuc = a >= b;
Console.WriteLine(sonuc);

sonuc = a <= b;
Console.WriteLine(sonuc);

sonuc = a == b;
Console.WriteLine(sonuc);

sonuc = a != b;
Console.WriteLine(sonuc);

//Aritmetik Operatörler
// /, *, +, -

int sayi1 = 10;
int sayi2 = 5;

int sonuc1 = sayi1 / sayi2;
Console.WriteLine(sonuc1);

int sonuc2 = sayi1 * sayi2;
Console.WriteLine(sonuc2);

int sonuc3 = sayi1 + sayi2;
Console.WriteLine(sonuc3);

int sonuc4 = sayi1++;
Console.WriteLine(sonuc4);

// % mod almak için kullanılır
int sonuc5 = 20 % 3;
Console.WriteLine(sonuc5);