using BenchmarkDotNet.Running;
using BenchmarkingLoops;

BenchmarkDotNet.Reports.Summary _ = BenchmarkRunner.Run<Benchmarks>();