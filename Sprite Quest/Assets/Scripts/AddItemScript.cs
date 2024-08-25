using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemScript : MonoBehaviour
{
    [SerializeField] private float timeToAppear = 0.0f;
    [SerializeField] private float timeToDisappear = 1.5f;
    [SerializeField] GameObject targetObject;
    void Start()
    {
        targetObject.SetActive(false);
        StartCoroutine(AppearReappear());
    }

    private IEnumerator AppearReappear ()
    {
        yield return new WaitForSeconds(timeToAppear);
        targetObject.SetActive(true);

        yield return new WaitForSeconds(timeToDisappear);
        targetObject.SetActive(false);

        yield return null;
    }
}
