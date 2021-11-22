using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace AccountSerializationApp.Model
{
    class DataSerializer
    {
        public void BinarySerialize(object data,string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
                File.Delete(filePath);
            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }

        public object BinaryDeSerialize(string filePath)
        {
            object obj = new object();

            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if(File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }
    }
}
