using UnityEngine;
using UnityEngine.UI;

public class GameSettingsButtons : MonoBehaviour
{
    public GameObject inGameSettingsMenu;
    public Slider volumeSlider;
    public AudioSource musicRef;

    public void backButtonHandler()
    {
        inGameSettingsMenu.SetActive(false);
    }

    public void settingsButtonhandler()
    {
        inGameSettingsMenu.SetActive(true);
    }

    public void volumeSliderHandler()
    {
        musicRef.volume = volumeSlider.value;
    }
}