using System.Text;
using PollingSystem.Entities;

namespace PollingSystem.ConsoleClient;

public class PollResults
{
    private readonly Poll _poll;

    public PollResults(Poll poll)
    {
        _poll = poll;
    }

    public string GetView()
    {
        var stringBuilder = new StringBuilder(_poll.QuestionText); // Преоброзование листов в стринг для консольного app
        stringBuilder.AppendLine("-".PadLeft(50));
        if (_poll.Answers != null)
        {
            _poll.Answers.ForEach(x => stringBuilder.AppendLine(x.ToString()));
        }
        return stringBuilder.ToString();
    }
}