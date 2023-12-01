using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupWIndow : MonoBehaviour
{
    public TMP_Text popupText;

    private GameObject window;
    private Animator popupAnimator;

    //make it different type for more detailed popups, you can add different types, titles, descriptions etc
    private Queue<string> popupQueue;
    private bool isActive;
    private Coroutine queueChecker;

    private void Start()
    {
        window = transform.GetChild(0).gameObject;
        popupAnimator = window.GetComponent<Animator>();
        window.SetActive(false);
        popupQueue = new Queue<string>();
    }
    public void AddToQueue(string text)
    {
        popupQueue.Enqueue(text);
        if (queueChecker == null)
            queueChecker = StartCoroutine(CheckQueue());
    }

    //parameter the same type as queue
    private void ShowPopup(string text)
    {
        isActive = true;
        window.SetActive(true);
        popupText.text = text;
        popupAnimator.Play("PopupAnimation");
    }
    
    private IEnumerator CheckQueue()
    {
        do
        {
            ShowPopup(popupQueue.Dequeue());
            do
            {
                yield return null;
            } while (!popupAnimator.GetCurrentAnimatorStateInfo(0).IsTag("Idle"));
        }
        while (popupQueue.Count > 0);
        isActive = false;
        window.SetActive(false);
        queueChecker = null;
    }
}
