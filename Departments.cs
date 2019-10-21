using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoviFlow_For_NaviStar_Web_Authenication.Data
{
    public class Departments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }

        public string DName { get; set; }

        [Display(Name = "Dept Head")]
        public string Dhead { get; set; }

        [ForeignKey("EID")]
        public Employees employeesId { get; set; }
    }
}