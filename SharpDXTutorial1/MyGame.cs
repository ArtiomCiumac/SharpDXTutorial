namespace SharpDXTutorial1
{
    using SharpDX;
    using SharpDX.Toolkit;

    internal sealed class MyGame : Game
    {
        private readonly GraphicsDeviceManager _graphicsDeviceManager;

        public MyGame()
        {
            _graphicsDeviceManager = new GraphicsDeviceManager(this);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);
        }
    }
}
