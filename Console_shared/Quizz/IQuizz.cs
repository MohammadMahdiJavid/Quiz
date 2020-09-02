namespace Console_shared
{
    public interface IQuizz
    {
        public string Name {get; set;}
        public string URL {get; set;}
        public int Score {get; set;}
        public bool IsCorrect {get; set;}
        public string TotalTime {get; set;}
        public string StartTime {get; set;}
        public string EndTime {get; set;}
        public string Question {get; set;}
        public string Choices {get; set;}
        public string AnswerIndex {get; set;}
        public QuizzType Model {get; set;}
        public int Id {get; set;}
    }
}