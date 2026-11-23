namespace jarda1997;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ird be hany lap van!");
        long lapok_szama = Convert.ToInt64(Console.ReadLine());
        if (lapok_szama >= 2 && lapok_szama >= 1000)
        {
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        long mennyikell = 0;

        long[] lapok_szama_elso = new long[lapok_szama];
        long[] lapok_szama_masodik = new long[lapok_szama];
        
        Console.WriteLine("Ird be az elso sorban hany torott lap van!");
        long elso_sor_torott = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine($"Ird be az elso sorban melyik lapok torottek, a kovetkezo formatumban: pl 1 2 3 4 |  (0-{lapok_szama-1})!");
        string[] elso_sor_torott_lapok = Console.ReadLine().Split(' ');

        if (elso_sor_torott_lapok.Length != elso_sor_torott)
        {
            Thread.Sleep(1000);
            Environment.Exit(0);
        } 
        
        Console.WriteLine("Ird be a masodik sorban hany torott lap van!");
        long masodik_sor_torott = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine($"Ird be a masodik sorban melyik lapok torottek, a kovetkezo formatumban: pl 1 2 3 4 | (0-{lapok_szama-1}, max)!");
        string[] masodik_sor_torott_lapok = Console.ReadLine().Split(' ');
        
        if (masodik_sor_torott_lapok.Length != masodik_sor_torott)
        {
            Thread.Sleep(1000);
            Environment.Exit(0);
        } 
        
        for (int i = 0; i < elso_sor_torott; i++)
        {
            int idx = Convert.ToInt32(elso_sor_torott_lapok[i]);
            lapok_szama_elso[idx] = 1;
        }

        for (int i = 0; i < masodik_sor_torott; i++)
        {
            int idx = Convert.ToInt32(masodik_sor_torott_lapok[i]);
            lapok_szama_masodik[idx] = 1;
        }


        for (int n = 0; n < lapok_szama; n++)
        {
            if (lapok_szama_elso[n] == 1)
            {
                if (lapok_szama_elso[n] + 1 == 1)
                {
                    mennyikell++;
                    Console.WriteLine($"n+1 {mennyikell} - {lapok_szama_elso[n]} -  {lapok_szama_elso[n] + 1}");
                    continue;
                }

                if (lapok_szama_masodik[n] == 1)
                {
                    mennyikell++;
                    Console.WriteLine($"n masodik {mennyikell} - {lapok_szama_masodik[n]} -  {lapok_szama_masodik[n] + 1}");
                    continue;
                }

                mennyikell++;
                Console.WriteLine($"sima n {mennyikell} - {lapok_szama_masodik[n]} -  {lapok_szama_masodik[n] + 1}");

            }
        }
        Console.WriteLine();
        Console.WriteLine(mennyikell);
    }
}