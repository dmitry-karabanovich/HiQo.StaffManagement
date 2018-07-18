using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Models;

namespace HiQo.StaffManagement.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CompanyContext context)
        {
            var roles = new List<Role>();
            var departments = new List<Department>();
            var categories = new List<Category>();
            var positions = new List<Position>();
            var positionLevels = new List<PositionLevel>();
            var users = new List<User>();

            roles.Add(new Role {Name = "User", RoleId = 1});
            roles.Add(new Role {Name = "Admin", RoleId = 2});
            roles.Add(new Role {Name = "SuperAdmin", RoleId = 3});

            departments.Add(new Department {Name = "Resource Management", DepartmentId = 1});
            departments.Add(new Department {Name = "Software Development", DepartmentId = 2 });
            departments.Add(new Department {Name = "Quality Assurance", DepartmentId = 3 });
            departments.Add(new Department {Name = "Business Analysis", DepartmentId = 4 });

            categories.Add(new Category {Name = "Administration staff", DepartmentId = 1, CategoryId = 1});
            categories.Add(new Category {Name = "Management", DepartmentId = 1, CategoryId = 2 });
            categories.Add(new Category {Name = ".NET Development", DepartmentId = 2, CategoryId = 3 });
            categories.Add(new Category {Name = "Java Development", DepartmentId = 2, CategoryId = 4 });
            categories.Add(new Category {Name = "Python Development", DepartmentId = 2, CategoryId = 5 });
            categories.Add(new Category {Name = "Front-End Development", DepartmentId = 2, CategoryId = 6 });
            categories.Add(new Category {Name = "Quality Assurance", DepartmentId = 3, CategoryId = 7 });
            categories.Add(new Category {Name = "Business Analysis", DepartmentId = 4, CategoryId = 8 });

            positions.Add(new Position {Name = "English Teacher", CategoryId = 1, PositionId = 1});
            positions.Add(new Position {Name = "Human Resource Manager", CategoryId = 1, PositionId = 2 });
            positions.Add(new Position {Name = "Accountant", CategoryId = 1, PositionId = 3 });
            positions.Add(new Position {Name = "Chief Executive Officer", CategoryId = 2, PositionId = 4 });
            positions.Add(new Position {Name = "Director of Delivery", CategoryId = 2, PositionId = 5 });
            positions.Add(new Position {Name = ".NET Developer", CategoryId = 3, PositionId = 6 });
            positions.Add(new Position {Name = "Java Developer", CategoryId = 4, PositionId = 7 });
            positions.Add(new Position {Name = "Python Developer", CategoryId = 5, PositionId = 8 });
            positions.Add(new Position {Name = "Front-End Developer", CategoryId = 6, PositionId = 9 });
            positions.Add(new Position {Name = "QA Engineer", CategoryId = 7, PositionId = 10 });
            positions.Add(new Position {Name = "Business analyst", CategoryId = 8, PositionId = 11 });

            positionLevels.Add(new PositionLevel {Name = "Intern", Level = null, PositionLevelId = 1});
            positionLevels.Add(new PositionLevel {Name = "Junior", Level = 0, PositionLevelId = 2 });
            positionLevels.Add(new PositionLevel {Name = "Junior", Level = 1, PositionLevelId = 3 });
            positionLevels.Add(new PositionLevel {Name = "Junior", Level = 2, PositionLevelId = 4 });
            positionLevels.Add(new PositionLevel {Name = "Staff", Level = 0, PositionLevelId = 5 });
            positionLevels.Add(new PositionLevel {Name = "Staff", Level = 1, PositionLevelId = 6 });
            positionLevels.Add(new PositionLevel {Name = "Staff", Level = 2, PositionLevelId = 7 });
            positionLevels.Add(new PositionLevel {Name = "Senior", Level = 0, PositionLevelId = 8 });
            positionLevels.Add(new PositionLevel {Name = "Senior", Level = 1, PositionLevelId = 9 });
            positionLevels.Add(new PositionLevel {Name = "Senior", Level = 2, PositionLevelId = 10 });

            users.Add(new User
            {
                FirstName = "Dmitry",
                LastName = "Karabanovich",
                DateOfBirth = new DateTime(1999, 7, 8),
                RoleId = 1,
                PositionLevelId = 1,
                PositionId = 6,
                CategoryId = 3,
                DepartmentId = 2,
                UserId = 1
            });
            users.Add(new User
            {
                FirstName = "Nikolay",
                LastName = "Sidorenko",
                DateOfBirth = new DateTime(1999, 5, 20),
                RoleId = 1,
                PositionLevelId = 1,
                PositionId = 6,
                CategoryId = 3,
                DepartmentId = 2,
                UserId = 2
        });
            users.Add(new User
            {
                FirstName = "Kirill",
                LastName = "Dudkov",
                DateOfBirth = new DateTime(1997, 10, 21),
                RoleId = 1,
                PositionLevelId = 1,
                PositionId = 6,
                CategoryId = 3,
                DepartmentId = 2,
                UserId = 3
        });

            roles.ForEach(a => context.Roles.AddOrUpdate(a));
            departments.ForEach(a => context.Departments.AddOrUpdate(a));
            categories.ForEach(a => context.Categories.AddOrUpdate(a));
            positions.ForEach(a => context.Positions.AddOrUpdate(a));
            positionLevels.ForEach(a => context.PositionLevels.AddOrUpdate(a));
            users.ForEach(a => context.Users.AddOrUpdate(a));

            context.SaveChanges();
        }
    }
}