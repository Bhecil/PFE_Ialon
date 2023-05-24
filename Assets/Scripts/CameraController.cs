using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float movementSpeed;

    private Vector3 newPosition;

    void Start()
    {
        newPosition = transform.position;
    }

    void Update()
    {
        HandleMovementInput();
    }

    private void FixedUpdate()
    {
        transform.position = newPosition;
    }

    void HandleMovementInput()
    {
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
        {
            newPosition += (transform.forward * movementSpeed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            newPosition += (transform.forward * -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            newPosition += (transform.right * movementSpeed);
        }
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition += (transform.right * -movementSpeed);
        }
    }
}
