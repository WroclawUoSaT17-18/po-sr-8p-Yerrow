using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class ScreenManager
    {
        private static ScreenManager _instance;
        public Vector2 Dimensions { private set; get; }

        private ScreenManager()
        {
            Dimensions = new Vector2(640, 480);
        }

        public static ScreenManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ScreenManager();
                return _instance;
            }
        }

        public void LoadContent(ContentManager content)
        {
        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
