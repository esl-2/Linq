namespace Linq;
public static class Pagination
{
    public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source ,
                                int PageNO =0 , int NoPerPage=10)
    {
        return source.Skip((PageNO - 1)*NoPerPage).Take(NoPerPage);
    }
}