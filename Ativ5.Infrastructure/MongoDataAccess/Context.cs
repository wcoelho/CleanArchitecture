namespace Ativ5.Infrastructure.MongoDataAccess
{
    using Ativ5.Domain;
    using Ativ5.Domain.Baskets;
    using Ativ5.Domain.Customers;
    using MongoDB.Bson.Serialization;
    using MongoDB.Driver;

    public class Context
    {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase database;

        public Context(string connectionString, string databaseName)
        {
            this.mongoClient = new MongoClient(connectionString);
            this.database = mongoClient.GetDatabase(databaseName);
            Map();
        }

        public IMongoCollection<Author> Authors
        {
            get
            {
                return database.GetCollection<Author>("Authors");
            }
        }

        public IMongoCollection<Customer> Customers
        {
            get
            {
                return database.GetCollection<Customer>("Customers");
            }
        }

        public IMongoCollection<Basket> Baskets
        {
            get
            {
                return database.GetCollection<Basket>("Baskets");
            }
        }

        public IMongoCollection<Book> Books
        {
            get
            {
                return database.GetCollection<Book>("Books");
            }
        }

        public IMongoCollection<Order> Orders
        {
            get
            {
                return database.GetCollection<Order>("Orders");
            }
        }

        private void Map()
        {
            BsonClassMap.RegisterClassMap<Entity>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Basket>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Author>(cm =>
            {
                cm.AutoMap();
            });


            BsonClassMap.RegisterClassMap<Book>(cm =>
            {
                cm.AutoMap();
                cm.SetIsRootClass(true);
                cm.AddKnownType(typeof(Removal));
                cm.AddKnownType(typeof(Addition));
            });

            BsonClassMap.RegisterClassMap<BookCollection>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<AuthorCollection>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<OrderCollection>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Customer>(cm =>
            {
                cm.AutoMap();
            });
        }
    }
}
