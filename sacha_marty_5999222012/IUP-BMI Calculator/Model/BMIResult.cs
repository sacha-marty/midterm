using AndroidX.Annotations;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.Model
{
    [Table("BMIResult")]
    public class BMIResult
    {
        [PrimaryKey , AutoIncrement,Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }

        public  double Weight{ get; set; }
        public double  Height { get; set; }
        public double BMI_score { get; set; }
        
        public string Result { get; set; }



    }
}
