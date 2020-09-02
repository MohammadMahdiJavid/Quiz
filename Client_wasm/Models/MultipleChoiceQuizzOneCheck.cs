namespace Client_wasm.Components.Quizz
{
    public class MultipleChoiceQuizzOneCheckModel
    {
        public string Choice {get; set;} = "";
        public bool IsChecked {get; set;} = false;
        public string IsShow1 {get; set;} = "checked";
        public string IsShow2 {get; set;} = "visibility: hidden;";
        public MultipleChoiceQuizzOneCheckModel ()
        {
        }

        public MultipleChoiceQuizzOneCheckModel (string Choice)
            :this()
        {
            this.Choice = Choice;
        }
    }
}