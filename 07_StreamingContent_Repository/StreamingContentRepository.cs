using _07_StreamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD methods below (create read update delete)
        //create
        //content

        public bool AddContentToDirectory(StreamingContent newContent) //just taking in newContent and putting it into our _currentDirectory list
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //movie
        public bool AddContentToDirectory(Movie newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //show

        //episode

        //read all
        //content read all

            public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        //movie read all
        public List<Movie> GetMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add(content as Movie);
                }
            }
            return allMovies;
        }

        //show read all
        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();

            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.GetType() == typeof(Show))
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }

        //episode read all


        //get by title
        //contnet

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        //movie

        public Movie GetMovieByTitle(string title)
        {
            foreach(StreamingContent movie in _contentDirectory)
            {                            //using 'is' to make sure movie 'is' fo class type Movie
                if(movie.Title.ToLower() == title.ToLower() && movie is Movie)
                {
                    //using 'as' to cast movie into Movie
                    return movie as Movie;
                }
            }
            return null;
        }

        //show
        //get show by title\
        //accessor // return type // name (parameters)
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent show in _contentDirectory)
            {
                if(show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;

        }

        //episode

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContentValues)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if(oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;
                oldContent.MaturityRating = newContentValues.MaturityRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(string titleToDelete)
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete);

            if(contentToDelete == null)
            {
                return false;
            }
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }
    }
}
