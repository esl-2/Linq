namespace Linq;

class Program
{
    static void Main(string[] args)
    {
        var myemployee = Repository.LoadEmployees();
        var itemployees = myemployee.Where(e=>e.Gender=="female" &&e.Salary==3000);
        foreach (var item in itemployees)
        {
            Console.WriteLine(item);
        }
    }

    
}

