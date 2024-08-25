using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioLater : MonoBehaviour
{
    [SerializeField] private float delay;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = transform.GetComponent<AudioSource>();
        StartCoroutine(PlayAudio());
    }

    private IEnumerator PlayAudio ()
    {
        yield return new WaitForSeconds(delay);
        audioSource.Play();
        yield return null;
    }
}
