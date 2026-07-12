using Linq;

namespace Linq
{
    internal class NameLengthComparer : IComparer<Employee>
    {
        public int Compare(Employee e1 ,Employee e2)
        {
            return e1.FullName.Length.CompareTo(e2.FullName.Length);
        }
    }

}
