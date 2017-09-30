using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numOfPictures = uint.Parse(Console.ReadLine());
            uint filterTimePerPicture = uint.Parse(Console.ReadLine());
            byte filterFactor = byte.Parse(Console.ReadLine());
            uint uploadTimePerPicture = uint.Parse(Console.ReadLine());
            uint numOfFilteredPictures = (uint)Math.Ceiling(numOfPictures * (double)filterFactor / 100.0d);
            ulong totalTimeInSeconds = (ulong)numOfPictures * filterTimePerPicture + (ulong)numOfFilteredPictures * uploadTimePerPicture;
            ulong days = totalTimeInSeconds/(3600ul * 24ul);
            totalTimeInSeconds -= 3600ul * 24ul * days;
            byte hours = (byte)(totalTimeInSeconds / 3600);
            totalTimeInSeconds -= 3600ul * hours;
            byte minutes = (byte)(totalTimeInSeconds / 60);
            totalTimeInSeconds -= 60ul * minutes;
            Console.WriteLine($"{days:D1}:{hours:D2}:{minutes:D2}:{totalTimeInSeconds:D2}");
        }
    }
}
