using CustomerRepository.Interface;
using System;
using System.Configuration;

namespace CustomerViewer
{
    public static class CustomerRepositoryFactory
    {
        public static ICustomerRepository GetRepository()
        {
            ICustomerRepository repository;

            string typeName = ConfigurationManager.AppSettings["RepositoryType"];

            Type repoType = Type.GetType(typeName);
            object repoInstance = Activator.CreateInstance(repoType);
            repository = repoInstance as ICustomerRepository;

            return repository;
        }
    }
}
