using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = GetInput();
            GetAge(input);
        }

        static long GetInput()
        {
            System.Console.Write("Enter # of seconds: ");
            long seconds = long.Parse(Console.ReadLine());
            return seconds;
        }

        static void GetAge(long seconds)
        {
            double EarthAge = seconds / 31536000.0;
            double MercuryAge = seconds / 7600608.0;
            double VenusAge = seconds / 19414080.0;
            double MarsAge = seconds / (31536000.0 * 1.88);
            double JupiterAge  = seconds / (31536000.0 * 11.86);
            double SaturnAge  = seconds / (31536000.0 * 29.46);
            double UranusAge  = seconds / (31536000.0 * 84.01);
            double NeptuneAge  = seconds / (31536000.0 * 164.79);
            double PlutoAge  = seconds / (31536000.0 * 248.59);

            string Ageis = "Your age on ";
            
            System.Console.WriteLine(Ageis + "Earth is " + EarthAge);
            System.Console.WriteLine(Ageis + "Mercury is " + MercuryAge);
            System.Console.WriteLine(Ageis + "Venus is " + VenusAge);
            System.Console.WriteLine(Ageis + "Mars is " + MarsAge);
            System.Console.WriteLine(Ageis + "Jupiter is " + JupiterAge);
            System.Console.WriteLine(Ageis + "Saturn is " + SaturnAge);
            System.Console.WriteLine(Ageis + "Uranus is " + UranusAge);
            System.Console.WriteLine(Ageis + "Neptune is " + NeptuneAge);
            System.Console.WriteLine(Ageis + "Pluto is " + PlutoAge);
        }

    }
}
