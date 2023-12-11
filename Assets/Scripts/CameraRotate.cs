using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraRotate : MonoBehaviour
{

    [SerializeField] Transform player;
    public float smoothSpeed = 0.250f;
    public Vector3 locationOffset;
    public Vector3 rotationOffset;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindWithTag("Player").transform;
        Debug.Log("Say some sht");
        Debug.Log("Say some sht2");
        Debug.Log("Seomthing2: "+ player.transform.rotation.x);
        //Screen.SetResolution(1081, 720, false);
        Debug.Log("Say some sht3");
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("Say some sht4");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + player.rotation * locationOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        Quaternion desiredrotation = player.rotation * Quaternion.Euler(rotationOffset);
        Quaternion smoothedrotation = Quaternion.Lerp(transform.rotation, desiredrotation, smoothSpeed);
        transform.rotation = smoothedrotation;
        //transform.position = player.transform.position + new Vector3(0,1,-5);
        //transform.LookAt(player.transform);

        //transform.position =
    }
}
