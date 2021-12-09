using Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization binary = new BinarySerialization();
            //binary.Serialization();
            binary.Deserialization();
            JSonSerialization serialization = new JSonSerialization();
            serialization.JsonSerialization();
            serialization.JsonDeserialize();
        }
    }


}