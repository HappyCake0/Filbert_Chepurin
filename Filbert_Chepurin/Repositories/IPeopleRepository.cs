using Domain;

namespace Presentation.Repository
{
    public interface IPeopleRepository
    { 
        IEnumerable<Person> GetAllInformationAsync();
    }
}
