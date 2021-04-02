using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContro : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
   
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        this.transform.rotation = Quaternion.Euler(50,90, 0);
    }
}
