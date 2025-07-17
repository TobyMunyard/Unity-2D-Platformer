using TMPro;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float leftStopCoordinate;
    public float rightStopCoordinate;
    public float speed = 2f;

    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = new Vector3(rightStopCoordinate, transform.position.y, transform.position.z);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            targetPosition.x = targetPosition.x == leftStopCoordinate ? rightStopCoordinate : leftStopCoordinate;
        }
    }
}
