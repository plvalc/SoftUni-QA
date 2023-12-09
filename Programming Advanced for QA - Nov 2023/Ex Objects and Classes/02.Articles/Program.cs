namespace _02.Articles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ").ToArray();
            //"{title}, {content}, {author}"
            string title = article[0];
            string content = article[1];
            string author = article[2];

            Article article1 = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i= 0; i < n; i++)
            {
                string currentCommand = Console.ReadLine();
                string[] commandData = currentCommand.Split(": ").ToArray();

                if (commandData[0] == "Edit")
                    article1.Edit(commandData[1]);
                else if (commandData[0] == "ChangeAuthor")
                    article1.ChangeAuthor(commandData[1]);
                else if (commandData[0] == "Rename")
                    article1.Rename(commandData[1]);
            }
            Console.WriteLine(article1);
        }
    }
    
    
}