using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TheGameProject
{
    public class MenuManager
    {
        private Menu menu;

        public MenuManager()
        {
            menu = new Menu();
            menu.OnMenuChange += menu_OnMenuChange;
        }

        private void menu_OnMenuChange(object sender, EventArgs e)
        {
            SaveManager<Menu> xmlMenuManager = new SaveManager<Menu>();
            menu.UnloadContent();
            //transition
            menu = xmlMenuManager.Load(menu.ID);
            menu.LoadContent();
        }

        public void LoadContent(string menuPath)
        {
            if (menuPath != string.Empty)
            {
                menu.ID = menuPath;
            }
        }

        public void UnloadContent()
        {
            menu.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
            menu.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            menu.Draw(spriteBatch);
        }
    }
}
