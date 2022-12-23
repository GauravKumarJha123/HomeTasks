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
    internal class PatchSteps
    {
        [Given(@"I Create a new Post")]
        public void GivenICreateANewPost()
        {
            Console.WriteLine("");
        }

        [Then(@"I Update the post using Patch entering '([^']*)'")]
        public void ThenIUpdateThePostUsingPatchEntering(string title)
        {
            var response = PostUtils.UpdatePostUsingPatch(title);
        }
    }
}
