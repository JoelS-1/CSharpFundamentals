using _11_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs
{
    class SWAPIService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Person> GetPersonAsync(int id)
        {
            //ask our api for a respone, wait for it here
            HttpResponseMessage response = await _httpClient.GetAsync($"https://swapi.dev/api/people/{id}");

            //if 200(ok), carry on
            if (response.IsSuccessStatusCode)
            {
                //read content of the response as a person object
                Person person = await response.Content.ReadAsAsync<Person>();
                //give person back
                return person;
            }
            //if the response is anything other than 200(ok) give a null
            return null;
        }

        public async Task<Vehicle> GetVehicleAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Vehicle>();
            }
            return null;
        }

        public async Task<T> GetAsync<T>(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response != null)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            return default;
        }

        public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/people/?search=" + query);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<Person>>();
            }
            return null;
        }

        //below is better refactor of searches
        public async Task<SearchResult<T>> GetSearchAsync<T>(string category, string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://swapi.dev/api/{category}/?search={query}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<T>>();
            }
            return null;
        }

        public async Task<SearchResult<Vehicle>> GetVehicleSearchAsync(string query)
        {
            return await GetSearchAsync<Vehicle>("vehicles", query);
        }
    }
}
