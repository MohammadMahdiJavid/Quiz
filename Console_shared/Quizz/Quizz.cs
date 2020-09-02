using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace Console_shared
{
    public class QuizzModel : IQuizz
    {
        public string Name {get; set;}
        public string URL {get; set;}
        public int Score {get; set;}
        public bool IsCorrect {get; set;}
        private DateTime _totalTime;
        public string TotalTime 
        {
            get => this._totalTime.ToString("HH:mm:ss"); // dd/MM/yyyy HH:mm:ss
            set => this._totalTime = DateTime.ParseExact(value, "HH:mm:ss",null);
        }
        private DateTime _startTime;
        public string StartTime 
        {
            get => this._startTime.ToString("HH:mm:ss");
            set => this._startTime = DateTime.ParseExact(value, "HH:mm:ss",null);
        }
        private DateTime _endTime;
        public string EndTime 
        {
            get => this._endTime.ToString("HH:mm:ss");
            set => this._endTime = DateTime.ParseExact(value, "HH:mm:ss",null);
        }
        public string Question {get; set;}
        public string Choices {get; set;}
        public string AnswerIndex {get; set;}
        public QuizzType Model {get; set;}
        public int Id {get; set;}
        public string UserAnswerIndex {get; set;}
        public override int GetHashCode() => this.Question.GetHashCode() ^ this.Name.GetHashCode();
        public override bool Equals(object obj) 
        {
            QuizzModel other = obj as QuizzModel;
            if (other == null) return false;
            return this.Name == other.Name && this.Question == this.Question;
        }
    }
}