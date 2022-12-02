using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public List<CardMovement> cards;
    public static bool CanClick;
    public int score;
    public GameObject winScreen;

    AudioSource audiosource;
    public AudioClip fireSound;
    public AudioClip winSound;


    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
        CanClick = true;
        winScreen.SetActive(false);
    }
    public void GetObject(GameObject card)
    {
        cards.Add(card.GetComponent<CardMovement>());
        ValidateCards();
    }
    public void ValidateCards()
    {
        if(cards.Count == 2)
        {
            CanClick = false;
            if (cards[0].id == cards[1].id)
            {
                cards[0].GetComponent<CardHealt>().DisolveCard();
                audiosource.PlayOneShot(fireSound, 1);
                cards[1].GetComponent<CardHealt>().DisolveCard();
                audiosource.PlayOneShot(fireSound, 1);
                cards.Clear();
                score++;
                if(score == 5)
                {
                    StartCoroutine(WinScreen());
                }
            }
            else
            {
                StartCoroutine(ConstraintsCards());
            }            
        }
    }
    IEnumerator ConstraintsCards()
    {
        yield return new WaitForSeconds(2);
        cards[0].CardDown();
        cards[1].CardDown();        
        cards.Clear();
        CanClick = true;
    }
    IEnumerator WinScreen()
    {
        audiosource.PlayOneShot(winSound, 1);
        yield return new WaitForSeconds(3);
        winScreen.SetActive(true);
    }
}
