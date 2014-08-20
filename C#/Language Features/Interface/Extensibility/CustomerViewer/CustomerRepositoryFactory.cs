using CustomerRepository.CSV;
using CustomerRepository.Interface;
using CustomerRepository.SQL;
using CustomerRepository.XML;
using System;

namespace CustomerViewer
{
    public static class CustomerRepositoryFactory
    {
        public static ICustomerRepository GetRepository(string repositoryType)
        {
            ICustomerRepository repository;
            switch (repositoryType)
            {
                case "SQL":
                    repository =  new SQLRepository();
                    break;
                case "XML":
                    repository =  new XMLRepository();
                    break;
                case "CSV":
                    repository = new CSVRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid repository type " + repositoryType);
            }
            return repository;
        }
    }
}
