using System;

/* A marketing firm wants to keep record of its employees. Each
 * record would have the following characteristics – first name,
 * family name, age, gender(m or f), ID number, unique employee
 * number(27560000 to 27569999). Declare the variables needed to
 * keep the information for a single employee using appropriate
 * data types and descriptive names.
 */

class EmployeeDetails
{
   static void Main()
   {
      string firstName = "Peter";
      string familyName = "Bush";
      byte age = 31;
      bool isFemale = false;
      int citizenId = 1234567890;
      int employeeId = 27560001;

      Console.WriteLine("{0} {1}, {2}, {3} \r\n{4} \r\n{5}",
                         firstName, familyName, age,
                         isFemale ? 'f' : 'm',
                         citizenId, employeeId);
   }
}
