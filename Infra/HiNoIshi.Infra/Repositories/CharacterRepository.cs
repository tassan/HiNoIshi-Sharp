using HiNoIshi.Domain.Core.CharacterData;
using HiNoIshi.Infra.Interfaces;
using HiNoIshi.Infra.Interfaces.Repositories;

namespace HiNoIshi.Infra.Repositories
{
    public class CharacterRepository : BaseRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(IMongoContext context) : base(context)
        {
        }
    }
}