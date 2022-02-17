using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 bewegen;

    public float snelheid = 10;

    public Rigidbody rb;

    void Update()
    {
        float x_as = Input.GetAxis("Horizontal");
        float z_as = Input.GetAxis("Vertical");

        bewegen.x = x_as;
        bewegen.z = z_as;

        rb.AddForce(transform.forward * bewegen.z * snelheid * Time.deltaTime);
        rb.AddForce(transform.right * bewegen.x * snelheid * Time.deltaTime);
    }
}
