using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnMenu;
    [SerializeField] private Button btnExitt;
    [SerializeField] private GameObject pauseMenu;

    private bool pause = false;
    // Start is called before the first frame update
    void Start()
    {
        btnContinue.onClick.AddListener(Continue);
        btnMenu.onClick.AddListener(Menu);
        btnExitt.onClick.AddListener(Exit);
        Continue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Continue()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        pause = false;
    }

    private void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        pause = true;
    }

    private void Exit()
    {
#if UNITY_EDITOR
        if(EditorApplication.isPlaying) 
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
#else
            Application.Quit();
#endif
    }
}

