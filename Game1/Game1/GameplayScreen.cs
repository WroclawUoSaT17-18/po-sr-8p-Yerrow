using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TheGameProject
{
    public class GameplayScreen : GameScreen
    {
        private Player player;
        private Map map;

        public override void LoadContent()
        {
            base.LoadContent();

            SaveManager<Player> playerLoader = new SaveManager<Player>();
            SaveManager<Map> mapLoader = new SaveManager<Map>();
            player = playerLoader.Load("Content/Load/Gameplay/Player.xml");
            map = mapLoader.Load("Content/Load/Gameplay/Maps/Map1.xml");
            player.LoadContent();
            map.LoadContent();
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
            player.UnloadContent();
            map.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            player.Update(gameTime);
            map.Update(gameTime, ref player);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            map.Draw(spriteBatch);
            player.Draw(spriteBatch);
        }
    }
}
