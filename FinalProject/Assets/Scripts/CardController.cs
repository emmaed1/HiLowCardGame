using System.Collections;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public static int dealtCardNumber;
    public static int newCardNumber;

    public GameObject correctText;
    public GameObject incorrectText;
    public GameObject highBtn;
    public GameObject lowBtn;
    public GameObject dealBtn;

    public GameObject[] dealingLeftCards;
    public GameObject[] turningRightCards;

    public GameObject guessCardBack;
    public GameObject turnCardBack;

    public static bool guessHi = false;
    public static bool guessLow = false;

    public AudioSource cardDeal;
    public AudioSource correctCard;
    public AudioSource incorrectCard;

    private void Update()
    {
        if (guessHi == true) 
        {
            cardDeal.Play();
            guessHi = false;
            highBtn.SetActive(false);
            lowBtn.SetActive(false);
            StartCoroutine(GuessingHigher());
        }
        if (guessLow == true)
        {
            cardDeal.Play();
            guessLow = false;
            highBtn.SetActive(false);
            lowBtn.SetActive(false);
            StartCoroutine(GuessingLower());
        }
    }

    IEnumerator GuessingHigher()
    {
        yield return new WaitForSeconds(1);
        if(newCardNumber >= dealtCardNumber)
        {
            correctText.SetActive(true);
            correctCard.Play();
            Score.currentScore += 1;
            yield return new WaitForSeconds(1);
            dealingLeftCards[2].SetActive(false);
            dealingLeftCards[3].SetActive(false);
            dealingLeftCards[4].SetActive(false);
            dealingLeftCards[5].SetActive(false);
            dealingLeftCards[6].SetActive(false);
            dealingLeftCards[7].SetActive(false);
            dealingLeftCards[8].SetActive(false);
            dealingLeftCards[9].SetActive(false);
            dealingLeftCards[10].SetActive(false);
            dealingLeftCards[11].SetActive(false);
            dealingLeftCards[12].SetActive(false);
            dealingLeftCards[13].SetActive(false);
            dealingLeftCards[14].SetActive(false);
            turningRightCards[2].SetActive(false);
            turningRightCards[3].SetActive(false);
            turningRightCards[4].SetActive(false);
            turningRightCards[5].SetActive(false);
            turningRightCards[6].SetActive(false);
            turningRightCards[7].SetActive(false);
            turningRightCards[8].SetActive(false);
            turningRightCards[9].SetActive(false);
            turningRightCards[10].SetActive(false);
            turningRightCards[11].SetActive(false);
            turningRightCards[12].SetActive(false);
            turningRightCards[13].SetActive(false);
            turningRightCards[14].SetActive(false);
            turningRightCards[newCardNumber].SetActive(true);
            yield return new WaitForSeconds(1);
            highBtn.SetActive(true);
            lowBtn.SetActive(true);
            dealtCardNumber = newCardNumber;
            correctText.SetActive(false);
        }
        else
        {
            incorrectText.SetActive(true);
            incorrectCard.Play();
            Score.currentScore = 0;
            yield return new WaitForSeconds(1);
            dealingLeftCards[2].SetActive(false);
            dealingLeftCards[3].SetActive(false);
            dealingLeftCards[4].SetActive(false);
            dealingLeftCards[5].SetActive(false);
            dealingLeftCards[6].SetActive(false);
            dealingLeftCards[7].SetActive(false);
            dealingLeftCards[8].SetActive(false);
            dealingLeftCards[9].SetActive(false);
            dealingLeftCards[10].SetActive(false);
            dealingLeftCards[11].SetActive(false);
            dealingLeftCards[12].SetActive(false);
            dealingLeftCards[13].SetActive(false);
            dealingLeftCards[14].SetActive(false);

            turningRightCards[2].SetActive(false);
            turningRightCards[3].SetActive(false);
            turningRightCards[4].SetActive(false);
            turningRightCards[5].SetActive(false);
            turningRightCards[6].SetActive(false);
            turningRightCards[7].SetActive(false);
            turningRightCards[8].SetActive(false);
            turningRightCards[9].SetActive(false);
            turningRightCards[10].SetActive(false);
            turningRightCards[11].SetActive(false);
            turningRightCards[12].SetActive(false);
            turningRightCards[13].SetActive(false);
            turningRightCards[14].SetActive(false);
            yield return new WaitForSeconds(1);
            dealBtn.SetActive(true);
            incorrectText.SetActive(false);
        }
    }

    IEnumerator GuessingLower ()
    {
        yield return new WaitForSeconds(1);
        if (newCardNumber <= dealtCardNumber)
        {
            correctText.SetActive(true);
            correctCard.Play();
            Score.currentScore += 1;
            yield return new WaitForSeconds(1);
            dealingLeftCards[2].SetActive(false);
            dealingLeftCards[3].SetActive(false);
            dealingLeftCards[4].SetActive(false);
            dealingLeftCards[5].SetActive(false);
            dealingLeftCards[6].SetActive(false);
            dealingLeftCards[7].SetActive(false);
            dealingLeftCards[8].SetActive(false);
            dealingLeftCards[9].SetActive(false);
            dealingLeftCards[10].SetActive(false);
            dealingLeftCards[11].SetActive(false);
            dealingLeftCards[12].SetActive(false);
            dealingLeftCards[13].SetActive(false);
            dealingLeftCards[14].SetActive(false);

            turningRightCards[2].SetActive(false);
            turningRightCards[3].SetActive(false);
            turningRightCards[4].SetActive(false);
            turningRightCards[5].SetActive(false);
            turningRightCards[6].SetActive(false);
            turningRightCards[7].SetActive(false);
            turningRightCards[8].SetActive(false);
            turningRightCards[9].SetActive(false);
            turningRightCards[10].SetActive(false);
            turningRightCards[11].SetActive(false);
            turningRightCards[12].SetActive(false);
            turningRightCards[13].SetActive(false);
            turningRightCards[14].SetActive(false);
            turningRightCards[newCardNumber].SetActive(true);
            yield return new WaitForSeconds(1);
            highBtn.SetActive(true);
            lowBtn.SetActive(true);
            dealtCardNumber = newCardNumber;
            correctText.SetActive(false);
        }
        else
        {
            incorrectText.SetActive(true);
            incorrectCard.Play();
            Score.currentScore = 0;
            yield return new WaitForSeconds(1);
            dealingLeftCards[2].SetActive(false);
            dealingLeftCards[3].SetActive(false);
            dealingLeftCards[4].SetActive(false);
            dealingLeftCards[5].SetActive(false);
            dealingLeftCards[6].SetActive(false);
            dealingLeftCards[7].SetActive(false);
            dealingLeftCards[8].SetActive(false);
            dealingLeftCards[9].SetActive(false);
            dealingLeftCards[10].SetActive(false);
            dealingLeftCards[11].SetActive(false);
            dealingLeftCards[12].SetActive(false);
            dealingLeftCards[13].SetActive(false);
            dealingLeftCards[14].SetActive(false);

            turningRightCards[2].SetActive(false);
            turningRightCards[3].SetActive(false);
            turningRightCards[4].SetActive(false);
            turningRightCards[5].SetActive(false);
            turningRightCards[6].SetActive(false);
            turningRightCards[7].SetActive(false);
            turningRightCards[8].SetActive(false);
            turningRightCards[9].SetActive(false);
            turningRightCards[10].SetActive(false);
            turningRightCards[11].SetActive(false);
            turningRightCards[12].SetActive(false);
            turningRightCards[13].SetActive(false);
            turningRightCards[14].SetActive(false);
            yield return new WaitForSeconds(1);
            dealBtn.SetActive(true);
            incorrectText.SetActive(false);
        }
    }
}
