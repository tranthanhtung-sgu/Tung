using System;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {   
        public static void Seed(this ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Class>().HasData(
                    new Class () {Id = 1, name = "A101", startDate = new DateTime(12/2/2019),
                    endDate = new DateTime(12/5/2019), price = 1000000, teacherId = 1, courseId =1}
                );
                modelBuilder.Entity<User>().HasData(
                    new User () {id = 1,username = "tung", password = "123456", birthday=new DateTime(1999-03-22), phonenumber=0338915243},
                    new User () {id = 2, username = "anhtung", password = "123456", birthday=new DateTime(1999-03-22), phonenumber=0338915243},
                    new User () {id = 3, username = "tranthanhtung", password = "123456", birthday=new DateTime(1999-03-22), phonenumber=0338915243}
                );
                modelBuilder.Entity<Payment>().HasData(
                    new Payment () { Id = 1, paymentDate = new DateTime(14/11/2020), amount = 10, Class = new List<Class>(), paymentMethod = 0,
                    status = 0, studentId = 1, classId = 1}
                );
                modelBuilder.Entity<Student>().HasData(
                    new Student () { Id = 1, email = "tungtranthanh258@gmail.com", password = "123465", firstName = "Tran Thanh", lastName = "Tung",
                    Address = "HCM", dob = new DateTime(1999-03-22), phone = "0338915243",
                    }
                );
            }
    }
}