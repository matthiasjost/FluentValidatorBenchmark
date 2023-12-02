namespace FluentValidatorBenchmark;
public class Program
{
  public static void Main(string[] args)
  {
    var config = DefaultConfig.Instance;
    var summary = BenchmarkRunner.Run<Benchmarks>(config, args);
  }
}