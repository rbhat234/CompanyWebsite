using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net;
using WebApplication1.Models;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebApplication1.Controllers
{
  public class EmployeesController : ApiController
  {
                // GET: Employees
       public HttpResponseMessage Get()
       {
          string query = @"
                      select * from dbo.UserDetails ";
              DataTable table = new DataTable();
              using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["EmployeesAppDB"].ConnectionString))
                 using(var cmd = new SqlCommand(query,con))
                using(var da = new SqlDataAdapter(cmd))
               {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
                }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        } 

    public string Post(Employees emp)
    {
      try
      {
        string query = @"
                    insert into dbo.UserDetails values
                    ('" + emp.UserName + @"',
                     '" + emp.UserFirstName + @"',
                     '" + emp.UserLastName + @"',
                     '" + emp.CompanyName + @"',
                     '" + emp.email + @"',
                     '" + emp.paswd + @"',
                     '" + emp.UserCatalouge + @"',
                     '" + emp.UserCountry + @"',
                     '" + emp.UserRole + @"',
                     '" + emp.UserIsActive + @"'  )
                    ";
        DataTable table = new DataTable();
        using (var con = new SqlConnection(ConfigurationManager.
            ConnectionStrings["EmployeesAppDB"].ConnectionString))
        using (var cmd = new SqlCommand(query, con))
        using (var da = new SqlDataAdapter(cmd))
        {
          cmd.CommandType = CommandType.Text;
          da.Fill(table);
        }
        return "Inserted Successfully.";
      }
      catch (Exception)
      {

        return "FAILED TO Insert";
      }
    }

    public string Login(Employees emp)
    {
      try
      {
        string query = @"
                    SELECT  * from dbo.User where
                    email='" + emp.email + @"',
                    paswd='" + emp.paswd + @"'
                ";
        DataTable table = new DataTable();
        using (var con = new SqlConnection(ConfigurationManager.
            ConnectionStrings["EmployeesAppDB"].ConnectionString))
        using (var cmd = new SqlCommand(query, con))
        using (var da = new SqlDataAdapter(cmd))
        {
          cmd.CommandType = CommandType.Text;
          da.Fill(table);
        }
        return "Welcome.";
      }
      catch (Exception)
      {
        return "FAILED.";
      }
    }

       public string Put(Employees emp)
       {
           try
           {
               string query = @"
                   update dbo.UserDetails set
                   UserName='" + emp.UserName + @"', 
                   UserFirstName='" +emp.UserFirstName+ @"',
                   UserLastName='" + emp.UserLastName + @"',
                   CompanyName='" + emp.CompanyName + @"',
                   email='" + emp.email + @"',
                   paswd='" + emp.paswd + @"'
                   UserCatalouge='" + emp.UserCatalouge + @"',
                   UserCountry='" + emp.UserCountry + @"',
                   UserRole= '" + emp.UserRole + @"',
                   UserIsActive='" + emp.UserIsActive + @"'
                   where uid='" + emp.uid + @"'
                    
               ";
               DataTable table = new DataTable();
               using (var con = new SqlConnection(ConfigurationManager.
                   ConnectionStrings["EmployeesAppDB"].ConnectionString))
               using (var cmd = new SqlCommand(query, con))
               using (var da = new SqlDataAdapter(cmd))
               {
                   cmd.CommandType = CommandType.Text;
                   da.Fill(table);
               }
               return "Updated Successfully.";
           }
           catch(Exception)
           {
               return "FAILED TO Update.";
           }
       }

       public string Delete(int id)
       {
           try
           {
               string query = @"
                                  delete from dbo.UserDetails where uid=" + id + @" ";

        DataTable table = new DataTable();
               using (var con = new SqlConnection(ConfigurationManager.
                   ConnectionStrings["EmployeesAppDB"].ConnectionString))
               using (var cmd = new SqlCommand(query, con))
               using (var da = new SqlDataAdapter(cmd))
               {
                   cmd.CommandType = CommandType.Text;
                   da.Fill(table);
               }
               return "Deleted Successfully.";
           }
           catch(Exception)
           {
               return "FAILED TO DELETE.";
           }
       }


       [Route("api/Employees/GetALLEmployees")]
       [HttpGet]


       public HttpResponseMessage GetAllEmployees()
       {
           string query = @"select * from dbo.UserDetails ";
           DataTable table = new DataTable();
           using (var con = new SqlConnection(ConfigurationManager.
               ConnectionStrings["EmployeesAppDB"].ConnectionString))
           using (var cmd = new SqlCommand(query, con))
           using (var da = new SqlDataAdapter(cmd))
           {
               cmd.CommandType = CommandType.Text;
               da.Fill(table);
           }
           return Request.CreateResponse(HttpStatusCode.OK, table);
       } 
  }
}
//
