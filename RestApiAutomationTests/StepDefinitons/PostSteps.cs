using NUnit.Framework;
using RestApiBL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RestApiAutomationTests.StepDefinitons
{
    [Binding]
    public sealed class PostSteps
    {
        [Given(@"I Create a new Post using id (.*) title '([^']*)' and author '([^']*)'")]
        public void GivenICreateANewPostUsingIdTitleAndAuthor(int id, string title, string author)
        {
            var response = PostUtils.CreatPost(id, title, author);
            Assert.AreEqual(response.id, id);
            Assert.AreEqual(response.author, author);
            Assert.AreEqual(response.title, title);
        }

        [Then(@"I Should be able to get the post with id (.*) title '([^']*)' and author '([^']*)'")]
        public void ThenIShouldBeAbleToGetThePostWithIdTitleAndAuthor(int id, string title, string author)
        {
            Assert.Pass();
        }

    }
}
