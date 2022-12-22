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
    public sealed class DeleteSteps
    {
        [Then(@"I Delete the post the post with id (.*) title '([^']*)'> and author '([^']*)'")]
        public void ThenIDeleteThePostThePostWithIdTitleAndAuthor(int id, string title, string author)
        {
            Assert.IsTrue(PostUtils.DeletePost(id));
        }

    }
}
