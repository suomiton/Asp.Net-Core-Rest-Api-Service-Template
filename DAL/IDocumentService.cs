using System.Collections.Generic;
using System.Threading.Tasks;
using RestService.Models;

namespace RestService.DAL
{
    interface IDocumentService
    {
        Task<IList<Person>> getDocuments();
    }
}