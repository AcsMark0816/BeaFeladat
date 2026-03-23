using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppp
{
    public class FileManager
       
    {
        public static List<Dino> FileReader(string Filename)
        {
            List<Dino> dinos = new List<Dino>();
            try
            {
                foreach (string line in File.ReadLines(Filename).Skip(1))
                {
                    string[] temp = line.Split(';');
                    if(temp.Length == 6)
                    {
                        Dino dino = new Dino(temp);
                        dinos.Add(dino);
                    }
                }
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }









            return dinos;
        }
    }
}
