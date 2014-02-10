namespace SharpDXTutorial1
{
    using System;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new MyGame())
                game.Run();
        }
    }
}
