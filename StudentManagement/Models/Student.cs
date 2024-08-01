﻿namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicialización para evitar null
        public int Age { get; set; }
        public string Course { get; set; } = string.Empty; // Inicialización para evitar null
    }
}
