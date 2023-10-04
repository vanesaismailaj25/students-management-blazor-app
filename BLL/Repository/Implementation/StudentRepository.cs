﻿using Microsoft.EntityFrameworkCore;
using StudentsManagement.BLL.Repository.Interfaces;
using StudentsManagement.DAL.Models;
using StudentsManagement.DTO.Student;
using StudentsManagement.Helpers.DbHelpers;
using StudentsManagement.Helpers.Mappers;

namespace StudentsManagement.BLL.Repository.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentsManagementContext context;

        public StudentRepository(StudentsManagementContext context)
        {
            this.context = context;
        }

        public Student CreateStudent(Student_DTO studentDto)
        {
            var student = studentDto.As_Student();
            var toBeCreated = context.Students.Add(student);
            context.SaveChanges();
            return toBeCreated.Entity;
        }

        public async Task<Student_DTO> DeleteStudentAsync(Student_DTO student)
        {
            var toBeDeleted = await context.Students.FirstOrDefaultAsync(x => x.Id == student.Id);
            context.Students.Remove(toBeDeleted!);
            await context.SaveChangesAsync();
            return null;
        }

        public async Task<Student_DTO> FindAsync(string phoneNumber)
        {
            var toBeFound = await context.Students.FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber);
            var studentDTO = toBeFound.AS_Students_DTO();
            return studentDTO;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            var allStudents = await context.Students.ToListAsync();
            return allStudents;
        }

        public bool GetStudentByPhoneNumber(string phoneNumber)
        {
            bool studentByPhoneNumber = context.Students.Any(x => x.PhoneNumber == phoneNumber);
            if (studentByPhoneNumber)
                Console.WriteLine("This student already exists!");
            return true;
        }

        public async Task<string> UpdateStudentAsync(Student_DTO student)
        {
            try
            {
                var toBeUpdated = await context.Students.FirstOrDefaultAsync(x => x.Id == student.Id);

                if (toBeUpdated is null)
                    return "User doesn't exist!";

                toBeUpdated.As_Student_Student(student);

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");

                return $"Something went wrong while updating student with email : {student.Email}";
            }

            return "";
        }
    }
}
