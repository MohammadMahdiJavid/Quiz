using System;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using Console_shared;

namespace UserApi
{
    public class MyDbContext : DbContext
    {
        public DbSet<QuizzModel> Quizzes {get; set;}
        public DbSet<UserModel> Users {get;set;}
        public DbSet<CourseModel> Courses {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite("Data Source=Users.sqlite");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizzModel>().HasData (
                new QuizzModel {
                    Name = "Function" ,
                    URL = "/courses/function" ,
                    Score = 50 ,
                    TotalTime = "00:05:00" ,
                    Question = "Which Keyword is used to implement a function? " ,
                    Choices = "def#else#while#class" ,
                    AnswerIndex = "0#" ,
                    Model = QuizzType.MultipleChoice ,
                    Id = 1
                } ,
                new QuizzModel {
                    Name = "Function" ,
                    URL = "/courses/function" ,
                    Score = 100 ,
                    TotalTime = "00:08:00" ,
                    Question = "Which one is used to Create a function named Demo? " ,
                    Choices = "class Demo :#def Demo :#Demo = []#Demo = {}" ,
                    AnswerIndex = "1#" ,
                    Model = QuizzType.MultipleChoice ,
                    Id = 2
                } ,
                new QuizzModel {
                    Name = "Function" ,
                    URL = "/courses/function" ,
                    Score = 50 ,
                    TotalTime = "00:03:00" ,
                    Question = "Which one is used to Call a function named foo? " ,
                    Choices = "foo#x=foo;  x()#foo[0]#foo()" ,
                    AnswerIndex = "1#3" ,
                    Model = QuizzType.MultipleChoice ,
                    Id = 3
                } ,
                new QuizzModel {
                    Name = "Function" ,
                    URL = "/courses/function" ,
                    Score = 75 ,
                    TotalTime = "00:04:00" ,
                    Question = "Which one is used to implement a function named plot with x parameter? " ,
                    Choices = "plot()#def plot :#plot(x)#def plot (x) :" ,
                    AnswerIndex = "3#" ,
                    Model = QuizzType.MultipleChoice ,
                    Id = 4
                } 
            );

            modelBuilder.Entity<UserModel>().HasData (
                new UserModel 
                {
                    Email = "ali@gmail.com" ,
                    Password = "123" ,
                    BackupQuestion = "how old are you?" ,
                    BackupAnswer = "12" ,
                    Id = 1 ,
                    Name = "Ali" ,
                    About = "Hi,\nMy Name is Ali" ,
                    Courses = "function" ,
                    LastName = "Alamdari" ,
                    Phone = "09901213509" ,
                    Profession = "Web Developer" ,
                    ProfileImage = "http://localhost:6001/Profile Images/925b1513-89b0-4183-86db-accbae580272.jpg" ,
                    Score = 330 ,
                    Skills = "C# Programming" ,
                    Websites = "https://ali6600alamdari.github.io/" ,
                    IsAuthorized = false ,
                    Scores = "20#50#100#20#10#50#100"
                }
            );

            string BaseUrl = @"http://localhost:6001/Courses/Images/";
            modelBuilder.Entity<CourseModel>().HasData (
                new CourseModel {
                    Name = "Function" ,
                    Description = "Python Course for Learning How functions Works." ,
                    Exercises = 10 ,
                    TotalScore = 750 ,
                    Chapters = "Intro#Lambda#Decorators" ,
                    Id = 1 ,
                    ImagePath = $"{BaseUrl}/Function.png" ,
                    Author = "MohammadMahdi Javid"
                } ,
                new CourseModel {
                    Name = "Regex" ,
                    Description = "Learning How to Extract data in the easy way from csv, string, texts." ,
                    Exercises = 13 ,
                    TotalScore = 900 ,
                    Chapters = "" ,
                    Id = 2 ,
                    ImagePath = $"{BaseUrl}/Regex.png" ,
                    Author = "MohammadMahdi Javid"
                } ,
                new CourseModel {
                    Name = "Numpy" ,
                    Description = "Intro DataScient Course for working with Numerical Python Library." ,
                    Exercises = 15 ,
                    TotalScore = 1000 ,
                    Chapters = "" ,
                    Id = 3 ,
                    ImagePath = $"{BaseUrl}/Numpy.png" ,
                    Author = "MohammadMahdi Javid"
                } ,
                new CourseModel {
                    Name = "NetworkX" ,
                    Description = "NetworkX is kind of Graph based Library." ,
                    Exercises = 10 ,
                    TotalScore = 500 ,
                    Chapters = "" ,
                    Id = 4 ,
                    ImagePath = $"{BaseUrl}/NetworkX.png" ,
                    Author = "MohammadMahdi Javid"
                } ,
                new CourseModel {
                    Name = "Plotting" ,
                    Description = "Working with plotting libraries." ,
                    Exercises = 10 ,
                    TotalScore = 500 ,
                    Chapters = "Seaborn#MatPlotLib#" ,
                    Id = 5 ,
                    ImagePath = $"{BaseUrl}/Plotting.png" ,
                    Author = "MohammadMahdi Javid"
                }
            );
        }
    }
}
