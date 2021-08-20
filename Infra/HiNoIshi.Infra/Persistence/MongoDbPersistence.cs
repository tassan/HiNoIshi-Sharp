using HiNoIshi.Domain.Core.CharacterData;
using HiNoIshi.Infra.Persistence.Mappings;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.Serializers;

namespace HiNoIshi.Infra.Persistence
{
    public static class MongoDbPersistence
    {
        public static void Configure()
        {
            // TODO: Add Mappings
            CharacterMap.Configure();
            
            BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.CSharpLegacy));

            var pack = new ConventionPack
            {
                new IgnoreExtraElementsConvention(true),
                new IgnoreIfDefaultConvention(true)
            };
            ConventionRegistry.Register("HiNoIshi Conventions", pack, t => true);
        }
    }
}