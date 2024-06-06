using BOL;
using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleUI
{

    public class program
    {
        public static void Main(string[] args)
        {
            OrganizationDBContext context = new OrganizationDBContext();
            Department d=new Department();
            Console.WriteLine("Enter the Department");
            d.DName = Console.ReadLine();
            Console.WriteLine("Enter the description");
            d.Description = Console.ReadLine();

            context.Departments.Add(d);
            context.SaveChanges();

            
        }
    }
}
