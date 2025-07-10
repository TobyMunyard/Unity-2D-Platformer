using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentXPos;
    private Vector3 velocity = Vector3.zero;

    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentXPos, 
            transform.position.y, -10), ref velocity, speed);    
    }

    public void MoveToNewRoom(Transform newRoom)
    {
        currentXPos = newRoom.position.x;
    }
}
