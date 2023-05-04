namespace Day11_Enum_Demo
{
    enum MusicPlayer
    {
        Play = 10, Pause, Record, Stop
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MusicPlayer.Play.ToString());
            Console.WriteLine(MusicPlayer.Pause);
            Console.WriteLine(MusicPlayer.Record);
            Console.WriteLine(MusicPlayer.Stop);

        }
    }
}