
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class JSonSerialization
    {


        public void JsonSerialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Sayali",
                Description = "Welcome to the classes"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
            Console.WriteLine();
        }

        internal void JsonSerialization()
        {
            throw new NotImplementedException();
        }

        public void JsonDeserialize()
        {
            string json = @"{
                    'Name' : 'Sayali',
                   ' Description ': 'Welcome to the classes'
            }";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
            Console.WriteLine(bsObj.Description);
            Console.WriteLine();
        }
    }

  
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}