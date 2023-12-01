using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMaze : MonoBehaviour
{
    [SerializeField] PopupWIndow popupWindow;
    private bool notified = false;


    public void OnCollisionEnter(Collision collision)
    {
        if (!notified && collision.gameObject.tag == "Player")
        {
            
            popupWindow.AddToQueue("Jumping is disabled in mazes...");
            notified = true;
        }
    }
}
