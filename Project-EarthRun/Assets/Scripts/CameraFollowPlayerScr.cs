using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayerScr : MonoBehaviour
{
    public float cameraDistOffsetX = 0;
    public float cameraDistOffsetY = 0;
    public float cameraDistOffsetZ = 0;
     private Camera mainCamera;
     private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        player = GameObject.Find("TrashbinGreen");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 playerInfo = player.transform.transform.position;
         mainCamera.transform.position = new Vector3(playerInfo.x - cameraDistOffsetX, playerInfo.y - cameraDistOffsetY, playerInfo.z - cameraDistOffsetZ);
    }
}
