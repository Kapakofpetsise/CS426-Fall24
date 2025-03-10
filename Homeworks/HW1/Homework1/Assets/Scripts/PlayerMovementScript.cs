using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public Rigidbody rb;

    public float movementForce = 10f;

    void Start()
    {
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * movementForce * Time.deltaTime, ForceMode.Impulse);
    }
}