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
        SceneManager.LoadScene("Game");
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
        GameManager.CanClick = false;
    }
    public void OnCloseButton()
    {
        volumeSystem.gameObject.SetActive(false);
        GameManager.CanClick = true;
    }
    public void OnRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
