using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] TextMeshProUGUI coinsText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coins++;
            Destroy(other.gameObject);
            coinsText.text = "Coins: " + coins + " / 1";

        }
    }
}
