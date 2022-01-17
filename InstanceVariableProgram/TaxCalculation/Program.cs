using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
    public interface Taxable
    {
        float SalesTax { get; set; }
        float IncomeTax { get; set; }
        float CalculateTax();
    }
    public class Employeee : Taxable
    {
        public float SalesTax { get; set; }
        public float IncomeTax { get; set; }
        public Employeee()
        {
            float SalesTax = 0.07F;
            float IncomeTax = 0.105F;
        }
        public int empId { get; set; }
        public string name { get; set; }
        float salary { get; set; }
        public Employeee(int emp_Id, string emp_name, float emp_salary)
        {
            empId = emp_Id;
            name = emp_name;
            salary = emp_salary;
        }

        public float CalculateTax()
        {
            float incomeTax = salary * IncomeTax;
            Console.WriteLine("IncomeTax is {0}", incomeTax);
            return incomeTax;
        }
    }

    public class Product : Taxable
    {
        public float SalesTax { get; set; }
        public float IncomeTax { get; set; }

        public Product()
        {
            float SalexTax = 0.07F;
            float IncomeTax = 0.105F;
        }
        public int pId { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public Product(int p_Id, int _price, int _quantity)
        {
            pId = p_Id;
            price = _price;
            quantity = _quantity;

        }

        public float CalculateTax()
        {
            float salesTax = price * SalesTax;
            Console.WriteLine("SalesTax is {0}", salesTax);
            return salesTax;
        }
    }

    public class XYZ
    {
        public static void Main(string[] args)
        {
            Employeee emp = new Employeee(01, "Harsh", 20000);
            emp.CalculateTax();

            Product prd = new Product(1, 2000, 12);
            prd.CalculateTax();

            Console.ReadLine();
        }
    }
}
