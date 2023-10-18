using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;
using System.Security.Cryptography.X509Certificates;

namespace BenchmarkingLoops
{
    [MemoryDiagnoser(true)]
    public class Benchmarks
    {
        private List<Animal> _animals = Animal.CreateListOfAnimals();

        

        //--- METHODS ---
        [Benchmark]
        public void OneLoop() => Animal.OneLoop(_animals);

        [Benchmark]
        public void ThreeLoops() => Animal.ThreeLoops(_animals);
    }
}
