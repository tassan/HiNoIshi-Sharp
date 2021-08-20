using HiNoIshi.Domain.Core;
using HiNoIshi.Domain.Core.CharacterData;
using MongoDB.Bson.Serialization;

namespace HiNoIshi.Infra.Persistence.Mappings
{
    public class CharacterMap
    {
        public static void Configure()
        {
            // BsonClassMap.RegisterClassMap<Entity>(map =>
            // {
            //     map.AutoMap();
            //     map.MapIdMember(x => x.Id);
            // });
            
            BsonClassMap.RegisterClassMap<Character>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                //map.MapMember(x => x.).SetIsRequired(true);
            }); 
        }
    }
}