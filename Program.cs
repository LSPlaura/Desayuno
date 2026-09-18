namespace Desayuno;

class Program
{
    static async Task Main(string[] args)
    {
        var sincrono = new Sincrono();
        var asincronoMalo = new AsincronMalo();
        var asincronoPro = new AsincronoPro();
        
        sincrono.PrepararDesayunoSincrono();
        await asincronoMalo.PrepararDesayunoAsincronoMalo();
        await asincronoPro.PrepararDesayunoAsincronoPro();
    }
}