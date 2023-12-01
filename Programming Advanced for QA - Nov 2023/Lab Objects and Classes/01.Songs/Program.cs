namespace _01.Songs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for(int i = 0; i < num; i++)
            {
                string[] songComponents = Console.ReadLine().Split("_").ToArray();
                string typeList = songComponents[0];
                string name = songComponents[1];
                string time = songComponents[2];

                Song currentSong = new Song();
                currentSong.TypeList = typeList;
                currentSong.Name = name;
                currentSong.Time = time;
                songs.Add(currentSong);
            }
            string command = Console.ReadLine();

            if (command != "all")
            {
                songs = songs.Where(x => x.TypeList == command).ToList();
            }
            foreach(var song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}