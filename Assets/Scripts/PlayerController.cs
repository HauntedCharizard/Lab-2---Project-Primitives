using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float speed = 8.0f;
    private Rigidbody playerRb;
    private float zBound = 18;
    private float xBound = 12;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);


        // Z Boundaries
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }

        // X boundaries
        if (transform.position.x < -xBound) {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > xBound) {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);

        }
    }
}
