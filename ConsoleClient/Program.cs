using System;
using Newtonsoft.Json;

namespace Messenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Shiz", "Whassup", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"Shiz","MessageText":"Whassup","TimeStamp":"2022-06-23T15:56:02.2370438Z"}
            //Shiz < 6 / 23 / 2022 3:56:02 PM >: Whassup
        }
    }
}