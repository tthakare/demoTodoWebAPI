using DemoAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    [RoutePrefix("api/todo")]
    public class TodoController : ApiController
    {
        [HttpGet]
        [Route("getItems")]
        public async Task<IEnumerable<Item>> GetAllItemAsync()
        {
            var output = await TodoDBRepository<Item>.GetItemsAsync(i => !i.isComplete);
            return output;
        }

        [HttpGet]
        [Route("getItemById")]
        public async Task<Item> GetItemByIdAsync(string id)
        {
            var output = await TodoDBRepository<Item>.GetItemByIdAsync(id);
            return output;
        }

        [HttpPost]
        [Route("createItem")]
        public async Task CreateItemAsync(Item item)
        {
            await TodoDBRepository<Item>.AddItemAsync(item);
        }

        [HttpDelete]
        [Route("deleteItem")]
        public async Task RemoveItemAsync(string id, string category)
        {
            await TodoDBRepository<Item>.RemoveItemAsync(id, category);
        }

        [HttpPost]
        [Route("updateItem")]
        public async Task UpdateItemAsync(Item item)
        {
            await TodoDBRepository<Item>.UpdateItemAsync(item.id, item);
        }
    }
}
