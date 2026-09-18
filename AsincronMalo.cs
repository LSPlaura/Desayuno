using System.Diagnostics;

namespace Desayuno;

public class AsincronMalo
{
    public async Task PrepararDesayunoAsincronoMalo()
    {
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();
        await HacerCafe();
        await Cocinar();
        await FreirHuevos();
        await FreirBacon();
        await TostarPan();
        await UntarMermelada();
        await VertirZumo();
        cronometro.Stop();
        TimeSpan tiempoTranscurrido = cronometro.Elapsed;
        Console.WriteLine("Hecho (asincrono malo) :)");
        Console.WriteLine($"Ha tardado: {tiempoTranscurrido} ");

        async Task HacerCafe()
        {
            await Task.Delay(3000);
        }

        async Task Cocinar()
        {
            await Task.Delay(3000);
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
}