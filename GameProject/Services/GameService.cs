using GameProject.Models;
using System.Collections.Generic;

public int CalculateVictoryBonus(Player player)
{
    return player.Health + (player.HealingPotions * 10);
}

public List<GameResult> GetTopScores(int numberOfScores)
{
    List<GameResult> scores = _repository.GetAll();
    List<GameResult> sortedScores = new List<GameResult>();

    for (int i = 0; i < scores.Count; i++)
    {
        sortedScores.Add(scores[i]);
    }

    for (int i = 0; i < sortedScores.Count; i++)
    {
        for (int j = i + 1; j < sortedScores.Count; j++)
        {
            if (sortedScores[j].Score > sortedScores[i].Score ||
                (sortedScores[j].Score == sortedScores[i].Score &&
                string.Compare(sortedScores[j].PlayerName,
                sortedScores[i].PlayerName, true) < 0))
            {
                GameResult temp = sortedScores[i];
                sortedScores[i] = sortedScores[j];
                sortedScores[j] = temp;
            }
        }
    }

    List<GameResult> topScores = new List<GameResult>();

    for (int i = 0; i < sortedScores.Count && i < numberOfScores; i++)
    {
        topScores.Add(sortedScores[i]);
    }

    return topScores;
}