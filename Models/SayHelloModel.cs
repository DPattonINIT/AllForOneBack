using System.Threading.Tasks;

namespace AllForOneBack.Models
{
    public class SayHelloModel
    {
        public class HelloWorld
        {

            public string? Name { get; set; }


            public bool Valid()
            {
                if (string.IsNullOrWhiteSpace(Name))
                {
                    return false;
                }

                foreach (char c in Name)
                {
                    if (!char.IsLetter(c))
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}