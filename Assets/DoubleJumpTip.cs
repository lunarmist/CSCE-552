using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpTip : MonoBehaviour
{
    [SerializeField] PopupWIndow popupWindow;
    private bool notified = false;


    public void OnCollisionEnter(Collision collision)
    {
        if (!notified && collision.gameObject.tag == "Player")
        {
            popupWindow.AddToQueue("Press 'Space' again to jump mid-air.");
            notified = true;
        }
    }
}
