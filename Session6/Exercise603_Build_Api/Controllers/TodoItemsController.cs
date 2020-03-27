using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Exercise603_Build_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise603_Build_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoItemsController : ControllerBase
    {

        

        public TodoItemsController()
        {

        }

        [HttpGet()]
        public ActionResult Get()
        {
            return Ok(FakeDb._todoItems);
        }


        [HttpGet("{id:int}")]
        public ActionResult<TodoItem> GetTodoItem(long id)
        {
            return FakeDb._todoItems.Find(x => x.Id == id);
        }

        
        [HttpPost()]
        public ActionResult AddTodoItem(TodoItem todoItem)
        {
            if (FakeDb._todoItems.FindIndex(x => x.Id == todoItem.Id) != -1)
            {
                return Problem("Id already exists");
            }
            
            FakeDb._todoItems.Add(todoItem);
            Debug.WriteLine("Added item");
            Debug.WriteLine("total items: " + FakeDb._todoItems.Count);
            return Ok(todoItem);
        }

        [HttpPut("{id:int}")]
        public ActionResult UpdateTodoItem(long id, [FromBody]TodoItem todoItem)
        {
            Debug.WriteLine("ID: " + id);

            var index = FakeDb._todoItems.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                FakeDb._todoItems[index] = todoItem;
                return Ok();
            }

            return NotFound();

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTodoItem(long id)
        {
            var index = FakeDb._todoItems.FindIndex(x => x.Id == id);
            if (index > 0)
            {
                FakeDb._todoItems.RemoveAt(index);
                return Ok();

            }
            return NotFound();
        }

    }
}
