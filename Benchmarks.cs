namespace FluentValidatorBenchmark;

[MemoryDiagnoser]
public class Benchmarks
{
  [Params(10000)]
  public int NumCustomers { get; set; }

  [Benchmark(Baseline = true)]
  public void ReuseValidatorScenario()
  {
    var list = new List<Customer>();
    for (int i = 0; i < NumCustomers; i++)
    {
      list.Add(new Customer
      {
        Id = i,
        Surname = "Smith",
        Forename = "John",
        Address = "1 Street",
        Discount = 20
      });
    }
    var validator = new CustomerValidator();

    foreach (var customer in list)
    {
      var result = validator.Validate(customer);
    }
  }

  [Benchmark]
  public void NewValidatorScenario()
  {
    var customers = new List<Customer>();
    var validators = new List<CustomerValidator>();
    for (int i = 0; i < NumCustomers; i++)
    {
      customers.Add(new Customer
      {
        Id = i,
        Surname = "Smith",
        Forename = "John",
        Address = "1 Street",
        Discount = 20
      });
    }
    for (int i = 0; i < NumCustomers; i++)
    {
      validators.Add(new CustomerValidator());
    }
    foreach (var validator in validators)
    {
      var result = validator.Validate(customers.FirstOrDefault());
    }
  }
}
