namespace PollingSystem.Entities;

public class PollAnswer
{
    public PollAnswer(int id, string title)
    {
        Id = id;
        Title = title;
    }
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int Votes { get; set; }
    public double Precents {get; set;}

    public override string ToString()
    {
        return $"* {Title} ({Votes} - {Precents:F})";
    }

    public void SetPercents(int totalVotes)
    {
        if (totalVotes > 0)
        {
            Precents = Votes * 100d / totalVotes;
        }
    }
   
   
}