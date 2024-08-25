using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Fishing : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI outputText;
    [SerializeField] private float textSpeed = 0.5f;
    [SerializeField] private string[] fishingOptions;
    private AudioSource audioSource;
    [SerializeField] private AudioSource reelSource;
    private bool isWriting = false;

    private void Awake()
    {
        audioSource = transform.GetComponent<AudioSource>();
    }

    private void Start()
    {
        StartCoroutine(writeFishing("You cast your line and start your fishing journey.", 0));
    }

    public void KeepFishing()
    {
        if (isWriting)
            return;
        reelSource.Play();
        int choiceNum = Random.Range(0, fishingOptions.Length);
        string choice = fishingOptions[choiceNum];
        StartCoroutine(writeFishing(choice, choiceNum));
    }

    public void LoadGetJob()
    {
        SceneManager.LoadScene("GetJob");
    }

    private IEnumerator writeFishing (string choice, int num)
    {
        isWriting = true;
        outputText.text = "";
        for (int i = 0; i < choice.Length; i++)
        {
            yield return new WaitForSeconds(textSpeed);
            outputText.text += choice[i];
        }
        if (num == 50)
        {
            audioSource.Play();
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Credits");
        }
        isWriting = false;
        yield return null;
    }
}
