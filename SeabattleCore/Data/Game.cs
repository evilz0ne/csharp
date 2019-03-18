using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Seabattle.Data
{
    [XmlRoot(ElementName ="Game", Namespace = "http://vk.com/csharpcroc")]
    public class Game
    {
        //поле мое
        public Field My;
        //поле врага
        public Field Enemy;

        //constructor
        public Game()
        {
            My = new Field();
            Enemy = new Field();
        }

        public static Game Load(string name)
        {
            //serializer
            var ser = new XmlSerializer(typeof(Game));
            //Объект для чтения хмл файла
            using (XmlReader rdr = XmlReader.Create(name))
            {
                return(Game)ser.Deserialize(rdr);
            }
        }

        public void Save(string name)
        {
            //serializer
            var ser = new XmlSerializer(typeof(Game));
            var settings = new XmlWriterSettings()
            {
                Indent = true
            };
            using (XmlWriter wrt = XmlWriter.Create(name, settings))
            {// xml file for serialz
                ser.Serialize(wrt, this);
            }
        }
    }
}
