using System.Diagnostics;

namespace Desayuno.Sincronos;

public class Sincrono
{
    public void PrepararDesayuno()
    {
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();
        HacerCafe();
        Cocinar();
        FreirHuevos();
        FreirBacon();
        TostarPan();
        UntarMermelada();
        VertirZumo();
        TimeSpan tiempoTranscurrido = cronometro.Elapsed;
        Console.WriteLine("Hecho (sincrono) :)");
        Console.WriteLine($"Ha tardado: {tiempoTranscurrido} ");
    }
    void HacerCafe()
    {
        Thread.Sleep(200);
    }

    void Cocinar()
    {
        Thread.Sleep(200);
    }

    void FreirHuevos()
    {
        Thread.Sleep(300);
    }

    void FreirBacon()
    {
        Thread.Sleep(3000);
    }

    void TostarPan()
    {
        Thread.Sleep(200);
        UntarMermelada();
    }

    void UntarMermelada()
    {
        Thread.Sleep(100);
    }

    void VertirZumo()
    {
        Thread.Sleep(200);
    }
}