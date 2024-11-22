using UnityEngine;

public class LowButton : MonoBehaviour
{
    public GameObject[] dealtCard;
    public int cardGenerate;
    //public GameObject highBtn;
    //public GameObject lowBtn;
    //public GameObject dealBtn;

    public void dealLowCard()
    {
        cardGenerate = Random.Range(2, 15);
        dealtCard[cardGenerate].SetActive(true);

        CardController.newCardNumber = cardGenerate;
        CardController.guessLow = true;
    }

}
