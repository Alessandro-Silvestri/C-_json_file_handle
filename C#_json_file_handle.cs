// 2 important method:
// JsonConvert.SerializeObject();
// JsonConvert.DeserializeObject();


// install this dependency
using Newtonsoft.Json;

namespace dir_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Json file
            string json = @"{
            'Name': 'Bad Boys',
            'ReleaseDate': '1995-4-7T00:00:00',
            'Genres': [
                'Action',
                'Comedy'
            ]
            }";

            // creating the object using the class Movie with the method DeserializeObject()
            var jsonObj = JsonConvert.DeserializeObject<Movie>(json);

            // using the object for parsing
            Console.WriteLine(jsonObj.Genres[1]);
        }
      
        // first create the class that contains the variable withe the same key names of the Json file
        class Movie
        {
            public string Name;
            public string ReleaseDate;
            public List<string> Genres;
        }
    }
}
