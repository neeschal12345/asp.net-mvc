using Leapfrog.Web.App.Context;
using Leapfrog.Web.App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Leapfrog.Web.App.Repository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        
    }
    public class StudentRepository : IStudentRepository
    {
        private AppDbConnection conn = new AppDbConnection();
        public void Insert(Student t)
        {
            conn.Students.Add(t);
        }

        public void Update(Student t)
        {
            conn.Entry(t).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Student s = GetById(id);
            conn.Students.Remove(s);
        }

        public List<Student> GetAll()
        {
            return conn.Students.ToList();
        }

        public Student GetById(int id)
        {
            return conn.Students.Find(id);
        }

     }
}