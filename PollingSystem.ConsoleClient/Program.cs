// See https://aka.ms/new-console-template for more information

using PollingSystem.ConsoleClient;
using PollingSystem.Entities;

var builder = new PollBuilder("how are u")
    .AddAnswer(1, "normaly")
    .AddAnswer(2, "so so")
    .AddAnswer(3, "good ")
    .AddAnswer(4, "I am feel is cook");


var poll = builder.Build();

Console.WriteLine(builder.GetResults(poll));
poll.VoteTo(1,5);
poll.VoteTo(3);
poll.VoteTo(4);
poll.VoteTo(3);


var result = builder.GetResults(poll);
Console.WriteLine(result.GetView());