using Desayuno;
using Desayuno.Asincronos.AsincronosPro.ConToken;
using Desayuno.Asincronos.AsincronosPro.SinToken;
using Desayuno.Sincronos;

namespace Desayuno;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== Iniciando: Sincrono ===");
        var sincrono = new Sincrono();
        sincrono.PrepararDesayuno();

        Console.WriteLine();
        
        Console.WriteLine("=== Iniciando: AsincronMalo ===");
        var asincronMalo = new AsincronMalo();
        await asincronMalo.PrepararDesayuno();

        Console.WriteLine();
        
        Console.WriteLine("=== Iniciando: AsincronoMaloToken ===");
        var asincronoMaloToken = new AsincronoMaloToken();
        await asincronoMaloToken.PrepararDesayuno();

        Console.WriteLine();

        // 4. Asincrono Pro Bueno (Sin Token)
        Console.WriteLine("=== Iniciando: AsincronoProBueno ===");
        var asincronoProBueno = new AsincronoProBueno();
        await asincronoProBueno.PrepararDesayuno();

        Console.WriteLine();
        
        Console.WriteLine("=== Iniciando: AsincronoProBuenoToken ===");
        var asincronoProBuenoToken = new AsincronoProBuenoToken();
        await asincronoProBuenoToken.PrepararDesayuno();
        
        Console.WriteLine();
        
        Console.WriteLine("=== Iniciando: AsincronoProMalo ===");
        var asincronoProMalo = new AsincronoProMalo();
        await asincronoProMalo.PrepararDesayuno();

        Console.WriteLine();
        
        Console.WriteLine("=== Iniciando: AsincronoProMaloToken ===");
        var asincronoProMaloToken = new AsincronoProMaloToken();
        await asincronoProMaloToken.PrepararDesayuno();
    }
}