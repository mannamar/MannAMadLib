// Amardeep Mann
// 10-18-22
// Mini Challenge #5 "Mad Lib"
// Ask the user to input 10 Mad Lib fields and then output the resulting story to the console

Console.Clear();

bool wantsToPlay = true;

while (wantsToPlay) {

  Console.WriteLine("Welcome! We're going to play a game. I'm going to ask you for 10 different words and then I'll tell you a story\n");

  Console.WriteLine("Enter a name"); //1

  string word1 = Console.ReadLine();

  Console.WriteLine("Enter an adjective"); //2

  string word2 = Console.ReadLine();

  Console.WriteLine("Enter a job or occupation"); //3

  string word3 = Console.ReadLine();

  Console.WriteLine("Enter the name of a band"); //4

  string word4 = Console.ReadLine();

  Console.WriteLine("Enter an adjective"); //5

  string word5 = Console.ReadLine();

  Console.WriteLine("Enter another adjective"); //6

  string word6 = Console.ReadLine();

  Console.WriteLine("Enter a noun"); //7

  string word7 = Console.ReadLine();

  Console.WriteLine("Enter a noun (plural)"); //8

  string word8 = Console.ReadLine();

  Console.WriteLine("Enter one last adjective"); //9

  string word9 = Console.ReadLine();

  Console.WriteLine("Enter a verb ending in -ing"); //10

  string word10 = Console.ReadLine();

  Console.WriteLine("\nGreat work! Here's your story:\n");

  Console.WriteLine($"Did you ever hear the tragedy of Darth {word1} the {word2}? I thought not. It\'s not a story a {word3} would tell you. Its a {word4} legend. Darth {word1} was a Dark Lord of {word4}, so {word5} and so {word6} he could use the {word7} to influence midichlorians to create {word8}. He had such a knowledge of the {word9} side of The Force that he could even keep the ones he cared about from {word10}.");

  Console.WriteLine("\nWow what an exciting tale! Do you want to play again?");

  string response = Console.ReadLine().ToLower();

  while (response != "yes" && response != "no" && response != "y" && response != "n") {
    Console.WriteLine("I didn't quite get that. Please type \"y\" or \"n\"");
    response = Console.ReadLine().ToLower();
  }

  if (response == "yes" || response == "y") {
      Console.WriteLine("\nCool! Let's run it back then\n");
    } else {
      wantsToPlay = false;
      Console.WriteLine("\nOh well. We'll see you next time then\n");
      Console.WriteLine(" __      __\n( _\\    /_ )\n \\ _\\  /_ /\n  \\ _\\/_ /_ _\n  |_____/_/ /|\n  (  (_)__)J-)\n  (  /`.,   /\n   \\/  ;   /\n    | === |\n");
    }
}






// "Did you ever hear the tragedy of Darth Plagueis (1 - name) The Wise (2 - adj)? I thought not. Its not a story a Jedi (3 - job) would tell you. It’s a Sith (4 - job2) legend. Darth Plagueis was a Dark Lord of the Sith (repeat 3 - job), so powerful (5 - adj) and so wise (6 - adj) he could use the Force (7 - noun) to influence the midichlorians to create life (8 - noun) … He had such a knowledge of the dark (9 - adj) side that he could even keep the ones he cared about from dying (10 - verb ending in ing).

// // The dark side of the Force is a pathway to many abilities some consider to be unnatural (adj). He became so powerful… the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself." - Sheev Palpatine or Darth Sidious.