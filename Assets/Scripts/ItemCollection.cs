using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] MaxCoins maxCoins;
    [SerializeField] TextMeshProUGUI coinsText;
    private void Start()
    {
        coinsText.text = "Coins: " + coins + " / " + maxCoins.getMaxCoins();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coins++;
            Destroy(other.gameObject);
            coinsText.text = "Coins: " + coins + " / " + maxCoins.getMaxCoins();

        }
    }

    public int GetCoins()
    {
        return coins;
    }
}
