namespace Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId Id);
    Task AddAsync(Customer customer);
}
