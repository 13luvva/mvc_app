using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.Models
{
    public class Repository
    {
        private static List<StudentResponse> responses = new List<StudentResponse>();

        public static IEnumerable<StudentResponse> Responses => responses;

        public static void AddResponse(StudentResponse response)
        {
            responses.Add(response);
        }

    }
}
