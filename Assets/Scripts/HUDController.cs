using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    public GameObject volumeSystem;

    private void Start()
    {
        volumeSystem.gameObject.SetActive(false);
    }

    public void OnPlayButton()
    {
        SceneManager.LoadScene("2");
    }
    public void OnCreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }
    public void OnMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void OnSoundButton()
    {
        volumeSystem.gameObject.SetActive(true);
    }
    public void OnCloseButton()
    {
        volumeSystem.gameObject.SetActive(false);
    }

}
