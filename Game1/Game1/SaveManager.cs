using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace Game1
{
    public class SaveManager
    {
        private static readonly string SavePath;

        //Sets the full path to the file for serialization
        static SaveManager()
        {
            //get the location of the folder where the program's .exe file is running from
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            //find out where the savegame xml file would be if it exists
           SavePath = Path.Combine(path, "save.xml");
        }

        public static T Load<T>()
        {
            if (!File.Exists(SavePath))
            {
                //just return the default value for that object type
                return default(T);
            }

            var serializer = new XmlSerializer(typeof(T));

            using (var stream = File.Open(SavePath, FileMode.Open, FileAccess.Read))
            {
                return (T)serializer.Deserialize(stream);
            }

        }

        public static void Save(object saveData)
        {
            var xml = new XmlSerializer(saveData.GetType());

            using (var stream = File.Open(SavePath, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream,saveData);
            }
        }
    }
}
