

Random random = new Random();

// Aynı işi for döngüsü ile de yapabilirsiniz, ancak Enumerable.Range daha temiz ve okunabilir bir kod sağlar:

List<int> ints = Enumerable.Range(0, 10).Select(i => random.Next(-100, 100)).ToList();

foreach (var i in ints)
{
    Console.WriteLine("Sayılarımız :"+i);
}

//Enumerable.Range(0, 10)

//Bu metot 0'dan başlayarak 10 tane sayı oluşturur (0,1,2,3,4,5,6,7,8,9)

//1.Çift olan Sayılar 
Console.WriteLine("***********************************");

Console.WriteLine("Cift Sayılar :");
var evenNumbers = ints.Where(i => i % 2 == 0);

foreach (var evenNumber in evenNumbers)
{
    Console.WriteLine($"Cift Sayılar : {evenNumber}");
}

Console.WriteLine("***********************************");

Console.WriteLine("Tek Sayılar :");

var oddNumbers = ints.Where(i => i % 2 != 0);

foreach (var oddNumber in oddNumbers)
{
    Console.WriteLine($"Tek Sayılar : {oddNumber}");
}

Console.WriteLine("***********************************");

Console.WriteLine("Negatif Sayılar :");
//Any() metodunu kullanarak liste içinde negatif sayı var mı diye kontrol ediyoruz.

var negativeNumbers = ints.Where(i => i < 0);

if (!negativeNumbers.Any())
{
    Console.WriteLine("Negatif sayı bulunmamaktadır.");
}
else
{
    foreach( var negativeNumber in negativeNumbers) 
    {
        Console.WriteLine($"Negatif Sayı: {negativeNumber}");

    }
}

Console.WriteLine("***********************************");
Console.WriteLine("Pozitif Sayılar :");

var positiveNumbers = ints.Where(i => i > 0);

if (!positiveNumbers.Any())
{
    Console.WriteLine("Pozitif sayı bulunmamaktadır.");
}
else
{
    foreach (var positiveNumber in positiveNumbers)
    {
        Console.WriteLine($"Pozitif Sayı: {positiveNumber}");
    }
}

Console.WriteLine("***********************************");
Console.WriteLine("15'ten büyük ve 22'den küçük sayılar");

var betweenNumbers = ints.Where(i => i>15 && i < 22);

if (!betweenNumbers.Any())
{
    Console.WriteLine("Bu aralıkta sayı bulunmamaktadır.");
}
else
{
    foreach (var betweenNumber in betweenNumbers)
    {
        Console.WriteLine($"15'ten büyük ve 22'den küçük sayılar: {betweenNumber}");
    }
}

Console.WriteLine("***********************************");
Console.WriteLine("Listedeki her bir sayının karesi :");

var squareNumbers = ints.Select(i => i * i);

foreach (var squareNumber in squareNumbers)
{
    Console.WriteLine($"Karesi : {squareNumber}");
}