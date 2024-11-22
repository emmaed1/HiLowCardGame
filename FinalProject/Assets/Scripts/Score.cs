using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int currentScore;
    public GameObject scoreText;
    public int highScore;
    public GameObject bestText;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("BestScoreHilow");
        bestText.GetComponent<TextMeshProUGUI>().text = "BEST: " + highScore;
    }

    private void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "STREAK: " + currentScore;
        if(currentScore > highScore)
        {
            bestText.GetComponent<TextMeshProUGUI>().text = "BEST: " + currentScore;
            PlayerPrefs.SetInt("BestScoreHilow", currentScore);
        }
    }
}
