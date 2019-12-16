using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballTeamGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballTeamGeneratorTest
{
    [TestClass]
    public class InputoutputhandlingTest
    {
        [TestMethod]
        public void ReadValidUserInputIf4Test()
        {
            //Arange
            InputOutputHandler inputOutputHandling = new InputOutputHandler();
            String[] consoleParameter4 = { "Markus", "Viktor", "Alex", "Nils" };
            //String[] consoleParameter2 = { "Nils", "Alex"};

            //Act
            inputOutputHandling.ReadUserInput(consoleParameter4);
            //inputOutputHandling.ReadUserInput(consoleParameter2);

            //Arrange
            Assert.AreEqual(4, inputOutputHandling.NumberOfPlayers);
            //Assert.AreEqual(2, inputOutputHandling.NumberOfPlayers);
            Assert.AreEqual(consoleParameter4, inputOutputHandling.Playernames);
            //Assert.AreEqual(consoleParameter2, inputOutputHandling.Playernames);

        }

        [TestMethod]
        public void ReadValidUserInputIf2Test()
        {
            //Arange
            InputOutputHandler inputOutputHandling = new InputOutputHandler();
            String[] consoleParameter2 = { "Nils", "Alex"};

            //Act
            inputOutputHandling.ReadUserInput(consoleParameter2);

            //Arrange
            Assert.AreEqual(2, inputOutputHandling.NumberOfPlayers);
            Assert.AreEqual(consoleParameter2, inputOutputHandling.Playernames);

        }

        [TestMethod]
        public void ReadValidUserInputElseTest()
        {
            //Arange
            InputOutputHandler inputOutputHandling = new InputOutputHandler();
            inputOutputHandling.NumberOfPlayers = 4;
            String[] consoleParameter4 = new string[0];
            //String[] consoleParameter2 = { "" };

            //Act
            inputOutputHandling.ReadUserInput(consoleParameter4);
            //inputOutputHandling.NumberOfPlayers = 4;
            String[] names = { "Markus", "Viktor", "Alex", "Nils" };
            inputOutputHandling.Playernames = names;
            //inputOutputHandling.ReadUserInput(consoleParameter2);

            //Arrange
            Assert.AreEqual(4, inputOutputHandling.NumberOfPlayers);
            //Assert.AreEqual(2, inputOutputHandling.NumberOfPlayers);
            Assert.AreEqual(consoleParameter4, inputOutputHandling.Playernames);
            //Assert.AreEqual(consoleParameter2, inputOutputHandling.Playernames);

        }



        [TestMethod]
        public void ReadInvalidUserInputTest()
        {
            //InputOutputHandler.ReadUserInput(213);

        }

        public void GetEnteredPlayersTest()
        {
            //Arrange
            InputOutputHandler inputOutputHandling = new InputOutputHandler();

            //Act
            var players = inputOutputHandling.GetEnteredPlayers();

            //Assert
            Assert.IsNotNull(players);
        }
    }
}
