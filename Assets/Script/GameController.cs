using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    private static int score = 0;
    private static int highScore = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        // score = 0;
        // highScore = 0;
        // SaveHighScore();
        LoadHighScore();
    }

    public static void SetScore(int newScore) { 
        score += newScore;
        if (score > highScore) {
            highScore = score;
        }
    }

    public static void ResetScore() {
        score = 0;
    }

    public static int GetScore() { 
        return score;
    }

    public static int GetHighScore() { 
        return highScore;
    }

    public static void SaveHighScore() {
        if (score == highScore) { 
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    public static void LoadHighScore() { 
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void StartGame() {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame() { 
        Application.Quit();
    }
}
