namespace jarda1997;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ird be hany lap van!");
        long lapok_szama = Convert.ToInt64(Console.ReadLine());
        if (lapok_szama < 2 || lapok_szama >= 1000)
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
        string[] elso_sor_torott_lapok = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); // ai segitseg

        if (elso_sor_torott_lapok.Length != elso_sor_torott)
        {
            Thread.Sleep(1000);
            Environment.Exit(0);
        } 
        
        Console.WriteLine("Ird be a masodik sorban hany torott lap van!");
        long masodik_sor_torott = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine($"Ird be a masodik sorban melyik lapok torottek, a kovetkezo formatumban: pl 1 2 3 4 | (0-{lapok_szama-1}, max)!");
        string[] masodik_sor_torott_lapok = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
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
        
        for (int u = 0; u < lapok_szama_elso.Length; u++) Console.Write($"{lapok_szama_elso[u]} ");
        Console.WriteLine();
        for (int o = 0; o < lapok_szama_masodik.Length; o++) Console.Write($"{lapok_szama_masodik[o]} ");
        Console.WriteLine();


        for (int n = 0; n < lapok_szama; n++)
        {
            if (lapok_szama_elso[n] == 1)
            {
                if (lapok_szama_masodik[n] == 1)
                {
                    lapok_szama_masodik[n] = 0;
                }
                else if (n + 1 < lapok_szama && lapok_szama_elso[n + 1] == 1)
                {
                    lapok_szama_elso[n + 1] = 0;
                }
                lapok_szama_elso[n] = 0;
                mennyikell++;
            }

            if (lapok_szama_masodik[n] == 1)
            {
                if (n + 1 < lapok_szama && lapok_szama_masodik[n + 1] == 1)
                {
                    lapok_szama_masodik[n + 1] = 0;
                }
                lapok_szama_masodik[n] = 0;
                mennyikell++;
            }
        }
        Console.WriteLine();
        Console.WriteLine(mennyikell);
    }
}