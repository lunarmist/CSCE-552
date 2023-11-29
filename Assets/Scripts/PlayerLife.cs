using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private bool isDead = false;

    private void Update()
    {
        if (transform.position.y < -1.5f && !isDead)
        {
            Die();
        }
    }
    void Die()
    {
        isDead = !isDead;
        // disappear player from scene
        //GetComponent<MeshRenderer>().enabled = false;
        // remove physics from player
        //GetComponent<Rigidbody>().isKinematic = true;
        // remove movement from player
        //GetComponent<PlayerMovement>().enabled = false;
        //Debug.Log("player died")

        // allow a delay on reloading the level upon death
        Invoke(nameof(ReloadLevel), 1.5f);
        
    }

    void ReloadLevel()
    {
        isDead = !isDead;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
