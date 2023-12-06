using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels
{
    [Table("ClubEvent")]
    public class ClubEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventID { get; set; }

        public string Venue { get; set; }

        public string Location { get; set; }

        [ForeignKey("associatedClub")]
        public int ClubId { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.DateTime)] // Implements HTML5 DateTime Picker
        public DateTime StartDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.DateTime)] // Implements HTML5 DateTime Picker
        public DateTime EndDateTime { get; set; }

        public virtual Club associatedClub { get; set; }
    }
}