
namespace MyWCFServices
{
   public class HelloWorldService: IHelloWorldServices
    {
        public string GetMessage(string name)
        {
            return "Hello world from " + name + "!";
        }
    }
}
