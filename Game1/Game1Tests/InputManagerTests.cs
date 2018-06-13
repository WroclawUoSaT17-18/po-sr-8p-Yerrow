using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheGameProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace TheGameProject.Tests
{
    [TestClass()]
    public class InputManagerTests
    {
        [TestMethod()]
        public void KeyDown_CurrentlyUp_ReturnsFalse()
        {
            var key = Keys.Up;
            var inputmanager = new InputManager();

            var result = inputmanager.KeyDown(key);
            
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void KeyDown_CurrentlyUp_ReturnsTrue()
        {
            var key = Keys.Up;
            KeyboardState currentKeyState = Keyboard.GetState();
            var inputmanager = new InputManager() {};

            var result = inputmanager.KeyDown(key);

            Assert.IsTrue(result);
        }
    }
}