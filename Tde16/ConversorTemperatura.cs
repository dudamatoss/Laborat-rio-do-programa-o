public static class ConversorTemperatura
{
    public static double CelsiusParaFahrenheit(double celsius)
    {
        return(celsius*9/5)+32;

    }

    public static double FahrenheitParaCelsius(double fahenheit)
    {
        return (fahenheit - 32) * 5/9;
    }
}