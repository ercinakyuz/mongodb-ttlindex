using System;
using System.Runtime.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoTtlIndexExample.Core.Data.Entity
{
    [DataContract]
    public class Cart : BaseMongoEntity
    {
        [DataMember]
        [BsonIgnoreIfDefault]
        public CartType Type { get; set; }

        [DataMember]
        [BsonIgnoreIfDefault]
        public DateTime? ExpireAt { get; set; }


        public override string ToString()
        {
            return $"_id: '{Id}'; type: '{Type}'; expireAt: '{ExpireAt}'";
        }
    }
}
