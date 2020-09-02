using Microsoft.EntityFrameworkCore.Migrations;

namespace Server_api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    TotalScore = table.Column<int>(nullable: false),
                    Exercises = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Chapters = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    IsCorrect = table.Column<bool>(nullable: false),
                    TotalTime = table.Column<string>(nullable: true),
                    StartTime = table.Column<string>(nullable: true),
                    EndTime = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Choices = table.Column<string>(nullable: true),
                    AnswerIndex = table.Column<string>(nullable: true),
                    Model = table.Column<int>(nullable: false),
                    UserAnswerIndex = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    BackupQuestion = table.Column<string>(nullable: true),
                    BackupAnswer = table.Column<string>(nullable: true),
                    ProfileImage = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    About = table.Column<string>(nullable: true),
                    Courses = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    Websites = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    BeforeExamScore = table.Column<int>(nullable: false),
                    IsAuthorized = table.Column<bool>(nullable: false),
                    Scores = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "Chapters", "Description", "Exercises", "ImagePath", "Name", "TotalScore" },
                values: new object[] { 1, "MohammadMahdi Javid", "Intro#Lambda#Decorators", "Python Course for Learning How functions Works.", 10, "http://localhost:6001/Courses/Images//Function.png", "Function", 750 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "Chapters", "Description", "Exercises", "ImagePath", "Name", "TotalScore" },
                values: new object[] { 2, "MohammadMahdi Javid", "", "Learning How to Extract data in the easy way from csv, string, texts.", 13, "http://localhost:6001/Courses/Images//Regex.png", "Regex", 900 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "Chapters", "Description", "Exercises", "ImagePath", "Name", "TotalScore" },
                values: new object[] { 3, "MohammadMahdi Javid", "", "Intro DataScient Course for working with Numerical Python Library.", 15, "http://localhost:6001/Courses/Images//Numpy.png", "Numpy", 1000 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "Chapters", "Description", "Exercises", "ImagePath", "Name", "TotalScore" },
                values: new object[] { 4, "MohammadMahdi Javid", "", "NetworkX is kind of Graph based Library.", 10, "http://localhost:6001/Courses/Images//NetworkX.png", "NetworkX", 500 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "Chapters", "Description", "Exercises", "ImagePath", "Name", "TotalScore" },
                values: new object[] { 5, "MohammadMahdi Javid", "Seaborn#MatPlotLib#", "Working with plotting libraries.", 10, "http://localhost:6001/Courses/Images//Plotting.png", "Plotting", 500 });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "AnswerIndex", "Choices", "EndTime", "IsCorrect", "Model", "Name", "Question", "Score", "StartTime", "TotalTime", "URL", "UserAnswerIndex" },
                values: new object[] { 1, "0#", "def#else#while#class", "00:00:00", false, 1, "Function", "Which Keyword is used to implement a function? ", 50, "00:00:00", "00:05:00", "/courses/function", null });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "AnswerIndex", "Choices", "EndTime", "IsCorrect", "Model", "Name", "Question", "Score", "StartTime", "TotalTime", "URL", "UserAnswerIndex" },
                values: new object[] { 2, "1#", "class Demo :#def Demo :#Demo = []#Demo = {}", "00:00:00", false, 1, "Function", "Which one is used to Create a function named Demo? ", 100, "00:00:00", "00:08:00", "/courses/function", null });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "AnswerIndex", "Choices", "EndTime", "IsCorrect", "Model", "Name", "Question", "Score", "StartTime", "TotalTime", "URL", "UserAnswerIndex" },
                values: new object[] { 3, "1#3", "foo#x=foo;  x()#foo[0]#foo()", "00:00:00", false, 1, "Function", "Which one is used to Call a function named foo? ", 50, "00:00:00", "00:03:00", "/courses/function", null });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "AnswerIndex", "Choices", "EndTime", "IsCorrect", "Model", "Name", "Question", "Score", "StartTime", "TotalTime", "URL", "UserAnswerIndex" },
                values: new object[] { 4, "3#", "plot()#def plot :#plot(x)#def plot (x) :", "00:00:00", false, 1, "Function", "Which one is used to implement a function named plot with x parameter? ", 75, "00:00:00", "00:04:00", "/courses/function", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "BackupAnswer", "BackupQuestion", "BeforeExamScore", "Courses", "Email", "IsAuthorized", "LastName", "Name", "Password", "Phone", "Profession", "ProfileImage", "Score", "Scores", "Skills", "Websites" },
                values: new object[] { 1, @"Hi,
My Name is Ali", "12", "how old are you?", 0, "function", "ali@gmail.com", false, "Alamdari", "Ali", "123", "09901213509", "Web Developer", "http://localhost:6001/Profile Images/925b1513-89b0-4183-86db-accbae580272.jpg", 330, "20#50#100#20#10#50#100", "C# Programming", "https://ali6600alamdari.github.io/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
