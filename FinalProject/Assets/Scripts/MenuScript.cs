using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject HowToPlay;
    public void playGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void howToPlay()
    {

        HowToPlay.SetActive(true);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void backButtonHandler()
    {
        HowToPlay.SetActive(false);
    }
}
