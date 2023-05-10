using PollingSystem.Entities;

namespace PollingSystem.ConsoleClient;

public class PollBuilder
{
    private readonly string _questionsText;
    private readonly List<PollAnswer> _items = new();
    public PollBuilder(string questionsText)
    {
        _questionsText = questionsText;
    }
    public PollBuilder AddAnswer(int id, string title)
    {
        _items.Add(new PollAnswer(id, title));
        return this;
    }
    public Poll Build()
    {
        return new Poll(_questionsText, _items);
    }
    public PollResults GetResults(Poll poll) =>  new (poll);
}