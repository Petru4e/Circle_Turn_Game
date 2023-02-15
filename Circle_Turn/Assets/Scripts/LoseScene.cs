
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseScene : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    private void Update()
    {
        ScoreText.text = score.ToString();
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
