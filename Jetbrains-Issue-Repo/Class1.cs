using EFT;
using EFT.Weather;

namespace Jetbrains_Issue_Repo;

public class Class1
{
    public static void Method1()
    {
        var weatherController = new WeatherController();

        weatherController.WeatherDebug.Fog = 0;
    }
}
