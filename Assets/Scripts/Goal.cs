using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] ItemCollection itemCollection;
    [SerializeField] MaxCoins maxCoins;
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("This is the Goal Script accessing item collector: " + itemCollection.GetCoins());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && itemCollection.GetCoins() == maxCoins.getMaxCoins())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
