using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetJob : MonoBehaviour
{
    public void LoadScoutThings()
    {
        SceneManager.LoadScene("ScoutThings");
    }

    public void RefuseJob()
    {
        SceneManager.LoadScene("RefuseJob");
    }
}
