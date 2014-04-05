namespace SharpDXTutorial2
{
    using System;

    /// <summary>
    /// Provides the entry point for the application.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The entry point of the aplication.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new MyGame())
                game.Run();
        }
    }
}
