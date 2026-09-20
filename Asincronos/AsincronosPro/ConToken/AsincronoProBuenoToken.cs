using System.Diagnostics;

namespace Desayuno.Asincronos.AsincronosPro.ConToken;

public class AsincronoProBuenoToken
{
    public async Task PrepararDesayuno()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(500)); 
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();

        try
        {
            await Cocinar(cts.Token);
            
            cronometro.Stop();
            TimeSpan tiempoTranscurrido = cronometro.Elapsed;
            Console.WriteLine($"Ha tardado: {tiempoTranscurrido}");
        }
        catch (OperationCanceledException)
        {
            cronometro.Stop();
            Console.WriteLine($"¡Se acabó el tiempo! El desayuno tardó más de 500 milisegundos. (Transcurrido: {cronometro.Elapsed})");
        }
    }

    async Task HacerCafe(CancellationToken ct)
    {
        await Task.Delay(200, ct);
    }

    async Task Cocinar(CancellationToken ct)
    {
        await Task.Delay(200, ct);
        await Task.WhenAll(HacerCafe(ct), FreirHuevos(ct), FreirBacon(ct), TostarPan(ct), VertirZumo(ct));
    }

    async Task FreirHuevos(CancellationToken ct)
    {
        await Task.Delay(300, ct);
    }

    async Task FreirBacon(CancellationToken ct)
    {
        await Task.Delay(300, ct);
    }

    async Task TostarPan(CancellationToken ct)
    {
        await Task.Delay(200, ct);
        await UntarMermelada(ct);
    }

    async Task UntarMermelada(CancellationToken ct)
    {
        await Task.Delay(100, ct);
    }

    async Task VertirZumo(CancellationToken ct)
    {
        await Task.Delay(200, ct);
    }
}