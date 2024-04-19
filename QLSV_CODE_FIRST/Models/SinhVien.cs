using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV_CODE_FIRST.Models
{
    public class SinhVien
    {
        public int id { get; set; }
        public string tenSinhVien { get; set; }
        public int age { get; set; }
        public int lopId { get; set; }
        [ForeignKey(nameof(lopId))]
        public Lop lop { get; set; }
    }
}
