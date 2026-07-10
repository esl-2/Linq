namespace Linq;

class Program
{
    static void Main(string[] args)
    {
        var myemployee = Repository.LoadEmployees();

        



        #region Pagination
        /*var result=myemployee.Where(e=>e.Salary>=3000).Paginate(1,3).
        Select(e=> new {empName=e.Name ,empSalary=e.Salary});*/
        #endregion
        #region where
        /*var itemployees = myemployee.Where(e=>e.Skills.Count==2 &&e.Salary==3000);
        foreach (var item in itemployees)
        {
            Console.WriteLine(item);
        }*/
        #endregion
        #region chunk
        /*var padgeemps=myemployee.Chunk(10).ElementAtOrDefault(7);*/
        #endregion
        #region orderby
        /*var orderbyname=myemployee.OrderBy(e =>e ,new NameLengthComparer()); 
        var orderbynameM=myemployee.OrderBy(e=>e.Name.Length);
        */
        #endregion

    }

    
}

