using System.Diagnostics;

namespace Desayuno;

public class AsincronoMaloToken
{
    public async Task PrepararDesayuno()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(500)); 
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();
        try
        {
            await HacerCafe(cts.Token);
            await Cocinar(cts.Token);
            await FreirHuevos(cts.Token);
            await FreirBacon(cts.Token);
            await TostarPan(cts.Token);
            await UntarMermelada(cts.Token);
            await VertirZumo(cts.Token);
            cronometro.Stop();
            TimeSpan tiempoTranscurrido = cronometro.Elapsed;
            Console.WriteLine($"Ha tardado: {tiempoTranscurrido} ");
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