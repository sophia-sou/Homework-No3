using UnityEngine;

public class FollowPlayerPosition : MonoBehaviour
{
    public Transform player; 
    public Vector3 cameraOffset; 

    void Update()
    {
        transform.position = player.position + cameraOffset; 
    }
}
