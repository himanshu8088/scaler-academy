using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        public static void Main(string[] args)
        {

            TextReader inputStream = Console.In;
            TextWriter outputStream = Console.Out;
            var inputs = new List<Input>();

            int numberOfTestCase = int.Parse(inputStream.ReadLine());

            for (int i = 0; i < numberOfTestCase; i++)
            {
                var input = new Input();
                input.A = new List<int>();

                var line = inputStream.ReadLine();
                var numbers = line.Split(' ');
                int arrSize = int.Parse(numbers[0]);

                for (int j = 1; j <= arrSize; j++)
                {
                    input.A.Add(int.Parse(numbers[j]));
                }
                input.B = int.Parse(inputStream.ReadLine());
                inputs.Add(input);
            }

            var outputs = Solve(inputs);

            foreach (var items in outputs)
            {
                foreach (var item in items)
                {
                    outputStream.Write(item+" ");
                }
                outputStream.WriteLine();
            }

        }

        public static List<List<int>> Solve(List<Input> inputs)
        {
            var outputs = new List<List<int>>();
            foreach (var input in inputs)
            {
                int numberOfRotation = input.B;
                if (input.B > input.A.Count)
                {
                   numberOfRotation = input.B % input.A.Count;
                }

                var firstItems = input.A.Count != numberOfRotation ? input.A.Skip(input.A.Count - numberOfRotation) : new List<int>();
                var secondItems = input.A.Take(numberOfRotation);

                var output = new List<int>();
                output.AddRange(firstItems);
                output.AddRange(secondItems);
                outputs.Add(output);
            }
            return outputs;
        }
    }

    public class Input
    {
        public List<int> A { get; set; }
        public int B { get; set; }
    }
}
