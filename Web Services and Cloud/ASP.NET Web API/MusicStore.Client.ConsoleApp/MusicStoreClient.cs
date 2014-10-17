namespace MusicStore.Client.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Xml;
    using MusicStore.Services;
    using Newtonsoft.Json;

    public static class MusicStoreClient
    {
        private static readonly HttpClient Client;

        static MusicStoreClient()
        {
            Client = new HttpClient { BaseAddress = new Uri("http://localhost:55885/api/") };
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // JSON
            //Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml")); // XML
        }

        public static void Add<T>(T obj)
        {
            //var response = Client.PostAsJsonAsync(typeof(T).Name.ToLower() + "s", obj).Result; // JSON
            var response = Client.PostAsXmlAsync(typeof(T).Name.ToLower() + "s", obj).Result; // XML

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("({0}) Successfully added {1}!", (int)response.StatusCode, typeof(T).Name.ToLower());
                var item = response.Content.ReadAsStringAsync().Result;
                PrintItem(typeof(T).Name, item); // JSON
                //Console.WriteLine(item); // XML
            }
            else
            {
                Console.WriteLine("({0}) {1}", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void GetAll<T>()
        {
            var response = Client.GetAsync(typeof(T).Name.ToLower() + "s").Result;

            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsStringAsync().Result;
                PrintItemCollection(typeof(T).Name, items); // JSON
                //Console.WriteLine(items); // XML
            }
            else
            {
                Console.WriteLine("({0}) {1}", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void GetById<T>(int id)
        {
            var response = Client.GetAsync(typeof(T).Name.ToLower() + "s/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                var item = response.Content.ReadAsStringAsync().Result;
                PrintItem(typeof(T).Name, item); // JSON
                //Console.WriteLine(item); // XML
            }
            else
            {
                Console.WriteLine("({0}) {1}", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void Update<T>(int id, T obj)
        {
            var response = Client.PutAsJsonAsync(typeof(T).Name.ToLower() + "s/" + id, obj).Result; // JSON
            //var response = Client.PutAsXmlAsync(typeof(T).Name.ToLower() + "s/" + id, obj).Result; // XML

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("({0}) Successfully updated {1}!", (int)response.StatusCode, typeof(T).Name.ToLower());
                var item = response.Content.ReadAsStringAsync().Result;
                PrintItem(typeof(T).Name, item); // JSON
                //Console.WriteLine(item); // XML
            }
            else
            {
                Console.WriteLine("({0}) {1}", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void Delete<T>(int id)
        {
            var response = Client.DeleteAsync(typeof(T).Name.ToLower() + "s/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("({0}) Successfully deleted {1}!", (int)response.StatusCode, typeof(T).Name.ToLower());
                var item = response.Content.ReadAsStringAsync().Result;
                PrintItem(typeof(T).Name, item); // JSON
                //Console.WriteLine(item); // XML
            }
            else
            {
                Console.WriteLine("({0}) {1}", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static void PrintItem(string type, string item)
        {
            switch (type)
            {
                case "Album":
                {
                    var itemObj = JsonConvert.DeserializeObject<AlbumApi>(item);
                    Console.WriteLine(itemObj);
                    return;
                }
                case "Artist":
                {
                    var itemObj = JsonConvert.DeserializeObject<ArtistApi>(item);
                    Console.WriteLine(itemObj);
                    return;
                }
                case "Song":
                {
                    var itemObj = JsonConvert.DeserializeObject<SongApi>(item);
                    Console.WriteLine(itemObj);
                    return;                
                }
            }
        }

        private static void PrintItemCollection(string type, string items)
        {
            switch (type)
            {
                case "Album":
                    {
                        foreach (var item in JsonConvert.DeserializeObject<IEnumerable<AlbumFullApi>>(items))
                        {
                            Console.WriteLine(item);
                        }

                        return;
                    }
                case "Artist":
                    {
                        foreach (var item in JsonConvert.DeserializeObject<IEnumerable<ArtistFullApi>>(items))
                        {
                            Console.WriteLine(item);
                        }

                        return;
                    }
                case "Song":
                    {
                        foreach (var item in JsonConvert.DeserializeObject<IEnumerable<SongFullApi>>(items))
                        {
                            Console.WriteLine(item);
                        }

                        return;
                    }
            }
        }
    }
}
