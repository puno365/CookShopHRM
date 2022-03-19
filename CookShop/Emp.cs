using System;
namespace CookShop
{
	public class Emp
	{

        private string fName;
        private string lName;
        private Role empRole;
        private string empID;
        private int empRate;
        private DateTime bday;
        
        public Emp(string fn, string ln, Role er, int wg) //  construtor?
		{
            fName = fn;
            lName = ln;
            empRole = er;
            empRate = wg;
        }


        enum Dept
        {
			Sales,
			Admin,
            Logistics,
			Service,
            IT
        }

        private enum Role
        {
			Manager,
			Employee,
            Owner
        }

        public string GetempID()
        {
            return fName.Substring(3) + lName.Substring(4);
        }

		public void NewEmp()

        {

            DateTime today = DateTime.UtcNow.Date;
            var num = today.ToString("dd");
            Console.WriteLine("Enter Eployee First Name:");
            var fName = Console.ReadLine();
            Console.WriteLine("Enter Eployee First Name:");
            var lName = Console.ReadLine();


            if (Enum.IsDefined(typeof(Role), empRole) == true ) 
            {
                Console.WriteLine($"Please enter a correct Role for {fName}");
            }

            Console.WriteLine($"Empid is {GetempID}+num");
        }




    }
}

