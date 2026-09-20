using System.Diagnostics;

namespace Desayuno.Asincronos.AsincronosPro.SinToken;

public class AsincronoProBueno
{
    public async Task PrepararDesayuno()
    {
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();

        await Cocinar();
            
        cronometro.Stop();
        TimeSpan tiempoTranscurrido = cronometro.Elapsed;
        Console.WriteLine($"Ha tardado: {tiempoTranscurrido}");
    }

    async Task HacerCafe()
    {
        await Task.Delay(200);
    }

    async Task Cocinar()
    {
        await Task.Delay(200);
        await Task.WhenAll(HacerCafe(), FreirHuevos(), FreirBacon(), TostarPan(), VertirZumo());
    }

    async Task FreirHuevos()
    {
        await Task.Delay(300);
    }

    async Task FreirBacon()
    {
        await Task.Delay(300);
    }

    async Task TostarPan()
    {
        await Task.Delay(200);
        await UntarMermelada();
    }

    async Task UntarMermelada()
    {
        await Task.Delay(100);
    }

    async Task VertirZumo()
    {
        await Task.Delay(200);
    }
}