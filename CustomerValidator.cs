namespace FluentValidatorBenchmark;
public class CustomerValidator : AbstractValidator<Customer>
{
  public CustomerValidator()
  {
    RuleFor(customer => customer.Surname).NotNull();
    RuleFor(customer => customer.Forename).NotNull();
    RuleFor(customer => customer.Address).NotNull();
    RuleFor(customer => customer.Discount).InclusiveBetween(0, 90);
  }
}
