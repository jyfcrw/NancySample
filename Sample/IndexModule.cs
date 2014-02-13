namespace Sample
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/123"] = parameters =>
            {
                return View["index"];
            };
        }
    }
}