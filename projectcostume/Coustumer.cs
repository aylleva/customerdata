using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectcostume
{
    
           
    internal class Cuostumer
    {
        public static string path = @"C:\Users\user\Desktop\projectcostume\projectcostume\Data\costumers.json";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }




        public static List<Cuostumer> Deserialize(string path)
        {
            string result;
            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<List<Cuostumer>>(result);
        }
        public static void Serialize(List<Cuostumer> costumers)
        {
            string result = JsonConvert.SerializeObject(costumers);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(result);
            }
        }

        public static void Add(Cuostumer costumer)
        {
            List<Cuostumer>customers  = Deserialize(path);
            customers.Add(costumer);

            Serialize(customers);
        }

        public static void CustomerSearch(int id)
        {
            List<Cuostumer> customers = Deserialize(path).FindAll(f => f.Id == id);
            customers.ForEach(find => Console.WriteLine(find.Name + " " + find.Surname + " id:" + find.Id));


        }

        public static void Update(int id, string newName, string newSurname, string newPhoneNumber)
        {
            List<Cuostumer> customers = Deserialize(path);
            Cuostumer newcustomer = customers.Find(n => n.Id == id);

           newcustomer.Id=id;
           newcustomer.Name = newName;
           newcustomer.Surname=newSurname;
           newcustomer.PhoneNumber = newPhoneNumber;
            
            Serialize(customers);
        }

        public static void DeleteCostumer(int id)
        {
            List<Cuostumer> costumers = Deserialize(path);
            costumers.RemoveAll(f => f.Id == id);
          
            Serialize(costumers);
        }

        public static void GettAll()
        {
            List<Cuostumer> costumers = Deserialize(path);
            costumers.ForEach(find => Console.WriteLine(find.Id + " " + find.Name + " " + find.Surname + " "+find.PhoneNumber));
        }
    }
}
