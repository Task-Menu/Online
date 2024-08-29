using AcademySystem.Data;
using AcademySystem.Enums;
using AcademySystem.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademySystem.Extensions;

public static class DatabaseInitializer
{
    private static readonly Faker _faker = new();
    private static readonly AcademySystemDbContext context = new();

    public static void SeedDatabase()
    {
        try
        {
            AddStudents(context);
            AddMentors(context);
            AddCourses(context);
            AddMentorCourse(context);
            AddGroups(context);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void AddStudents(AcademySystemDbContext context)
    {
        if (context.Students.Any())
            return;
        
        for(int i = 0; i < 200; i++)
        {
            var firstName = _faker.Name.FirstName();
            var student = new Student
            {
                FirstName = firstName,
                LastName = _faker.Name.LastName(),
                PhoneNumber = _faker.Phone.PhoneNumber("+998#########"),
                Email = $"{firstName}@gmail.com"
            };
            context.Students.Add(student);
        }
        context.SaveChanges();
    }

    private static void AddMentors(AcademySystemDbContext context)
    {
        if (context.Mentors.Any())
            return;

        for(int i = 0; i < 30; i++)
        {
            var mentor = new Mentor
            {
                FirstName = _faker.Name.FirstName(),
                LastName = _faker.Name.LastName(),
                PhoneNumber = _faker.Phone.PhoneNumber("+998#########"),
                Degree = _faker.Random.Enum<Degree>()
            };
            context.Mentors.Add(mentor);
        }    
        context.SaveChanges();
    }

    private static void AddCourses(AcademySystemDbContext context)
    {
        if (context.Courses.Any())
            return;

        List<Course> courses = [];
        for (int i = 0; i < 20; i++)
        {
            var courseName = _faker.Name.JobTitle();
            int attempts = 0;

            while (courses.Any(x => x.Name == courseName) && attempts < 10)
            {
                courseName = _faker.Name.JobTitle();
                attempts++;
            }
            if (attempts == 10)
                continue;
            
            var course = new Course
            {
                Name = courseName,
                Description = _faker.Name.JobDescriptor(),
                Price = _faker.Random.Decimal(1_000_000, 2_500_000),
                NumberOfModules = _faker.Random.Int(7, 10),
                Rating = _faker.Random.Decimal(0, 5)
            };
            courses.Add(course);
        }
        context.Courses.AddRange(courses);
        context.SaveChanges();
    }

    private static void AddMentorCourse(AcademySystemDbContext context)
    {
        if(context.MentorCourses.Any()) 
            return;

        var courseIds = context.Courses.Select(x => x.Id).ToList();
        var mentorIds = context.Mentors.Select(x => x.Id).ToList();

        foreach(var mentor in mentorIds)
        {
            var numberOfCourses = _faker.Random.Int(1, 4);
            HashSet<int> mentorCourses = [];

            for(int i = 0; i <  numberOfCourses; i++)
            {
                var randomId = _faker.PickRandom(courseIds);
                mentorCourses.Add(randomId);
            }

            foreach(var mentorCourseId in mentorCourses)
            {
                var mentorCourse = new MentorCourse
                {
                    MentorId = mentor,
                    CourseId = mentorCourseId,
                };
                context.MentorCourses.Add(mentorCourse);
            }
            context.SaveChanges();
        }
    }

    private static void AddGroups(AcademySystemDbContext context)
    {
        if (context.Groups.Any()) 
            return;

        var mentors = context.MentorCourses.Select(x => x.Id).ToList();

        for(int i = 0; i < 40; i++)
        {
            var mentorId = _faker.PickRandom(mentors);
            var group = new Gruop
            {
                Name = _faker.Lorem.Word(),
                Mode = _faker.Random.Enum<StudyMode>(),
                MentorCourseId = mentorId,
            };
            context.Groups.Add(group);
        }
        context.SaveChanges();
    }
}
