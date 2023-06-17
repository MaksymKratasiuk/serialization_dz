using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace serialization_dz
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
    }

    class FractionArray
    {
        private Fraction[] fractions;

        public void InputFractions()
        {
            Console.Write("Enter the number of fractions: ");
            int count = int.Parse(Console.ReadLine());
            fractions = new Fraction[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Fraction {i + 1}");
                Console.Write("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());
                Console.Write("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                fractions[i] = new Fraction { Numerator = numerator, Denominator = denominator };
            }
        }

        public void SerializeFractions(string filePath)
        {
            string json = JsonSerializer.Serialize(fractions);
            File.WriteAllText(filePath, json);
        }

        public void DeserializeFractions(string filePath)
        {
            string json = File.ReadAllText(filePath);
            fractions = JsonSerializer.Deserialize<Fraction[]>(json);
        }
    }

  
}
