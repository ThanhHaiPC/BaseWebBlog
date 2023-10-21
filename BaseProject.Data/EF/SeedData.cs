using BaseProject.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Data.EF
{
    public class SeedData
    {

        private readonly ModelBuilder modelBuilder;

        public SeedData(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            //      AppConfig
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "Đây là trang chủ của Web_Blog" },
               new AppConfig() { Key = "HomeKeyWord", Value = "Đây là từ khóa của Web_Blog" },
               new AppConfig() { Key = "HomeDescription", Value = "Đây là mô tả của Web_Blog" }
               );
            //      Category
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoriesID = 1,
                    Name = "BÓNG ĐÁ",
                },
                new Category()
                {
                    CategoriesID = 2,
                    Name = "THẾ GIỚI",
                },
                new Category()
                {
                    CategoriesID = 3,
                    Name = "XÃ HỘI",
                },
                new Category()
                {
                    CategoriesID = 4,
                    Name = "VĂN HÓA",
                },
                new Category()
                {
                    CategoriesID = 5,
                    Name = "KINH TẾ",
                },
                new Category()
                {
                    CategoriesID = 6,
                    Name = "GIÁO DỤC",
                },
                new Category()
                {
                    CategoriesID = 7,
                    Name = "THỂ THAO",
                },
                new Category()
                {
                    CategoriesID = 8,
                    Name = "GIẢI TRÍ",
                },
                new Category()
                {
                    CategoriesID = 9,
                    Name = "PHÁP LUẬT",
                },
                new Category()
                {
                    CategoriesID = 10,
                    Name = "CÔNG NGHỆ",
                },
                new Category()
                {
                    CategoriesID = 11,
                    Name = "KHOA HỌC",
                },
                new Category()
                {
                    CategoriesID = 12,
                    Name = "ĐỜI SỐNG ",
                },
                new Category()
                {
                    CategoriesID = 13,
                    Name = "XE CỘ",
                },
                new Category()
                {
                    CategoriesID = 14,
                    Name = "NHÀ ĐẤT",
                });
            //      ADMINISTRATOR
            var roleId = new Guid("B470C0C0-5890-4394-A7A5-DBFB572DCBDF");
            var roleId1 = new Guid("3EE42FF4-8B22-44B0-848F-A6A422405AA9");
            var adminId = new Guid("062D4AA7-32C4-4E97-8CA7-CA3B4D97280C");

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = roleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator Role"
                },
                new Role
                {
                    Id = roleId1,
                    Name = "user",
                    NormalizedName = "user",
                    Description = "User Role"
                });


            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = adminId,
                UserName = "admin",
                Name = "Phạm Thanh Hải",             
                NormalizedUserName = "admin",
                Email = "abcd@gmail.com",
                NormalizedEmail = "abcd@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Aa@123"),
                SecurityStamp = string.Empty,
                Image = "",
                DateOfBir = new DateTime(2002, 03, 18),
                Address = "Biên Hòa Đồng Nai"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
