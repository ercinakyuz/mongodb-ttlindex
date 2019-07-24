using Microsoft.Extensions.Configuration;
using MongoTtlIndexExample.Core.Data.Entity;
using MongoTtlIndexExample.Core.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoTtlIndexExample.ConsoleApp
{
    class Program
    {
        private static readonly CartRepository _cartRepository;
        private static List<Task<Cart>> createCartTasks = new List<Task<Cart>>();
        static Program()
        {
            IConfiguration config = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", true, true)
           .Build();
            _cartRepository = new CartRepository(config);
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 300; i++)
            {
                createCartTasks.Add(_cartRepository.InsertOneAsync(new Cart
                {
                    Type = CartType.Default,
                    ExpireAt = DateTime.UtcNow.AddSeconds(i)
                }));
                Task.Delay(100);
            }

            Task.WhenAll(createCartTasks);

            foreach (var createCartTask in createCartTasks.Select((Value, Index) => new { Value, Index }))
            {
                Console.WriteLine($"{createCartTask.Index}:{{ {createCartTask.Value.Result} }}");
            }
            Console.ReadKey();


        }

    }
}
