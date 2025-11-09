using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Play1()
    {
        SceneManager.LoadScene("Level1");
        SnakeManager.healthPoint = 3;
        SnakeManager.direction = Vector2.right;
        ScoringSystem.score = 0;
    }
    
    public void Play2()
    {
        SceneManager.LoadScene("Level2");
        SnakeManager.healthPoint = 3;
        SnakeManager.direction = Vector2.left;
        ScoringSystem.score = 0;
    }

    public void Defeat()
    {
        SceneManager.LoadScene("Defeat");
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}