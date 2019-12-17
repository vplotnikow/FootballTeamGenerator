using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballTeamGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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

        //[TestMethod]
        //public void ReadValidUserInputIf3Test()
        //{
        //    string[] userInput = { "2", "P1", "P2" };
        //    using (StreamReader reader = new StreamReader(userInput)
        //    {
        //        // Redirect standard output from the console to the output file.
        //        Console.SetOut(writer);
        //        // Redirect standard input from the console to the input file.
        //        Console.SetIn(reader);
        //        string line;
        //        while ((line = Console.ReadLine()) != null)
        //        {
        //            string newLine = line.Replace(("").PadRight(tabSize, ' '), "\t");
        //            Console.WriteLine(newLine);
        //        }
        //    }


        //    //Arange
        //    //var userInput = "2";
        //    String[] userInput = { "2" , "P1" , "P2" };
        //    var sr = new StringReader("2");
        //    Console.SetIn(sr);
        //    InputOutputHandler inputOutputHandling = new InputOutputHandler();
        //    String[] consoleParameter0 = {};

        //    //Act
        //    inputOutputHandling.ReadUserInput(consoleParameter0);

        //    //Arrange
        //    Assert.AreEqual(2, inputOutputHandling.NumberOfPlayers);
        //    Assert.AreEqual(consoleParameter0, inputOutputHandling.Playernames);

        //}

        //[TestMethod]
        //public void ReadValidUserInputElseTest()
        //{
        //    //Arange
        //    //Mock<InputOutputHandler> inputOutputHandling = new Mock<InputOutputHandler>();
        //    //inputOutputHandling.Setup(x => x.ReadLine()).Returns("");
            

        //    //InputOutputHandler inputOutputHandling = new InputOutputHandler();
        //    //inputOutputHandling.NumberOfPlayers = 4;
        //    String[] consoleParameter4 = new string[0];
        //    //String[] consoleParameter2 = { "" };
        //    inputOutputHandling.Setup(x => x.ReadUserInput(consoleParameter4));

        //    //Act
        //    inputOutputHandling.ReadUserInput(consoleParameter4);
        //    //inputOutputHandling.NumberOfPlayers = 4;
        //    String[] names = { "Markus", "Viktor", "Alex", "Nils" };
        //    inputOutputHandling.Playernames = names;
        //    //inputOutputHandling.ReadUserInput(consoleParameter2);

        //    //Arrange
        //    Assert.AreEqual(4, inputOutputHandling.NumberOfPlayers);
        //    //Assert.AreEqual(2, inputOutputHandling.NumberOfPlayers);
        //    Assert.AreEqual(consoleParameter4, inputOutputHandling.Playernames);
        //    //Assert.AreEqual(consoleParameter2, inputOutputHandling.Playernames);

        //}


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
