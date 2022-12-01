using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CardMovement : MonoBehaviour
{
    SoundManager soundManager;
    void Start()
    {
        soundManager = GetComponent<SoundManager>();
        DOTween.Init(true, true, LogBehaviour.Verbose).SetCapacity(200, 10);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CardUp();
        }
    }
    public void CardUp()
    {
        soundManager.audioSource.PlayOneShot(soundManager.swipeEffect, 0.5f);
        transform.DOMove(new Vector3(transform.position.x, 2, transform.position.z), 1);
        transform.DORotate(new Vector3(0, -180, -180), 1);
    }
    public void CardDown()
    {
        transform.DOMove(new Vector3(transform.position.x, 0, transform.position.z), 1);
        transform.DORotate(new Vector3(0, -180, 0), 1);
    }
}
