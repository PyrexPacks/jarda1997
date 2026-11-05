namespace jarda1997;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ird be hany lap van!");
        long lapok_szama = Convert.ToInt64(Console.ReadLine());
        if (lapok_szama >= 2 && lapok_szama >= 1000)
        {
            Environment.Exit(0);
        }
        
        Console.WriteLine("Ird be az elso sorban hany torott lap van!");
        long elso_sor_torott = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine($"Ird be az elso sorban melyik lapok torottek, a kovetkezo formatumban: pl 1 2 3 4 |  (0-{lapok_szama-1})!");
        string[] elso_sor_torott_lapok = Console.ReadLine().Split(' ');
        
        Console.WriteLine("Ird be a masodik sorban hany torott lap van!");
        long masodik_sor_torott = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine($"Ird be a masodik sorban melyik lapok torottek, a kovetkezo formatumban: pl 1 2 3 4 | (0-{lapok_szama-1}, max)!");
        string[] masodik_sor_torott_lapok = Console.ReadLine().Split(' ');


        for (int n = 1; n <= lapok_szama; n++)
        {
            
        }
    }
}