using System.Diagnostics;

namespace Desayuno;

public class AsincronoPro
{
    public async Task PrepararDesayunoAsincronoPro()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(12));
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();

        try
        {
            await Task.WhenAll(HacerCafe(), Cocinar(), TostarPan(), UntarMermelada(), VertirZumo());
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"¡Se acabó el tiempo! El desayuno tardó más de 5 segundos. (Transcurrido: {{cronometro.Elapsed}})\"");
        }

        TimeSpan tiempoTranscurrido = cronometro.Elapsed;
        Console.WriteLine("Hecho (asincrono malo) :)");
        Console.WriteLine($"Ha tardado: {tiempoTranscurrido} ");
    }

    async Task HacerCafe()
    {
        await Task.Delay(3000);
    }

    async Task Cocinar()
    {
        await Task.Delay(3000);
        await Task.WhenAll(FreirHuevos(), FreirBacon());
    }

    async Task FreirHuevos()
    {
        await Task.Delay(4000);
    }

    async Task FreirBacon()
    {
        await Task.Delay(3000);
    }

    async Task TostarPan()
    {
        await Task.Delay(3000);
    }

    async Task UntarMermelada()
    {
        await Task.Delay(1000);
    }

    async Task VertirZumo()
    {
        await Task.Delay(2000);
    }
}