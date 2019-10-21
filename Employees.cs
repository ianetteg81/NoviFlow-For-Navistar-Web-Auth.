using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoviFlow_For_NaviStar_Web_Authenication.Data
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }

        [ForeignKey("DID")]
        public Departments departmentId { get; set; }
    }
}