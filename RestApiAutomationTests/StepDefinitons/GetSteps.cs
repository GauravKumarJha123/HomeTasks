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
    internal class GetSteps
    {
        [Then(@"I get the post the post with id (.*) title '([^']*)' and author '([^']*)'")]
        public void ThenIGetThePostThePostWithIdTitleAndAuthor(int id, string title, string author)
        {
            var response = PostUtils.GetPostUsingPatch(id, title, author);
            Assert.AreEqual(response.id, id);
            Assert.AreEqual(response.title, title);
            Assert.AreEqual(response.author, author);

        }

    }
}
