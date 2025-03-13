// Kullanıcıdan iki sayı alıp toplamını ekrana yazdıran bir program yazın.

Console.WriteLine("Konsola yazmak istediğiniz sayıları sırayla giriniz : ");

int userNumberOne = Convert.ToInt32(Console.ReadLine());
int userNumberTwo = Convert.ToInt32(Console.ReadLine());
int sum = userNumberOne + userNumberTwo;

Console.WriteLine($"Yazdığınız sayıların toplamı : {sum}");