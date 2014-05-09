using NUnit.Framework;
using ToyRobot.Core;

namespace ToyRobot.Test.Base {
    
    public class TestBase {
        //Apologies to JJ Abrams.
        protected Robot badRobot;

        [SetUp]
        public void Setup() {
            badRobot = new Robot();
        }

        [TearDown]
        public void Cleanup() {
            badRobot = null;
        }
    }
}