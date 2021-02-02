using System;

namespace Task1
{
    class PlayIsStartedEventArgs : EventArgs
    {
        public int SoundNumber { get; set; }
    }
    class Bandmaster
    {
        public event EventHandler<PlayIsStartedEventArgs> PlayIsStartedEvent;
        public void StartPlay(int x)
        {
            PlayIsStartedEvent?.Invoke(this, new PlayIsStartedEventArgs { SoundNumber = x });
        }
    }
    abstract class OrchestraPlayer
    {
        public string Name { get; set; }
        abstract public void PlayIsStartedEvenhandler(object sender, PlayIsStartedEventArgs e);
    }
    class Violinist : OrchestraPlayer
    {
        public override void PlayIsStartedEvenhandler(object sender, PlayIsStartedEventArgs e)
        {
            Console.WriteLine($"Violinist {Name} plays composition #{e.SoundNumber}: La-la!");
        }
    }
    class Hornist : OrchestraPlayer
    {
        public override void PlayIsStartedEvenhandler(object sender, PlayIsStartedEventArgs e)
        {
            Console.WriteLine($"Hornist {Name} plays composition #{e.SoundNumber}: Du-du-du!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bandmaster master = new Bandmaster();
            OrchestraPlayer[] orc = new OrchestraPlayer[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (rand.Next(0, 2) == 0)
                {
                    orc[i] = new Violinist() { Name = rand.Next(100000, 999999).ToString() };
                }
                else
                {
                    orc[i] = new Hornist() { Name = rand.Next(100000, 999999).ToString() };
                }
                master.PlayIsStartedEvent += orc[i].PlayIsStartedEvenhandler;
            }
            Console.WriteLine("Введите N:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++) 
            {
                master.StartPlay(rand.Next(1, 10));
            }
        }
    }
}
