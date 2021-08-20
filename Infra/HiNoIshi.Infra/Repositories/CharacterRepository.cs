using HiNoIshi.Domain.Core.CharacterData;
using HiNoIshi.Domain.Interfaces;
using HiNoIshi.Domain.Interfaces.Repositories;

namespace HiNoIshi.Infra.Repositories
{
    public class CharacterRepository : BaseRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(IMongoContext context) : base(context)
        {
        }
    }
}