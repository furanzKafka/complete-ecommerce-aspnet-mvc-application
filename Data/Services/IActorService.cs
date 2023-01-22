using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetActor(int id);
        void Add(Actor actor);
        Actor Update(Actor actor);
        void Delete(int id);
    }
}
