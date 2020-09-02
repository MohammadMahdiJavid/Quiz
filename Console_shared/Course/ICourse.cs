namespace Console_shared
{
    public interface ICourse
    {
        public string Name {get; set;}
        public int TotalScore {get; set;}
        public int Exercises {get; set;}
        public string Description {get; set;}
        public string Author {get; set;}
        public string Chapters {get; set;}
        public int Id {get; set;}
        public string ImagePath {get; set;}
    }
}