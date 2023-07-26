// See https://aka.ms/new-console-template for more information
using LinqAndSQL;Console.WriteLine("Hello, World!");



string SqlQuery = @"
SELECT TOP 3 CustomerId
,SUM(Quantity) AS TotalQuantity
,SUM(Quantity * UnitPrice) AS TotalAmountSpent
FROM Orders
INNER JOIN OrderDetails ON Orders.OrderId = OrderDetails.OrderId
WHERE YEAR(OrderDate) = 2022
GROUP BY CustomerId
ORDER BY TotalAmountSpent DESC";







 Student StudentWithMostCourses(List<Student> students)
{

    return students.OrderByDescending(s => s.Courses.Count).First();
}


Student StudentWithMostCreditsAndMoreThan3Courses(List<Student> students)
{

    return students.Where(s => s.Courses.Count > 3)
        .OrderByDescending(s => s.Courses.Sum(c => c.Credits))
        .First();
}

List<Student> StudenstWithSpecificCourses(List<Student> students, string course)
{
   return students.Where(c => c.Courses.Exists(x => x.CourseName.Equals(course)))
        .OrderBy(c => c.StudentName).ToList();
}



