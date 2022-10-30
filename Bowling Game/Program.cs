// See https://aka.ms/new-console-template for more information
using Bowling_Game;

Console.WriteLine("Hello, World!");

var game = new BowlingGame();

game.Roll(1);
game.Roll(2); // Frame 1
game.Roll(3);
game.Roll(4); // Frame 2
game.Roll(5);
game.Roll(5); // Frame 3
game.Roll(6);
game.Roll(4); // Frame 4
game.Roll(7);
game.Roll(3); // Frame 5
game.Roll(8);
game.Roll(2); // Frame 6
game.Roll(9);
game.Roll(1); // Frame 7
game.Roll(10);
game.Roll(0); // Frame 8
game.Roll(10);
game.Roll(0); // Frame 9
game.Roll(10);
game.Roll(0); // Frame 10
Console.WriteLine(game.Score());

game = new BowlingGame();
game.Roll(10);
game.Roll(0); // Frame 1
game.Roll(10);
game.Roll(0); // Frame 2
game.Roll(10);
game.Roll(0); // Frame 3
game.Roll(10);
game.Roll(0); // Frame 4
game.Roll(10);
game.Roll(0); // Frame 5
game.Roll(10);
game.Roll(0); // Frame 6
game.Roll(10);
game.Roll(0); // Frame 7
game.Roll(10);
game.Roll(0); // Frame 8
game.Roll(10);
game.Roll(0); // Frame 9
game.Roll(10);
game.Roll(0); // Frame 10
game.Roll(10);
Console.WriteLine(game.Score());
