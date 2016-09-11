using System.Collections.Generic;
using System.Threading.Tasks;
using RestService.Models;

namespace RestService.DAL
{
    public interface IDocumentService
    {
        Task<IList<Person>> GetPersons();
        Task<Person> GetPerson(int id);
        Task InsertPerson(Person person);
        Task UpdatePerson(Person person);
        Task DeletePerson(int id);
    }
}