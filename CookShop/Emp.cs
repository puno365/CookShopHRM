using System;
namespace CookShop
{
	public class Emp
	{

        public string FirstName;
        public string LastName;
        public string EmpRole;
        public string EmpID;
        public int EmpRate;
        public DateTime BirthDay;
        
        public Emp(string firstName, string lastName, string empRole, int wage) //  construtor?
		{
            FirstName = firstName;
            LastName = lastName;
            EmpRole = empRole;
            EmpRate = wage;
            
        }


        public enum Dept
        {
			Sales,
			Admin,
            Logistics,
			Service,
            IT
        }

        public enum Role
        {
			Manager,
			Employee,
            Owner
        }

        public string GetempID()
        {
            return FirstName.Substring(3) + LastName.Substring(4);
        }

		public static void AddNewEmp()

        {
            Emp emp = new Emp(firstName, LastName, empRole, wage);

            DateTime today = DateTime.UtcNow.Date;
            var num = today.ToString("dd");
            Console.WriteLine("Enter Eployee First Name:");
            var fName = Console.ReadLine();
            Console.WriteLine("Enter Eployee First Name:");
            var lName = Console.ReadLine();


            //if (Enum.IsDefined(typeof(Role), EmpRole) == true ) 
            //{
            //    Console.WriteLine($"Please enter a correct Role for {fName}");
            //}

            //Console.WriteLine($"Empid is {GetempID}+num");
        }




    }
}

