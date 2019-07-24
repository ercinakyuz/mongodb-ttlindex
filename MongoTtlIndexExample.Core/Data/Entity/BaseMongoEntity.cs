﻿using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoTtlIndexExample.Core.Data.Entity
{

    [DataContract]
    public abstract class BaseMongoEntity : IEntity<string>
    {

        [BsonId]
        [DataMember]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public virtual string Id { get; set; }

    }
}