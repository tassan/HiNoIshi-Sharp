using HiNoIshi.Domain.Core.CharacterData;
using MongoDB.Bson.Serialization;

namespace HiNoIshi.Infra.Persistence.Mappings
{
    public class CharacterMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Character>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                //map.MapMember(x => x.).SetIsRequired(true);
            }); 
        }
    }
}