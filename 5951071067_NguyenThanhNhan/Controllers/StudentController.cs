using _5951071067_NguyenThanhNhan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071067_NguyenThanhNhan.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {

            var StudentList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var Student = new StudentInfo
                {
                    idStudent = i.ToString(),
                    NameStudent = $"Name {i}",
                    AddressStudent = $"{i}" + $"{ i + 1}" + $"{ i + 2}" + $"{ i + 3}"

                };
                StudentList.Add(Student);

            }
            return StudentList;
        }

        // GET: api/Student/5
        public StudentInfo Get(String id)
        {
            if(id.Contains("5951071067")) 
            {
                return new StudentInfo
                {
                    NameStudent = "nguyễn thành nhân",
                    idStudent = id.ToString(),
                    AddressStudent = "Bình Định"
                };
                
            }
            return  new StudentInfo
            {
                idStudent = id.ToString(),
                NameStudent = $"Name {id}",
                AddressStudent = $"{id}" + $"{ id + 1}" + $"{ id + 2}" + $"{ id + 3}"

            }; ;
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
