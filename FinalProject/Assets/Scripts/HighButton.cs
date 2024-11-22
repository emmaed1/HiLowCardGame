using UnityEngine;

public class HighButton : MonoBehaviour
{
    public GameObject[] dealtCard;
    public int cardGenerate;
    //public GameObject highBtn;
    //public GameObject lowBtn;
    //public GameObject dealBtn;

    public void dealHighCard()
    {
        cardGenerate = Random.Range(2, 15);
        dealtCard[cardGenerate].SetActive(true);

        CardController.newCardNumber = cardGenerate;
        CardController.guessHi = true;
    }

}
