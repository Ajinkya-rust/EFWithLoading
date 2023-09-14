using EFWithLoading.Entities;

namespace EFWithLoading
{
    internal class Program
    {
        //    static void Main(string[] args)
        //    {
        //        try
        //        {
        //            var context = new EFCoreDbContext();
        //            //Loading Related Entities using Eager Loading
        //            //While Loading the Student table data, it is also going to load the Standard, StudentAddress and Courses tables data
        //            var teachers = new List<Teacher>();
        //            var std = context.Students.Where(s => s.FirstName == "Pranaya")
        //                     .Select(s => new
        //                     {
        //                         Student = s,
        //                         Standard = s.Standard,
        //                         Teachers = (s.Standard != null) ? s.Standard.Teachers : teachers
        //                     })
        //                     .FirstOrDefault();
        //            Console.WriteLine($"Firstname: {std?.Student?.FirstName}, Lastname: {std?.Student?.LastName}, StandardName: {std?.Student?.Standard?.StandardName}, Description: {std?.Student?.Standard?.Description}");
        //            if (std?.Student?.Standard != null)
        //            {
        //                //You can also access the Teacher collection here
        //                foreach (var teacher in std.Student.Standard.Teachers)
        //                {
        //                    Console.WriteLine($"\tTeacher ID: {teacher.TeacherId}, Name: {teacher.FirstName} {teacher.LastName}");
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error: {ex.Message}"); ;
        //        }
        //    }
        //}

        //    static void Main(string[] args)
        //    {
        //        try
        //        {
        //            var context = new EFCoreDbContext();
        //            //Loading the particular student data only
        //            //Here, it will only load the Student Data, no related entities
        //            Student? student = context.Students.FirstOrDefault(std => std.StudentId == 1);
        //            Console.WriteLine($"Firstname: {student?.FirstName}, Lastname: {student?.LastName}");
        //            Console.WriteLine();
        //            //I want to Disable Lazy Loading Here
        //            context.ChangeTracker.LazyLoadingEnabled = false;
        //            //As Lazy Loading is Disabled so, it will not load the Standard data
        //            Standard? standard = student?.Standard;
        //            Console.WriteLine($"StandardName: {standard?.StandardName}, Description: {standard?.Description}");
        //            Console.WriteLine();
        //            //I want to Enable Lazy Loading Here
        //            context.ChangeTracker.LazyLoadingEnabled = true;
        //            //As Lazy Loading is Enabled so, it will load the StudentAddress data
        //            StudentAddress? studentAddress = student?.StudentAddress;
        //            Console.WriteLine($"AddresLin1 {studentAddress?.Address1}, AddresLin2 {studentAddress?.Address2}");
        //            Console.WriteLine();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error: {ex.Message}"); ;
        //        }
        //    }
        //}
        //       static void Main(string[] args)
        //    {
        //        try
        //        {
        //            var context = new EFCoreDbContext();
        //            //Loading the particular student data only
        //            //Here, it will only load the Student Data, no related entities
        //            Student? student = context.Students.FirstOrDefault(std => std.StudentId == 1);
        //            Console.WriteLine($"Firstname: {student?.FirstName}, Lastname: {student?.LastName}");
        //            Console.WriteLine();
        //            //I want to Disable Lazy Loading Here
        //            context.ChangeTracker.LazyLoadingEnabled = false;
        //            //As Lazy Loading is Disabled so, it will not load the Standard data
        //            Standard? standard = student?.Standard;
        //            Console.WriteLine($"StandardName: {standard?.StandardName}, Description: {standard?.Description}");
        //            Console.WriteLine();
        //            //I want to Enable Lazy Loading Here
        //            context.ChangeTracker.LazyLoadingEnabled = true;
        //            //As Lazy Loading is Enabled so, it will load the StudentAddress data
        //            StudentAddress? studentAddress = student?.StudentAddress;
        //            Console.WriteLine($"AddresLin1 {studentAddress?.Address1}, AddresLin2 {studentAddress?.Address2}");
        //            Console.WriteLine();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error: {ex.Message}"); ;
        //        }
        //    }
        //}

        static void Main(string[] args)
        {
            try
            {
                var context = new EFCoreDbContext();
                //Loading the particular student data only
                //Here, it will only load the Student Data, no related entities
                Student? student = context.Students.FirstOrDefault(std => std.StudentId == 1);
                Console.WriteLine($"Firstname: {student?.FirstName}, Lastname: {student?.LastName}");
                Console.WriteLine();
                //As Lazy Loading is Disabled so, it will not load the Standard data
                Standard? standard = student?.Standard;
                Console.WriteLine($"StandardName: {standard?.StandardName}, Description: {standard?.Description}");
                Console.WriteLine();
                //As Lazy Loading is Disabled so, it will load the StudentAddress data
                StudentAddress? studentAddress = student?.StudentAddress;
                Console.WriteLine($"AddresLin1 {studentAddress?.Address1}, AddresLin2 {studentAddress?.Address2}");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); ;
            }
        }
    }
}