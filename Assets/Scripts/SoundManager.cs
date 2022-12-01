using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider controlVolume;    

    public GameObject[] audios;         
    private void Start()
    {
        audios = GameObject.FindGameObjectsWithTag("Audio");
        controlVolume.value = PlayerPrefs.GetFloat("volumenSave", 1f); 
    }
    private void Update()
    {
        foreach (GameObject au in audios)
            au.GetComponent<AudioSource>().volume = controlVolume.value; 
    }
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("volumenSave", controlVolume.value); 
    }
}
