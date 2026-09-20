using System.Diagnostics;

namespace Desayuno.Asincronos.AsincronosPro.SinToken;

public class AsincronoProMalo
{
    public async Task PrepararDesayuno()
    {
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();
        var tareas = new List<Func<Task>>
        {
            HacerCafe,
            Cocinar,
            FreirHuevos,
            FreirBacon,
            TostarPan,
            UntarMermelada,
            VertirZumo
        };
        
        await Parallel.ForEachAsync(tareas, async (accion, _) =>
        {
            await accion();
        }); 
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