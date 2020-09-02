public class DataItem
{
    public int Score {get; set;}
    public int Idx {get; set;}
    public DataItem(int score, int idx)
    {
        this.Score = score;
        this.Idx = idx;
    }
}