using System.Linq.Expressions;

namespace Linq;

class Program
{
    static void Main(string[] args)
    {
        var employee = Repository.LoadEmployees();
        var employee1 = Repository1.LoadEmployees();
        var Department=Repository.LoadDepartment();
        
        #region where
        /*var itemployees = myemployee.Where(e=>e.Skills.Count==2 &&e.Salary==3000);
        foreach (var item in itemployees)
        {
            Console.WriteLine(item);
        }*/
        #endregion
        #region Concatnation
        //var result=employee.Select(q =>q.FullName).Concat(Department.Select(q =>q.Name));
        #endregion
        #region ElementAt&Last&First&Single
        /*var single=employee.Single(e => e.Id == 4);
        var first=employee.First(e => e.Id > 1005);
        var last=employee.Last(e => e.Id > 1005);
        var elementat=employee.ElementAt(1005);*/
        #endregion
        #region Repeat&Empty&Range
        /*var pages=Enumerable.Range(1,5);
        var comments=Enumerable.Empty<string>();
        comments.DefaultIfEmpty<string>("No comments yet");
        var repat=Enumerable.Repeat("***",3);*/
        #endregion
        #region groubjoin
        /*var result=Department.GroupJoin(employee,
            dot => dot.Id,
            emp =>emp.DepartmentId,
            (dot, emp )=>new
            {
                Departmentname= dot.Name,
                employeecont= emp.Count()
            }
        );
        foreach (var item in result)
        {
            System.Console.WriteLine($"#################{item.Departmentname}################\n {item.employeecont}");
        }*/
        #endregion
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
        #region chunk
        /*var padgeemps=myemployee.Chunk(10).ElementAtOrDefault(7);*/
        #endregion
        #region orderby
        /*var orderbyname=myemployee.OrderBy(e =>e ,new NameLengthComparer()); 
        var orderbynameM=myemployee.OrderBy(e=>e.Name.Length);
        */
        #endregion
        #region groupby
        /*
        var emps=Repository.LoadEmployees();
        var result =emps.GroupBy(e => e.Name.Length);
        foreach (var item in result)
            foreach (var i in item)
                Console.Write($"the employee salary {i.Name}");
        */
        #endregion
        #region sum,min,max,avg,aggrigate 
        //var sum=employee.Sum(e =>e.Salary);
        //System.Console.WriteLine($"total salary is : {sum}");
        //var AVG=employee.Average(e =>e.Salary);
        //System.Console.WriteLine($"Average salary is {AVG}");
        //var max=employee.Max(e =>e.Salary);
        //System.Console.WriteLine($"MAX salary is : {max}");
        //var maxby=employee.MaxBy(e =>e.Salary);
        //System.Console.WriteLine($"who has MAX salary :{maxby}");
        //var MIN=employee.Min(e =>e.Salary);
        //System.Console.WriteLine($"Minimum salary is :{MIN}");
        //var Minby=employee.MinBy(e =>e.Salary);
        //System.Console.WriteLine($"who has minimum salary : {Minby}");
        //var maxsalary=employee.Aggregate((e,a) => e.Salary < a.Salary ? a : e);
        //System.Console.WriteLine($"who has MAX salary :{maxsalary}");
        #endregion
        #region Distinct, Except, Intersect, Union
            /*var total =employee.UnionBy(employee1,x=> x.DepartmentId);
            var union =employee.IntersectBy(employee1.Select(x => x.DepartmentId),x =>x.DepartmentId); 
            var except =employee.ExceptBy(employee1.Select(x => x.DepartmentId),x =>x.DepartmentId); 
            */
        #endregion
        #region expression tree
            /***
            convert delegate to Data Structure 
            using with EF
            ***/         
            Expression<Func<int,int,bool>> func=(num1,num2) => num1 +num2 <= 20/num1;
            var funcD=func.Compile();
            System.Console.WriteLine(funcD(20,1));

        #endregion
    }
    
    
}

