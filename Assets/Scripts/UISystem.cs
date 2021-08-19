using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

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

    public void OpenLinkJSPlugin(string link)
    {
#if !UNITY_EDITOR
		openWindow("link");
#endif
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);

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

    public void ItchioWebsite()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            openWindow("https://dryrel.itch.io");
        }
        else
        {
            Application.OpenURL("https://dryrel.itch.io");
        }
    }

    public void DryreLWebsite()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            openWindow("https://gokdenizcetin.com");
        }
        else
        {
            Application.OpenURL("https://gokdenizcetin.com");
        }
    }

    public void QuitGame()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Debug.Log("You cannot quit on browser");
        }
        else
        {
            Application.Quit();
        }
    }
}
