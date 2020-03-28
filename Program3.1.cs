
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._1
{
    //Дано список List <T> з об'єктами одного типу Obj, у якого в свою чергу є властивість Id. Організувати пошук для знаходження елемента колекції по його властивості
    class Program
    {
        static void Main(string[] args)
        {
            List<Obj> listof = new List<Obj>();

            listof.Add(new Obj() { Name = "Kate", Id = 123056 });
            listof.Add(new Obj() { Name = "Nina", Id = 123548 });
            listof.Add(new Obj() { Name = "Svitlana", Id = 127945 });
            listof.Add(new Obj() {Name = "Mike", Id = 124458});
            listof.Add(new Obj() {Name = "Ron", Id = 120452});

            Console.WriteLine("Enter your id:");
            int id = int.Parse(Console.ReadLine());
            Obj res = listof.Find(
                delegate (Obj ob)
                {
                    return ob.Id == id;
                }
                );
            Console.WriteLine("Id: {0},   name: {1}", res.Id, res.Name);
        }
    }
    class Obj
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
