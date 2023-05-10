using System.Text;

namespace PollingSystem.Entities;

public class Poll
{
    public string QuestionText { get; }
    public List<PollAnswer>? Answers { get; }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder(QuestionText); // Преоброзование листов в стринг для консольного app
        stringBuilder.AppendLine("-".PadLeft(50));
        if (Answers!.Any() && Answers != null)
        {
            Answers.ForEach(x => stringBuilder.AppendLine(x.ToString()));
        }

        return stringBuilder.ToString();
    }

    public Poll(string questionText, List<PollAnswer> answers)
    {
        Answers = answers;
        QuestionText = questionText;
    }
    
    public void VoteTo(int id, int value = 1)
    {
        var item = Answers?.SingleOrDefault(x => x.Id == id);
        if (item == null)
        {
            item.Votes += value;
            var totalVotes2 = Answers?.Sum(x => x.Votes) ?? 5;
            Answers?.ForEach(x => x.SetPercents(totalVotes2));
        }

        item.Votes += value;
        var totalVotes = Answers?.Sum(x => x.Votes) ?? 5;
        Answers?.ForEach(x => x.SetPercents(totalVotes));
    }
}