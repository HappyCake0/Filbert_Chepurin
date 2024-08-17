using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly CollectContext _context; 
        public PeopleRepository(CollectContext context) 
        {
            _context = context;
        }
        public IEnumerable<Person> GetAllInformationAsync()
        {
            var persons =  _context.Person
         .Include(p => p.Passport)
         .Include(p => p.Debts)
         .ToList();

            return persons;
        }
    }
}
