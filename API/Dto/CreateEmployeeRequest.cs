using System.ComponentModel.DataAnnotations;

namespace Employee.Dto
{
    public class CreateEmployeeRequest
    {
        [Required]
        public string FirstName { get; private set; }

        [Required]
        public string LastName { get; private set; }

        public CreateEmployeeRequest(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
