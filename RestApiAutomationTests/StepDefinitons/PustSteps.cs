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
    public sealed class PustSteps
    {
        [Given(@"I Update a Post using id (.*) title '([^']*)' and author '([^']*)'")]
        public void GivenIUpdateAPostUsingIdTitleAndAuthor(int id, string title, string author)
        {
            var response = PostUtils.UpdatePost(id, title, author);
            Assert.AreEqual(response.id, id);
            Assert.AreEqual(response.author, author);
            Assert.AreEqual(response.title, title);
        }

    }
}
