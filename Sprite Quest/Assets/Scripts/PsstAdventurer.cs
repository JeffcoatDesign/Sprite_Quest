using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PsstAdventurer : MonoBehaviour
{
    public void LoadFishing()
    {
        SceneManager.LoadScene("Fishing");
    }

    public void LoadGetJob()
    {
        SceneManager.LoadScene("GetJob");
    }
}
