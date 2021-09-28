using Developer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoTests
{
    [TestClass]
    public class UITest
    {
        [TestMethod]
        public void AddDeveloperToDirectory_ShouldAddANewDeveloperToDirectory()
        {
            DeveloperRepo developerRepo = new DeveloperRepo();
            Developers developers = new Developers("Mike", "52000006", "UX Team", true );
            Assert.IsTrue(developerRepo.AddDeveloperToDirectory(developers));
        }
    }
}
