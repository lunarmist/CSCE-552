using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] ItemCollection itemCollection;
    [SerializeField] MaxCoins maxCoins;
    [SerializeField] PopupWIndow popupWIndow;
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("This is the Goal Script accessing item collector: " + itemCollection.GetCoins());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && itemCollection.GetCoins() == maxCoins.getMaxCoins())
        {
            Debug.Log("Player Collision");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
        else if (itemCollection.GetCoins() < maxCoins.getMaxCoins())
        {
            Debug.Log("Player Collision");
            if ((maxCoins.getMaxCoins() - itemCollection.GetCoins()) < 2)
                popupWIndow.AddToQueue("You have not found " + (maxCoins.getMaxCoins() - itemCollection.GetCoins() + " coin"));
            else
                popupWIndow.AddToQueue("You have not found " + (maxCoins.getMaxCoins() - itemCollection.GetCoins() + " coins"));
        }
    }
}
