using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studenstProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class studentsDetailsController : ControllerBase
    {
        [HttpGet]
        public studentsDetails[] Get()
        {
            return students.studenstList.ToArray();
        }

        [HttpGet]
        [Route("search/{text}")]
        public studentsDetails[] Get(string text)
        {
            List<studentsDetails> results = new List<studentsDetails>();

            for (int i = 0; i < students.studenstList.Count; i++)
            {
                if (students.studenstList[i].firstName.ToUpper().Contains(text.ToUpper()) ||
                     students.studenstList[i].lastName.ToUpper().Contains(text.ToUpper()) ||
                     students.studenstList[i].tz.ToString().Contains(text))
                {
                    results.Add(students.studenstList[i]);
                }
            }
            return results.ToArray();
        }
    }
}
