using Microsoft.EntityFrameworkCore;
using QLSV_CODE_FIRST.Models;

namespace QLSV_CODE_FIRST.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Khoa>().HasData(
                    new Khoa { id = 1, tenKhoa = "Khoa công nghệ số" },
                    new Khoa { id = 2, tenKhoa = "Khoa điện - điện tử" },
                    new Khoa { id = 3, tenKhoa = "Khoa cơ khí" },
                    new Khoa { id = 4, tenKhoa = "Khoa xây dựng" }
                );
            modelBuilder.Entity<Lop>().HasData(
                    new Lop { id = 1, tenLop = "21T1", khoaId = 1 },
                    new Lop { id = 2, tenLop = "21T2", khoaId = 1 },
                    new Lop { id = 3, tenLop = "21T3", khoaId = 1 },
                    new Lop { id = 4, tenLop = "21D1", khoaId = 2 },
                    new Lop { id = 5, tenLop = "21D2", khoaId = 2 },
                    new Lop { id = 6, tenLop = "21D3", khoaId = 2 },
                    new Lop { id = 7, tenLop = "21C1", khoaId = 3 },
                    new Lop { id = 8, tenLop = "21C2", khoaId = 3 },
                    new Lop { id = 9, tenLop = "21C3", khoaId = 3 },
                    new Lop { id = 10, tenLop = "21XD1", khoaId = 4 },
                    new Lop { id = 11, tenLop = "21XD1", khoaId = 4 },
                    new Lop { id = 12, tenLop = "21XD1", khoaId = 4 }
                );
            modelBuilder.Entity<SinhVien>().HasData(
                    new SinhVien { id = 1, tenSinhVien = "Trần Công Quang Phú", age = 20, lopId = 3 },
                    new SinhVien { id = 2, tenSinhVien = "Phạm Thanh Trúc", age = 21, lopId = 1 },
                    new SinhVien { id = 3, tenSinhVien = "Lê Phước Đức", age = 19, lopId = 5 },
                    new SinhVien { id = 4, tenSinhVien = "Trần Văn Lượng", age = 22, lopId = 6 },
                    new SinhVien { id = 5, tenSinhVien = "Hồ Đăng Quốc Anh", age = 19, lopId = 2 },
                    new SinhVien { id = 6, tenSinhVien = "Trương Văn Lâm", age = 18, lopId = 3 },
                    new SinhVien { id = 7, tenSinhVien = "Phan Lê Văn Minh", age = 18, lopId = 7 },
                    new SinhVien { id = 8, tenSinhVien = "Phạm Văn Bảo", age = 19, lopId = 12 }
                );
        }

    }
}
