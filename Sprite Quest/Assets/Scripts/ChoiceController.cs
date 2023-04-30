using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class ChoiceController : MonoBehaviour
{

    [SerializeField] private int numChoices = 4;

    [SerializeField] private string choice1scene;
    [SerializeField] private string choice2scene;
    [SerializeField] private string choice3scene;
    [SerializeField] private string choice4scene;

    [SerializeField] private Button choice1btn;
    [SerializeField] private Button choice2btn;
    [SerializeField] private Button choice3btn;
    [SerializeField] private Button choice4btn;

    public UnityEvent Choice1Event;
    public UnityEvent Choice2Event;
    public UnityEvent Choice3Event;
    public UnityEvent Choice4Event;

    private void Start()
    {
        if (Choice1Event == null)
            Choice1Event = new();
        if (Choice2Event == null)
            Choice2Event = new();
        if (Choice3Event == null)
            Choice3Event = new();
        if (Choice4Event == null)
            Choice4Event = new();

        if (numChoices < 4)
            choice4btn.gameObject.SetActive(false);
        if (numChoices < 3)
            choice3btn.gameObject.SetActive(false);
        if (numChoices < 2)
            choice2btn.gameObject.SetActive(false);
    }

    public void OnChoice1 ()
    {
        Choice1Event.Invoke();
    }
    public void OnChoice2()
    {
        Choice2Event.Invoke();
    }
    public void OnChoice3()
    {
        Choice3Event.Invoke();
    }
    public void OnChoice4()
    {
        Choice4Event.Invoke();
    }
}
