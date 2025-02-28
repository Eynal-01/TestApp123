﻿using TestApp.Entities;

namespace TestApp.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
