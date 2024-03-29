int numOfDice = 100;
int diceFaces = 20;
float averageRoll =0;
float averageRollTotal =0;
int totalRolls = 0;
int rerolls = 0;
CheckSum();
void CheckSum()
{
    Reroll:
    RollDice(numOfDice, diceFaces);
    if ((int)averageRollTotal == 1050)
    {
        Console.WriteLine("Found Expected 1050 Average after "+rerolls+" rerolls!!!");

    }
    else 
    {
        Console.WriteLine("Missed...Found " + (int)averageRollTotal + " Rerolling " + rerolls+ "time");
        averageRoll= 0;
        averageRollTotal = 0;
        rerolls += 1;
        goto Reroll;
    }
}

void RollDice(int _totalDice, int _diceFaces)
{
    for (int i = 0; i < _totalDice; i++)
    {
        Random rand = new Random();
        int randFace = rand.Next(1, _diceFaces + 1);
        Console.WriteLine("Rolled " + randFace);
        CalculateDice(randFace);
    }
    Console.WriteLine("Average Roll Total=" + averageRollTotal);
    Console.WriteLine("Average Roll=" + averageRoll);
    Console.WriteLine("Average Roll Total=" + averageRollTotal);

}

void CalculateDice(int faceValue)
{
    totalRolls += 1;    
    float _rollingAverage = (averageRoll + faceValue)/2;    
    averageRoll = _rollingAverage;
    averageRollTotal = (averageRollTotal + averageRoll);
}
