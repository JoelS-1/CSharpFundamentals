using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class ProgramUI
    {

        private StreamingContentRepository _repo = new StreamingContentRepository();
        private IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine(DateTime.Now);

                _console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                string input = _console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                    case "banana":
                        //create new content
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":
                        //view all content
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        //view content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        //update existing content
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        //delete existing content
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        //exit
                        keepRunning = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number");
                        break;
                }
                _console.WriteLine("Please press any key to continue");
                _console.ReadKey();
                _console.Clear();
            }
        }


        private void CreateNewContent()     //challenge add a confirmation menu before adding to a directory

        {
            _console.Clear();
            StreamingContent newContent = new StreamingContent();

            //title
            _console.WriteLine("What is the title for this content?");
            newContent.Title = _console.ReadLine();

            //discription

            _console.WriteLine("What is the description for this content?");
            newContent.Description = _console.ReadLine();

            //star rating
            _console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0)");
            newContent.StarRating = Convert.ToDouble(_console.ReadLine());

            //genre
            _console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            int genreAsInt = Convert.ToInt32(_console.ReadLine());
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //maturity rating
            _console.WriteLine("Enter the maturity rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG 13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA ");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine());
            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);

            if (wasAddedCorrectly)
            {
                _console.WriteLine("The content was added correctly!");
            }
            else
            {
                _console.WriteLine("Could not add the content.");
            }
        }

        private void DisplayAllContent() //display all content in the directory
        {
            _console.Clear();

            List<StreamingContent> allContent = _repo.GetContents();

            foreach (StreamingContent content in allContent)
            {
                //Console.ForegroundColor = (ConsoleColor.Green);
                Console.WriteLine($"Title:  {content.Title} \n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                //Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() //get a title from the user, then display all properties of the content that has that title
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("What title would you like to search for?");
            string userTitleSearch = _console.ReadLine();

            StreamingContent displayContent = _repo.GetContentByTitle(userTitleSearch);

            //Console.ForegroundColor = (ConsoleColor.Green);

            if (displayContent != null)
            {
                _console.Clear();
                _console.WriteLine("Title: " + displayContent.Title);
                _console.WriteLine("Description: " + displayContent.Description);
                _console.WriteLine("Stars: " + displayContent.StarRating);
                _console.WriteLine("Genre: " + displayContent.TypeOfGenre);
                _console.WriteLine("Maturity Rating: " + displayContent.MaturityRating);
                _console.WriteLine("Is Family Friendly: " + displayContent.IsFamilyFriendly);
            }
            else
            {
                _console.WriteLine("This content does not match");
            }
            //Console.ResetColor();
        }

        private void UpdateContent()
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter the title of the content you would like to update");

            string oldTitle = _console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //title
            _console.WriteLine("What is the title for this content?");
            newContent.Title = _console.ReadLine();

            //discription

            _console.WriteLine("What is the new description for this content?");
            newContent.Description = _console.ReadLine();

            //star rating
            _console.WriteLine("Enter the new Star Rating for this content (0.0 - 5.0)");
            newContent.StarRating = Convert.ToDouble(_console.ReadLine());

            //genre
            _console.WriteLine("Enter the new genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            int genreAsInt = Convert.ToInt32(_console.ReadLine());
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //maturity rating
            _console.WriteLine("Enter the new maturity rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG 13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA ");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine());


            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);

            if (wasUpdated)
            {
                _console.WriteLine("Update successfull!");
            }
            else
            {
                _console.WriteLine("This title does not match any already existing titles");
            }
        }

        private void DeleteContent()
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter the title of the for the content you want to delete");

            bool wasDeleted = _repo.DeleteExistingContent(_console.ReadLine());

            if (wasDeleted)
            {
                _console.WriteLine("The content was deleted successfully");
            }
            else
            {
                _console.WriteLine("No existing title matches the title provided");
            }
        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty is accidentally transported back in time 30 years", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star wars", "Jar Jar saves the day", 3.1, GenreType.SciFi, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "A car tire comes to life and goes on a killing spree", 1.2, GenreType.Horror, MaturityRating.R);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);
        }
    }
}
