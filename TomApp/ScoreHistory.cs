using System;
using System.Collections.Generic;
using System.Linq;

namespace TomApp
{
    public static class ScoreHistory
    {
        private static List<Score> _scores = new List<Score>();

        public static void AddScore(Score score)
        {
            _scores.Add(score);
        }

        public static IEnumerable<Score> GetScores(GameMode gameMode)
        {
            return _scores.Where(score => score.GameMode == gameMode).OrderByDescending(score => score.CorrectGuessCount);
        }
    }

    public class Score
    {
        public string UserName { get; set; }
        public GameMode GameMode { get; set; }
        public int CorrectGuessCount { get; set; }
    }
}