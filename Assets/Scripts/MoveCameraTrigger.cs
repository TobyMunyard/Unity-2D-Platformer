using UnityEngine;

public class MoveCameraTrigger : MonoBehaviour
{
    public Transform oldRoom;
    public Transform newRoom;
    [SerializeField] private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.transform.position.x < transform.position.x)
            {
                cam.MoveToNewRoom(newRoom);
            }
            else
            {
                cam.MoveToNewRoom(oldRoom);
            }
        }
    }
}
