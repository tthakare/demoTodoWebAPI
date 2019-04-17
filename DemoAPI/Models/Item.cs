using Microsoft.Azure.Documents;

namespace DemoAPI.Models
{
    public class Item : Resource
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isComplete { get; set; }
        public string category { get; set; }
    }
}