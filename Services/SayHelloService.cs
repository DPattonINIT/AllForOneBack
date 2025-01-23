using System.Threading.Tasks;
using AllForOneBack.Models;

namespace AllForOneBack.Services
{


    public class SayHelloService
    {
        public string AddName(string name)
        {
            var person = new SayHelloModel.HelloWorld { Name = name };

            if (person.Valid())
            {
                return person.Name;
            }
            else
            {
                return "Name cannot be empty or contain numbers or special characters.";
            }
        }
    }









    // public class SayHelloService
    // {

    //     public string AddName(string name)
    //     {

    //         return name;
    //     }


    // }
}

