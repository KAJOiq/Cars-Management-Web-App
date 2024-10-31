using System.ComponentModel.DataAnnotations;

namespace CarsManagementApp.Model
{
    public class Cars
    {
        // Default Id for all cars
        [Key]
        public int Id { get; set; }

        // The Name of car
        public string Car_Name { get; set; }

        // The Plate number of car
        public string Car_Plate_Number { get; set; }

        // Car Model (2000, 2024, ...)

        [RegularExpression(@"^\d{4}$", ErrorMessage = "Car model must be a 4-digit year.")]
        public int Car_Model { get; set; }

        // The Name of Car's owner
        public string Car_Owner_Name { get; set; }

        // public int MyProperty { get; set; }

    }
}
