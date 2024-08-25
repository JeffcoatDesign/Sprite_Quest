using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSceneFList : MonoBehaviour
{
    [SerializeField] private string scene1Name;
    [SerializeField] private string scene2Name;
    [SerializeField] private string scene3Name;
    [SerializeField] private string scene4Name;

    public void LoadScene1()
    {
        SceneManager.LoadScene(scene1Name);
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene(scene2Name);
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene(scene3Name);
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene(scene4Name);
    }
}
