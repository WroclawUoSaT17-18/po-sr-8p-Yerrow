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

        private TestObject _currentTestObject; //has vector and texture


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            IsMouseVisible = true;
        }

        protected override void OnActivated(object sender, EventArgs args)
        {
            Window.Title = "Active";
            base.OnActivated(sender, args);
        }

        protected override void OnDeactivated(object sender, EventArgs args)
        {
            Window.Title = "Unactive";
            base.OnDeactivated(sender, args);
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = (int) ScreenManager.Instance.Dimensions.X;
            _graphics.PreferredBackBufferHeight = (int) ScreenManager.Instance.Dimensions.Y;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            /*// Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _currentTestObject = SaveManager.Load<TestObject>() ?? new TestObject()
            {
                Position = new Vector2(GraphicsDevice.Viewport.Width / 2f - 150f,
                    GraphicsDevice.Viewport.Height / 2f - 210f)
            };

            _currentTestObject.Texture = Content.Load<Texture2D>("pogpng");
            */
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            ScreenManager.Instance.GraphicsDevice = GraphicsDevice;
            ScreenManager.Instance.SpriteBatch = _spriteBatch;
            ScreenManager.Instance.LoadContent(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            //texture.Dispose();
            //SaveManager.Save(_currentTestObject);
            ScreenManager.Instance.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            /*
            if (!IsActive) return;
            var state = Keyboard.GetState();
            // TODO: Add your update logic here

            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            if (state.IsKeyDown(Keys.Right))
            { 
                _currentTestObject.Position.X += 120f * (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (_currentTestObject.Position.X > GraphicsDevice.Viewport.Width)
                    _currentTestObject.Position.X = -260f;
            }

            if (state.IsKeyDown(Keys.Left))
            {
                _currentTestObject.Position.X -= 120f * (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (_currentTestObject.Position.X < -260f)
                    _currentTestObject.Position.X = GraphicsDevice.Viewport.Width;
            }

            if (state.IsKeyDown(Keys.Up))
            {
                _currentTestObject.Position.Y -= 120f * (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (_currentTestObject.Position.Y < -350f)
                    _currentTestObject.Position.Y = GraphicsDevice.Viewport.Height - 80f;
            }

            if (state.IsKeyDown(Keys.Down))
            {
                _currentTestObject.Position.Y += 120f * (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (_currentTestObject.Position.Y > GraphicsDevice.Viewport.Height -80f)
                    _currentTestObject.Position.Y = -350f;
            }
            */
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
            /*var status = Keyboard.GetState();

            // TODO: Add your drawing code here
            var fps = 1 / gameTime.ElapsedGameTime.TotalSeconds;
            Window.Title = fps.ToString("## 'FPS'");
            _spriteBatch.Begin();
            if (status.IsKeyDown(Keys.Left))
            {
                _spriteBatch.Draw(_currentTestObject.Texture, _currentTestObject.Position, effects: SpriteEffects.FlipHorizontally);
            }
            else
            {
                _spriteBatch.Draw(_currentTestObject.Texture, _currentTestObject.Position,Color.White);
            }

            _spriteBatch.End();
            
            */
            _spriteBatch.Begin();
            ScreenManager.Instance.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
