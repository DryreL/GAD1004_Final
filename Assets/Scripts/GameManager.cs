using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public  int PlayerScore1 = 0;
    public  int PlayerScore2 = 0;

    public GUISkin layout;

    GameObject theBall;

    public Text leftText, rightText;


    public static GameManager armut;


    public AudioClip[] sounds;
    AudioSource audioSource;

    public GameObject pauseMenu;
    public GameObject pauseMenuWebGL;
    bool pauseToggle = false;

    // Start is called before the first frame update
    void Awake()
    {
        armut = this;
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Quitting...");
            Application.Quit();
        }
        */

        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return))
        {
            if(pauseToggle)
            {
                if (Application.platform == RuntimePlatform.WebGLPlayer)
                {
                    pauseMenuWebGL.SetActive(true);
                }
                else
                {
                    pauseMenu.SetActive(true);
                }
            }
            else
            {
                pauseMenuWebGL.SetActive(false);
                pauseMenu.SetActive(false);

            }

            pauseToggle = !pauseToggle;
        }
    }


    public void PlayThis(int index)
    {
        Debug.Log("PlayThis");

        audioSource.PlayOneShot(sounds[index]);
    }

    public void GoToScene(string name)
    {

        SceneManager.LoadScene(name);
    }

    public void ResetGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {

        Application.Quit();
    }


    public void Score(string racketTag)
    {
        if (racketTag== "LeftWall")
        {

            PlayerScore2++;
            
        }
        else
        {
            PlayerScore1++;
        }


        leftText.text = PlayerScore1.ToString();
        rightText.text = PlayerScore2.ToString();

    }

}
