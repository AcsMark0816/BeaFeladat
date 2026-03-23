namespace ppp
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<Dino> dinos = new List<Dino>();
            dinos = FileManager.FileReader("dino.csv");

            foreach (Dino dino in dinos)
            {
                Console.WriteLine(dino);
            }

            List<string> jail = new List<string>();
            foreach(var d in dinos)
            {
                if(d.Color == "brown")
                {
                    jail.Add(d.Name);
                }
            }
            foreach(var d in jail)
            {
                Console.WriteLine(d);
            }
        }
    }
}
