using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using EFCoreAttMgtSystem.Entities;
using Microsoft.EntityFrameworkCore;
namespace EFCoreAttMgtSystem.Features
{
    public class TimeSheet
    {
        public TimeSheetDbContext DbContext { get; }
        public TimeSheet()
        {
            DbContext = new TimeSheetDbContext();
        }
        public void AddEmployee(Employee emp)
        {
            if(string.IsNullOrEmpty(emp.FullName)||
                string.IsNullOrEmpty(emp.Position)||
                string.IsNullOrEmpty(emp.CardNo)||
                string.IsNullOrEmpty(emp.UserAccount.Username)||
                string.IsNullOrEmpty(emp.UserAccount.Password)) 
            {
                throw new ArgumentException("Please provide all Employee data!.");
            }
            else
            {
                DbContext.Employees.Add(emp);
                DbContext.SaveChanges();
            }
        }
        public void UpdateEmployee(string IdentityId,string FullName,string Position)
        {
            if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Position)){
                // Check for empty data
                throw new ArgumentException("Please provide Employee data!");
            }
            var emp = DbContext.Employees.Find(new Guid(IdentityId));
            if (emp == null)
            {
                throw new ArgumentException("Employee not found!!!");
            }
            // Update employee data
            emp.FullName = FullName;
            emp.Position = Position;
            DbContext.SaveChanges();
        }
        public void LogEmployee(string cardNo,Log logInfo) 
        {
            if (string.IsNullOrEmpty(cardNo))
            {
                // Check for empty card
                throw new ArgumentException("Card No is Empty...!");
            }
            var emp = DbContext.Employees.Include(l=>l.Logs).FirstOrDefault(emp=>emp.CardNo == cardNo.Trim());
            if (emp == null)
            {
                throw new ArgumentException($"Card No {cardNo} not found in Employee list.");
            }
            emp.Logs!.Add(logInfo);
            DbContext.SaveChanges();
        }
        public List<EmployeeView> GetAllEmployee()
        {
            // using LINQ to select data without Log property
            return DbContext.Employees.Select(emp => new EmployeeView()
            {
                IdentityId = emp.EmployeeId,
                FullName = emp.FullName,
                Position = emp.Position,
                CardNo = emp.CardNo
            }).ToList();
        }
        public List<Employee> GetAllEmployee(bool isSimpleVersion) 
        {
            return DbContext.Employees.ToList();
        }
    }
}
