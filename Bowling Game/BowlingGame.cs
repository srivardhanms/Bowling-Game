namespace Bowling_Game
{
    public class BowlingGame : IBowlingGame
    {
        readonly int[] pins = new int[22];
        readonly int[] score = new int[22];
        private int currentBowl = 0;

        public BowlingGame()
        {

        }
        public void Roll(int noOfPins)
        {
            if ((noOfPins > 10)
                || (currentBowl != 21 && currentBowl % 2 == 1 && pins[currentBowl - 1] + noOfPins > 10))
                throw new InvalidPinsException("Exceeds maximum number of pins!");

            pins[currentBowl++] = noOfPins;
        }

        public int Score()
        {
            int finalScore = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    if (pins[i] == 10)
                    {
                        if (i == 18)
                            score[i] = pins[i] + pins[i + 2] + pins[i + 3];
                        else
                            score[i] = pins[i] + pins[i + 2] + ((pins[i + 2] == 10) ? pins[i + 4] : pins[i + 3]);
                    }   
                    else
                        score[i] = pins[i];
                }
                else
                {
                    if (pins[i - 1] != 10 && pins[i] + pins[i - 1] == 10)
                        score[i] = pins[i] + pins[i + 1];
                    else
                        score[i] = pins[i];
                }
            }

            foreach (int i in score)
            {
                finalScore += i;
                Console.Write(i + ", ");
            }

            return finalScore;
        }
    }
}
