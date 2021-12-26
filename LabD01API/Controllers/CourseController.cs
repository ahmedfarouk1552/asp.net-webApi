using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LabD01API.Models;

namespace LabD01API.Controllers
{
    public class CourseController : ApiController
    {
        public static List<Course> courses = new List<Course>()
        {
            new Course(){id=1,name="C#",duration=60,descreption="intro to .net and C# Basics"},
            new Course(){id=2,name="SQL",duration=50,descreption="structure query language"},
            new Course(){id=3,name="ASP.Net",duration=36,descreption="server side programming"},
            new Course(){id=4,name="MVC",duration=30,descreption="server side programming"},

        };

               // 1 -  get()
        public IHttpActionResult get()
        {
            Course cr = new Course();
            if (cr == null)
                return NotFound();
            else
                return Ok(courses);
        }

              // 2-  deleteCours(id)
        public IHttpActionResult deleteCourse(int id)
        {
            Course cr = courses.Find(n => n.id == id);
            if (cr == null)
                return NotFound();
            courses.Remove(cr);
            return Ok(courses);
        }

               //   3- put(id,course)
        public IHttpActionResult put(int id,Course cr)
        {
            if (cr == null)
                return BadRequest();
            Course c = courses.Find(n => n.id == id);
            if (c == null)
                return NotFound();
            c.id = cr.id;
            c.name = cr.name;
            c.duration = cr.duration;
            c.descreption = cr.descreption;

            return StatusCode(HttpStatusCode.NoContent);

        }

                 //  4-  post(course)
        public IHttpActionResult post(Course cr)
        {
            if (cr == null)
                return BadRequest();
            courses.Add(cr);
            return Ok(cr);
        }

                // 5- getbyid(id)
        public IHttpActionResult getbyid(int id)
        {
            Course cr = courses.Find(n => n.id == id);
            if (cr == null)
                return NotFound();
            else
                return Ok(courses);
        }


               //    6- coursebyname(name)
        [HttpGet]
       // [Route("api/crs/{name}")]    //   برضه مش بتضاف ف الاسم C#  ليه مش شغالة هنا ؟ و ال  
        public IHttpActionResult coursebyname(string name)
        {
            Course c = courses.Find(n=>n.name==name);
            if (c == null)
                return NotFound();
            else
                return Ok(courses);
        }





    }
}
