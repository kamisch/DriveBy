using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yelp.Api;
using Yelp.Api.Models;

namespace test{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args) {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            Task.Run(async () => {
                await AsyncMain(args);
            }).GetAwaiter().GetResult();;
        }

        static async Task AsyncMain(string[] args) {
            Console.WriteLine("Hello World");

            var client = new Yelp.Api.Client("aH_2cWcPiZ4d-HQoo4B6iE_lsEM199j3cIH5RoKErtdKwPLc6ugHKKljAqfrx_hJXE-pXClCYrcK3VoRKFnUmgEqDAhEpCHj8GN9420tUO-4wK5gzJzCBDohs0cBWnYx");
            await search(client);
        }

        static async Task<IList<BusinessResponse>> search(Yelp.Api.Client client) {
            SearchResponse results = await client.SearchBusinessesAllAsync("cupcakes", 37.786882, -122.399972);

            foreach (var b in results.Businesses) {
                Console.WriteLine(b.Name);
                Console.WriteLine(b.Location);
                Console.WriteLine(b.Distance);
                Console.WriteLine("");
            }

            return results.Businesses;
        }
    }

}

