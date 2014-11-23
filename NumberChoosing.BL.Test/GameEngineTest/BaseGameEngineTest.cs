using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberChoosing.BL.GameEngine;

namespace NumberChoosing.BL.Test.GameEngineTest
{
    [TestClass]
    public class BaseGameEngineTest
    {
        private IGameEngine _gameEngine;

        [TestInitialize]
        public void InitializeTest()
        {
            _gameEngine = new NumberChooseGameEngine();
            List<Player> players = new List<Player>()
            {
                new Player() { Point = 0, UserID = 1},
                new Player() { Point = 0, UserID = 2}
            };
            _gameEngine.StartGame(players, null);
        }

        [TestMethod]
        public void Get_Players_After_Initialize()
        {
            var count = _gameEngine.GetPlayers().Count;
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Get_First_Player()
        {
            Assert.AreEqual(1, _gameEngine.GetCurrentPlayer().UserID);
        }

        [TestMethod]
        public void Game_Not_End_After_Start()
        {
            Assert.AreEqual(false, _gameEngine.IsGameEnd());
        }

        [TestMethod]
        public void Player_Switch_After_Play()
        {
            var firstPlayer = _gameEngine.GetCurrentPlayer();
            _gameEngine.TurnPlay(firstPlayer, 1);
            Assert.AreEqual(2, _gameEngine.GetCurrentPlayer().UserID);
        }

        [TestMethod]
        public void Player_Reset_After_Reset()
        {
            var firstPlayer = _gameEngine.GetCurrentPlayer();
            _gameEngine.TurnPlay(firstPlayer, 1);
            _gameEngine.ResetGame();
            Assert.AreEqual(1, _gameEngine.GetCurrentPlayer().UserID);
        }
    }
}
