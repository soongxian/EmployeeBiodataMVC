namespace EmployeeBiodataMVC.Models
{
    public class Dynamic_Control
    {
        public string control_type { get; set; }
        public int control_no { get; set; }
        public List<string> control_generated { get; set; } = new List<string>();
    }
}
