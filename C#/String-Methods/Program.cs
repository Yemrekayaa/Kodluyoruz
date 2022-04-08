string degisken = "Dersimiz CSharp , Hoşgeldiniz";
string degisken2 = "Dersimiz CSharp";

//Length
Console.WriteLine(degisken.Length);
//ToLower,ToUpper 
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());
//Concat 
Console.WriteLine(String.Concat(degisken, "Merhaba", "Burası 1 den fazla degisken alabilir"));

//CompareTo,Compare
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(String.Compare(degisken, degisken2, true));

//Contains
Console.WriteLine(degisken.Contains(degisken2));

Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
Console.WriteLine(degisken.StartsWith("Merhaba"));

//IndexOf
Console.WriteLine(degisken.IndexOf("CS"));
//LastIndexOf
Console.WriteLine(degisken.LastIndexOf("i"));

//Insert
Console.WriteLine(degisken.Insert(0, "Merhaba"));

//PadLeft,PadRight
Console.WriteLine(degisken + degisken2.PadLeft(30));     
Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
Console.WriteLine(degisken.PadRight(50) + degisken2);
Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

//Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5, 3));
Console.WriteLine(degisken.Remove(0, 1));

//Replace
Console.WriteLine(degisken.Replace("CSharp", "C#"));
Console.WriteLine(degisken.Replace(" ", "*"));

//Split
Console.WriteLine(degisken.Split(' ')[1]);

//Substring
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4, 6));