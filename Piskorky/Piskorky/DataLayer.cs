using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Piskorky
{
    public class DataLayer
    {
        private string path = "game.xml";

        public void SaveGame(Game game)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Game));
            using (StreamWriter sw = new StreamWriter(path))
            {
                serializer.Serialize(sw, game);
            }
        }

        public Game LoadGame()
        {
            Game savedGame = new Game();
            XmlSerializer serializer = new XmlSerializer(typeof(Game));
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    savedGame = (Game)serializer.Deserialize(sr);
                }
            }

            return savedGame;
        }

    }
}
