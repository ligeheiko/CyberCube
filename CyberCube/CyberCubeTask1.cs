using System;

namespace CyberCube
{
    public class CyberCubeTask1
    {
        public static void AddExtraLetter()
        {
            var random = new Random();
            var chars = "abcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[random.Next(1, 10)];
            stringChars[0] = chars[random.Next(chars.Length)];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var s = new String(stringChars);
            var t = s + stringChars[0];
            var output = stringChars[0];
            Console.WriteLine("s= " + s);
            Console.WriteLine("t= " + t);
            Console.WriteLine("The added letter: " + output);
        }
    }
}
