﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStoreAPI.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public string Category { get; set; } = null!;
        public string Author { get; set; } = null!;
    }
}
