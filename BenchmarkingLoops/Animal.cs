

namespace BenchmarkingLoops
{
    public class Animal
    {
        static Random Randomizer = new Random();

        public Animal(string name, double size, string color)
        {
            this.Name = name;
            this.Size = size;
            this.Color = color;
        }

        public string Name { get; set; }
        public double Size { get; set; }
        public string Color { get; set; }

        public static double OneLoop(List<Animal> animals)
        {
            double result = 0;

            foreach (var animal in animals)
            {
                if (!animal.Color.StartsWith("aaa")) animal.Color = "brown";
                int temp = (int)animal.Size * 6 + 24;
                result += Math.Sqrt(temp);
            }

            return result;
        }

        public static double ThreeLoops(List<Animal> animals)
        {
            double result = 0;
            int temp = 0;

            foreach (var animal in animals)
            {
                if (!animal.Color.StartsWith("aaa")) animal.Color = "brown";
            }

            foreach (var animal in animals)
            {
                temp = (int)animal.Size * 6 + 24;
            }

            foreach (var animal in animals)
            {
                result += Math.Sqrt(temp);
            }

            return result;
        }

        public static List<Animal> CreateListOfAnimals()
        {
            List<Animal> animals = new List<Animal>();

            for (int i = 0; i < 100000; i++)
            {
                animals.Add(new(i.ToString(), Randomizer.NextDouble(), "green"));
            }

            return animals;
        }
    }
}
