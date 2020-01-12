﻿using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;


namespace WikiLib
{
    public static class Wiki
    {
        public async static Task<Collection<WikiPerson>> WikiSearch(string name)
        {
            var urlBase = "https://query.wikidata.org/sparql";
            var query = "SELECT distinct (SAMPLE(?image)as ?image) ?item ?itemLabel ?itemDescription" +
                " (SAMPLE(?DR) as ?DR)(SAMPLE(?RIP) as ?RIP)(SAMPLE(?article) as ?article) " +
                "WHERE {?item wdt:P31 wd:Q5. ?item ?label '" + name + "'@en. OPTIONAL{?item wdt:P569 ?DR .}" +
                " ?article schema:about ?item . ?article schema:inLanguage 'en'. ?article schema:isPartOf <https://en.wikipedia.org/>. " +
                "OPTIONAL{?item wdt:P570 ?RIP .} " +
                "OPTIONAL{?item wdt:P18 ?image .} " +
                "SERVICE wikibase:label { bd:serviceParam wikibase:language 'en'. }} " +
                "GROUP BY ?item ?itemLabel ?itemDescription";
            var url = urlBase + "?query=" + query + "&format=json";
            var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.88 Safari/537.36");
            var json = await client.GetStringAsync(url);
            var doc = JsonDocument.Parse(json);
            //var names = doc.RootElement.EnumerateObject().Select(p => p.Name);

            

            //var entities = results["results"]["bindings"];
            //var count = entities.Count();
            //var FoundPersons = new Collection<WikiPerson>();
            /*
            foreach (JToken item in entities)
            {

                int item1;
                item1 = int.TryParse(item["item"]["value"].ToString().Substring(32), out item1) ? item1 : 0;
                var itemname = item["itemLabel"]["value"].ToString();

                var description1 = String.Empty;
                var description = item["itemDescription"];
                if (description != null)
                {
                    description1 = description["value"].ToString();
                }

                DateTime birthday1 = DateTime.MinValue;
                DateTime? birthday2 = null;
                var birthday = item["DR"];
                if (birthday != null)
                {
                    birthday2 = DateTime.TryParse(birthday["value"].ToString(), out birthday1) ? birthday1 : birthday2;
                }

                DateTime death1 = DateTime.MinValue;
                DateTime? death2 = null;
                var death = item["RIP"];
                if (death != null)
                {
                    death2 = DateTime.TryParse(death["value"].ToString(), out death1) ? death1 : death2;
                }

                var image1 = string.Empty;
                var image = item["image"];
                if (image != null)
                {
                    image1 = image["value"].ToString();
                }

                var link = item["article"]["value"].ToString();
                //var rating = 10;

                var person = new WikiPerson
                {
                    Id = item1,
                    Name = itemname,
                    Description = description1,
                    Birthday = birthday2,
                    Death = death2,
                    Image = image1,
                    Link = link,
                    //Rating = rating
                };
                FoundPersons.Add(person);
            }
            */

            return FoundPersons;
        }
    }
}
