using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCards : MonoBehaviour
{
    [SerializeField] List<GameObject> cards;
    [SerializeField] List<GameObject> slots;

    public int[] values;

    private void Awake()
    {
        StartCoroutine (DelaySpawncards());
    }

    [ContextMenu("Spawn Cards")]
    public void Spawn()
    {
        int randomPositionPar;
        ChooseCards();
        int card=0;
        for (int i = 0; i < 10; i++)
        {
            if(slots[i].transform.childCount == 0)
            {                
                Instantiate(cards[values[card]],slots[i].transform.position, slots[i].transform.rotation, slots[i].transform);

                randomPositionPar = Random.Range(0, 10);
                while (slots[randomPositionPar].transform.childCount != 0)
                {
                    randomPositionPar = Random.Range(0, 10);
                }
                Instantiate(cards[values[card]], slots[randomPositionPar].transform.position, slots[randomPositionPar].transform.rotation, slots[randomPositionPar].transform);
                card++;
            }
            
        }
    }

    public void ChooseCards()
    {
        int randomNumber;
        for(int i = 0; i < 5; i++)
        {            
            randomNumber = Random.Range(0, 10);
            values[i] = randomNumber;
            for(int j = 0; j < 5; j++)
            {                
                if (j != i)
                {
                    if (values[j] == values[i])
                    {
                        i--;
                        if (i <= 0)
                        {
                            i = 0;
                        }
                    }
                }
            }
        }
    }

    private IEnumerator DelaySpawncards()
    {
        yield return new WaitForSeconds(1);
        Spawn();

    }
}
