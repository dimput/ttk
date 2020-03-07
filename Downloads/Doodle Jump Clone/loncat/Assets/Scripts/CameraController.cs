using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance;
    public float batasBawah=-1f;
    public GameObject player;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        offset = transform.position.y - player.transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x,player.transform.position.y+offset,transform.position.z);
    }

    // public void setLocationCamera()
    // {
    //     transform.position = new Vector3(1.71f,bawahAwal,-30);
    // }
}
