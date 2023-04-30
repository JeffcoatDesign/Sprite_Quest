using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fishing : MonoBehaviour
{
    public void KeepFishing()
    {
        Debug.Log("You keep fishing.");
    }

    public void LoadGetJob()
    {
        SceneManager.LoadScene("GetJob");
    }
}
