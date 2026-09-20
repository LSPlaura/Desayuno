using System.Diagnostics;

namespace Desayuno;

public class Sincrono
{
    public void PrepararDesayunoSincrono()
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
        Thread.Sleep(3000);
    }
    void Cocinar()
    {
        Thread.Sleep(3000);
    }
    void FreirHuevos()
    {
        Thread.Sleep(4000);
    }
    void FreirBacon()
    {
        Thread.Sleep(3000);
    }
    void TostarPan()
    {
        Thread.Sleep(3000);
    }
    void UntarMermelada()
    {
        Thread.Sleep(1000);
    }
    void VertirZumo()
    {
        Thread.Sleep(2000);
    }
}