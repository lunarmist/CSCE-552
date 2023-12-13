using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaxCoins : MonoBehaviour
{
    private int Max_Coins;

    public int getMaxCoins()
    {
        if (SceneManager.GetActiveScene().name == "TutorialLevel")
        {
            Max_Coins = 1;
        }

        if (SceneManager.GetActiveScene().name == "Level_1")
        {
            Max_Coins = 4;
            
        }

        if (SceneManager.GetActiveScene().name == "Level_2")
        {
            Max_Coins = 2;

        }
        return Max_Coins;
    }
}
