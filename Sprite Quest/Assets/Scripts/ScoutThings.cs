using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoutThings : MonoBehaviour
{
    public void LoadStealing()
    {
        SceneManager.LoadScene("Stealing");
    }

    public void LoadPickpocket()
    {
        SceneManager.LoadScene("Pickpocket");
    }

    public void LoadApplication()
    {
        SceneManager.LoadScene("Application");
    }

    public void LoadSnitch()
    {
        SceneManager.LoadScene("Snitch");
    }
}