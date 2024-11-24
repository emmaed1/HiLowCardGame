using System.Collections;
using UnityEngine;

public class DealCard : MonoBehaviour
{
    public GameObject[] dealtCard;
    public int cardGenerate;
    public GameObject highBtn;
    public GameObject lowBtn;
    public GameObject dealBtn;

    public AudioSource dealCard;

    private bool facedUp;

    private void Start()
    {
        facedUp = false;
    }

    public void dealNewCard()
    {
        dealCard.Play();
        cardGenerate = Random.Range(2, 15);
        dealtCard[cardGenerate].SetActive(true);
        highBtn.SetActive(true);
        lowBtn.SetActive(true);
        dealBtn.SetActive(false);

        CardController.dealtCardNumber = cardGenerate;
    }
}
