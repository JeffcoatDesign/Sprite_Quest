using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Burglary : MonoBehaviour
{
    public void LoadStealSprite()
    {
        SceneManager.LoadScene("StealSprite");
    }

    public void LoadStealHelmet()
    {
        SceneManager.LoadScene("StealHelmet");
    }

    public void LoadStealBoth()
    {
        SceneManager.LoadScene("StealBoth");
    }

    public void LoadStealBoth1()
    {
        SceneManager.LoadScene("StealBothHelmet");
    }

    public void LoadStealDone()
    {
        SceneManager.LoadScene("Befriend");
    }
}
