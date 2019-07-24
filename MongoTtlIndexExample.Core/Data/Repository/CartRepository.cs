using Microsoft.Extensions.Configuration;
using MongoTtlIndexExample.Core.Data.Entity;

namespace MongoTtlIndexExample.Core.Data.Repository
{
    public class CartRepository : BaseMongoRepository<Cart, string>
    {
        public CartRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
