using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            uint hours = uint.Parse(Console.ReadLine());
            uint minutes = uint.Parse(Console.ReadLine());
            uint seconds = uint.Parse(Console.ReadLine());
            ulong timeInSeconds = hours * 3600ul + minutes * 60ul + seconds;
            float speed = distanceInMeters / timeInSeconds;
            Console.WriteLine(speed);
            speed *= 3.6f;
            Console.WriteLine(speed);
            speed /= 1.609f;
            Console.WriteLine(speed);
        }
    }
}
