using Newtonsoft.Json;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;

namespace projectcostume
{
    internal class Program
    {
       
        static void Main(string[] args)
        {



            // Directory.CreateDirectory(@"C:\Users\user\Desktop\projectcostume\projectcostume\Data");
            //File.Create(@"C:\Users\user\Desktop\projectcostume\projectcostume\Data\costumers.json");

            List<Cuostumer> customers = new List<Cuostumer>
            {
                new Cuostumer{Id=1,Name="Samurai",Surname="Samuraiova",PhoneNumber="+9946664433"},
                new Cuostumer{Id=2,Name="True",Surname="Man",PhoneNumber="+9941234567"},
                new Cuostumer{Id=3,Name="Relax",Surname="Relaxova",PhoneNumber="+994348282"}
            };

            Cuostumer.Serialize(customers);
            Cuostumer.Add(new Cuostumer { Id = 4, Name = "Ayla", Surname = "Atakisiyeva", PhoneNumber = "+9943492543" });

            Cuostumer.CustomerSearch(2);

            Cuostumer.DeleteCostumer(2);

            Cuostumer.Update(4, "Kobra", "Kobraova", "+9944593992");

            Cuostumer.GettAll();
        }
       




    }
}