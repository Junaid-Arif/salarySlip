var salary = new SalarySlip();
salary.getSalarySlip("manager");
salary.getSalarySlip("engineer");
salary.getSalarySlip("analyst");




class Employee
{
    private int base_salary { get; set; }
    private int medical_allowance { get; set; }
    private int fuel_allowance { get; set; }


    public Employee()
    {
        base_salary = 1500;
        medical_allowance = 0;
        fuel_allowance = 0;
    }

    public int Manager()
    {
        medical_allowance = 1000;
        fuel_allowance = 250;
        int total_salary = fuel_allowance + medical_allowance + base_salary;
        return total_salary;
    }
    public int Analyst()
    {
        medical_allowance = 800;
        fuel_allowance = 150;
        int total_salary = fuel_allowance + medical_allowance + base_salary;
        return total_salary;
    }
    public int Engineer()
    {
        medical_allowance = 500;
        fuel_allowance = 100;
        int total_salary = fuel_allowance + medical_allowance + base_salary;
        return total_salary;
    }
}

class SalarySlip : Employee
{
    int gross_salary { get; set; }


    public SalarySlip()
    {
        gross_salary = 0;
    }

    public void getSalarySlip(string designation)
    {
        if (designation == "manager")
        {
            gross_salary = Manager();
            Console.WriteLine("Managers Gross Salary is: " + gross_salary);

        }
        else if (designation == "analyst")
        {
            gross_salary = Analyst();
            Console.WriteLine("Analysts Gross Salary is: " + gross_salary);

        }
        else if (designation == "engineer")
        {
            gross_salary = Engineer();
            Console.WriteLine("Engineers Gross Salary is: " + gross_salary);

        }
    }
}



