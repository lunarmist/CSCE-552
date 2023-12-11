using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickyplatform : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        var camera = transform.Find("Player/MainCamera");
       if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
            collision.transform.localScale = new Vector3(0.3f, 0.3f, 0.6f);
            camera.transform.localScale = new Vector3(1.0f, 1.866855f, 0.5356603f);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
