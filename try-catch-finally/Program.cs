try 
{
    Console.WriteLine("Doğum yılınız:");
    int year = Convert.ToInt32(Console.ReadLine());

}
catch (Exception ex)
{
    Console.WriteLine("Geçerli bir yıl giriniz!");
    Console.WriteLine(ex.Message.ToString());
}
finally 
{
    Console.WriteLine("Tamamdır...");
}

try
{
    int x = int.Parse(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer...");
    Console.WriteLine(ex);
}