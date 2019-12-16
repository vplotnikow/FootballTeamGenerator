using System;
using System.Collections.Generic;
using FootballTeamGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballTeamGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        private List<Player> Createlist()
        {
            Player player1 = new Player("alex");
            Player player2 = new Player("viktor");
            Player player3 = new Player("markus");
            Player player4 = new Player("nils");

            List<Player> playerlist1 = new List<Player>();
            playerlist1.Add(player1);
            playerlist1.Add(player2);
            playerlist1.Add(player3);
            playerlist1.Add(player4);

            return playerlist1;
        }

        [TestMethod]
        public void GetRandomFootballTeamTest()
        {
            // Arrange
            Generator generator = new Generator();

            // Act
            var footballTeam = generator.GetRandomFootballTeam();
            var footballTeam2 = generator.GetRandomFootballTeam();

            // Assert
            Assert.IsNotNull(footballTeam);
            Assert.AreNotEqual(footballTeam, footballTeam2);
        }

        [TestMethod]
        public void PlayerGeneratorTest()
        {
            //Arrange
            Generator generator = new Generator();
            var playerlist1 = Createlist();

            //Act
            var playerlist2 = generator.PlayerGenerator(playerlist1);

            //Assert
            Assert.AreNotEqual(playerlist1, playerlist2);
            Assert.IsNotNull(playerlist2); 
        }


        [TestMethod]
        public void CreateTeamsTest()
        {
            //Arrange
            Generator generator = new Generator();

            //Act
            var playerlist1 = Createlist();
            var teamlist = generator.CreateTeams(playerlist1);

            //Assert
            Assert.IsNotNull(teamlist);
        }
    }
}
