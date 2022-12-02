using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class CardMovement : MonoBehaviour
{
    public bool isUp;
    public int id;
    GameManager gameManager;

    void Start()
    {        
        DOTween.Init(true, true, LogBehaviour.Verbose).SetCapacity(200, 10);
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        if (GameManager.CanClick)
        {
            if (!isUp)
            {
                CardUp();                
            }
        }
    }

    [ContextMenu("CardUp")]
    public void CardUp()
    {        
        transform.DOMove(new Vector3(transform.position.x, 30.44f, transform.position.z), 1);
        transform.DOLocalRotate(new Vector3(-180, 0, 0), 1);
        isUp = true;
        gameManager.GetObject(gameObject);
    }

    [ContextMenu("CardDown")]
    public void CardDown()
    {
        transform.DOMove(new Vector3(transform.position.x, 28.44f, transform.position.z), 1);
        transform.DOLocalRotate(new Vector3(-180, 180, 180), 1);
        isUp = false;
    }
}
