using LINQTut09.Shared;

namespace Linq;

class Program
{
    static void Main(string[] args)
    {
        var myemployee = Repository.LoadEmployees();





        #region any&all&contains 
        /*var result=myemployee.Any(e => e.Salary ==3_459);
        var result1=myemployee.All(e => e.Salary > 2_000);
        var empToFind = new Employee { EmployeeNo = "2016-HR-3770", Name = "Eslam" }; 
        bool isfound=myemployee.Contains(empToFind);*/
        #endregion
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
    #region groupby
    /*public void rungroupby()
    {
        var emps=Repository.LoadEmployees();
        var result =emps.GroupBy(e => e.Name.Length);
        foreach (var item in result)
            foreach (var i in item)
                Console.Write($"the employee salary {i.Name}");


    }*/
    #endregion
}

