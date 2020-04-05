using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers

{
    [ApiController]
    [Route("api/students")]

    public class StudentsController : ControllerBase

    {
        [HttpGet]
        public string GetStudents(string orderBy)
        {
            return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentDetails(int id)
        {
           if (id == 1)
            {
                return Ok("Jan Kowalski");
            }else if (id == 2)
            {
                return Ok("Andrzej Malewski");
            }
            return NotFound("Nie znaleziono studenta");
        }

        [HttpPost]

        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 10000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveStudent(int id)
        {
            
            return Ok(student);
        }
    }
}