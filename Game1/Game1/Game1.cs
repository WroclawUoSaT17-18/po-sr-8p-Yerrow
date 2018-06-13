using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TheGameProject
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            IsMouseVisible = true;
        }

        protected override void OnActivated(object sender, EventArgs args)
        {
            Window.Title = "TheGameProject - Active";
            base.OnActivated(sender, args);
        }

        protected override void OnDeactivated(object sender, EventArgs args)
        {
            Window.Title = "TheGameProject - Unactive";
            base.OnDeactivated(sender, args);
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = (int) ScreenManager.Instance.Dimensions.X;
            _graphics.PreferredBackBufferHeight = (int) ScreenManager.Instance.Dimensions.Y;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            ScreenManager.Instance.GraphicsDevice = GraphicsDevice;
            ScreenManager.Instance.SpriteBatch = _spriteBatch;
            ScreenManager.Instance.LoadContent(Content);
        }

        protected override void UnloadContent()
        {           
            ScreenManager.Instance.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            ScreenManager.Instance.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            ScreenManager.Instance.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
