using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CardMovement : MonoBehaviour
{
    public bool isUp;
    public int id;
    void Start()
    {        
        DOTween.Init(true, true, LogBehaviour.Verbose).SetCapacity(200, 10);
    }

    private void OnMouseDown()
    {        
        if (isUp)
        {
            CardDown();
        }
        else
        {
            CardUp();
        }
    }

    [ContextMenu("CardUp")]
    public void CardUp()
    {        
        transform.DOMove(new Vector3(transform.position.x, 30.44f, transform.position.z), 1);
        transform.DOLocalRotate(new Vector3(-180, 90, 0), 1);
        isUp = true;
    }

    [ContextMenu("CardDown")]
    public void CardDown()
    {
        transform.DOMove(new Vector3(transform.position.x, 28.44f, transform.position.z), 1);
        transform.DOLocalRotate(new Vector3(-180, 90, 180), 1);
        isUp = false;
    }
}
