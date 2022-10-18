// Daniel Decoito
// 10-18-2022 1:45pm
// Mini Challenge 5 "Mad Libs"
// Create a mad lib game where the user inputs verbs, adjectives, and nouns 
// to create fill in the blanks on a story
// Peer reviewd by jasmine leek

Console.Clear();
string terminateGame = "Dan";

Console.WriteLine("Hello user lets play madLibs.");

while (terminateGame != "")
{
    Console.WriteLine("First Lets start with the name of the main character.");
string charName = Console.ReadLine();
Console.WriteLine("and give a name for thier best friend.");
string friendName = Console.ReadLine();
Console.WriteLine("Name a job.");
string shitJob = Console.ReadLine();
Console.WriteLine("name a game");
string game = Console.ReadLine();
Console.WriteLine("Name a Location");
string location = Console.ReadLine();
Console.WriteLine("Name a vehicle brand");
string carType = Console.ReadLine();
Console.WriteLine("Now give an adverb");
string adverbOne = Console.ReadLine();
Console.WriteLine("Now give a second adverb");
string adverbTwo = Console.ReadLine();
Console.WriteLine("Now give an insult");
string insult = Console.ReadLine();
Console.WriteLine("now give us an adjective describing speech");
string adective = Console.ReadLine();


Console.Clear();

Console.WriteLine($"One Day there was a person named {charName} who worked a dead end job as a {shitJob}. After another long day at work {charName} went to his friend {friendName}'s house. They where supposed to play {game} but {charName} could not stop talking about his job as a {shitJob}. {friendName} was tired of hearing {charName} complain about his job again. So {friendName} told {charName} to shut up and go with him to {location}. The two of the hopped into {friendName}'s {carType} and {adverbOne} drove to {location}. Once at {location} {friendName} proceded to {adverbTwo} call {charName} a {insult}. \"You need to quit your job as a {shitJob} and finally join codestack\". {charName} agreed with {friendName} {adective}. \"I'll join codestack\"");

Console.WriteLine("\nWould you like to play again? press any key then enter to replay. otherwise just press enter to end game.");
terminateGame = Console.ReadLine();

}