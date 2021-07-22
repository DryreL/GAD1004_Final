using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISystem : MonoBehaviour
{

    public GameObject creditsObject;
    public GameObject[] mainmenuObjects;

    // Start is called before the first frame update
    void Start()
    {
        mainmenuObjects[0].SetActive(true);
        mainmenuObjects[1].SetActive(true);
        mainmenuObjects[2].SetActive(true);
        creditsObject.SetActive(false);
    }

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Credits()
    {
        mainmenuObjects[0].SetActive(false);
        mainmenuObjects[1].SetActive(false);
        mainmenuObjects[2].SetActive(false);

        creditsObject.SetActive(true);
    }

    public void BackToMainMenu()
    {
        mainmenuObjects[0].SetActive(true);
        mainmenuObjects[1].SetActive(true);
        mainmenuObjects[2].SetActive(true);

        creditsObject.SetActive(false);
    }

    public void Itchio()
    {
        Application.OpenURL("https://itch.io/profile/dryrel");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
