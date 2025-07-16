using System;
using Microsoft.AspNetCore.Mvc;
namespace helloWorld.Controllers
{
    public class BlogController : Controller
    {
        public string Story(int id) 
        {
            return $"This is the story of {id}";
        }

        [Route("blog/post")]
        // http://localhost:5099/blog/post
        // we cam aslso the cvhange the name of Route to be HttpPost, HttpGet, HttpPut, HttpDelete e.t.c
        public string post()
        {
            return "This is the post";
        }
    }
}