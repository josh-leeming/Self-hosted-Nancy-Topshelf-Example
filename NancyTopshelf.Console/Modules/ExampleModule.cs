using System;
using Nancy;

namespace NancyTopshelf.Console.Modules
{
    public class ExampleModule : NancyModule
    {
        public ExampleModule() : base()
        {
            Get("/v1/feeds", parameters => {
                var feeds = new string[] { "foo", "bar" };
                return Response.AsJson(feeds);
            });
        }
    }
}
