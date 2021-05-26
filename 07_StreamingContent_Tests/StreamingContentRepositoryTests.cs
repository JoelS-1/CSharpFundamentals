using _07_StreamingContent_Repository;
using _07_StreamingContent_Repository.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA
            //arrange 
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //act
            bool addResult = repository.AddContentToDirectory(content);

            //assert
            Assert.IsTrue(addResult);

        }
        [TestMethod]
        public void MyTestMethod()
        {
            List<int> tableNumbers = new List<int>();
            foreach (int firstNum in tableNumbers)
            {
                for (int secondNum = 1; secondNum <= 12; secondNum++)
                {
                    int total = firstNum * secondNum;
                    Console.WriteLine($"{firstNum} X {secondNum} = {total}");
                }
            }
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();
            repository.AddContentToDirectory(content);

            //act
            List<StreamingContent> directory = repository.GetContents();

            //assert
            bool directoryHasContent = directory.Contains(content);
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContent _content;
        private StreamingContentRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Back to the Future", "A high school student named Marty gets accidentally sent back in time 30 years", 4.4, GenreType.SciFi, MaturityRating.PG);
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void CheckMovieRunTime()
        {
            //creating a movie type, using full constructor and inherited base
            Movie joe = new Movie("Joe Dirt", "Mullet", 3.2, GenreType.Bromance, MaturityRating.PG_13, 112);

            //creating a list to replicate our repo
            List<StreamingContent> miniRepo = new List<StreamingContent>();

            miniRepo.Add(joe);

            foreach(Movie content in miniRepo)
            {
                if (content is Movie)
                {
                    //setting content as movie to access movie exclusive properties
                    Console.WriteLine((content as Movie).RunTime);
                }
            }

        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //arrange
            //done in arrange() method

            //act
            StreamingContent searchResult = _repo.GetContentByTitle("Back to the Future");


            //assert
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturUpdatedValue()
        {
            //arrange
            //done in arrange() method

            //act
            _repo.UpdateExistingContent("Back to the Future", new StreamingContent("Back to the Future 2", "Marty goes into the future 30 years", 4.0, GenreType.SciFi, MaturityRating.PG_13));

            //assert
            Assert.AreEqual(_content.Title, "Back to the Future 2");
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //arrange
            //done in arrange() method

            //act
            bool wasDeleted = _repo.DeleteExistingContent("Back to the Future");

            //assert
            Assert.IsTrue(wasDeleted);
        }
    }
}
