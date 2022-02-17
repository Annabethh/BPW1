using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public Vector3 bewegen;

    public float snelheid = 10;

    public float hoogte = 200;

    public Rigidbody rb;

    void FixedUpdate()
    {
        float x_as = Input.GetAxis("Horizontal");
        float z_as = Input.GetAxis("Vertical");

        bewegen.x = x_as;
        bewegen.z = z_as;

        transform.Translate(bewegen * snelheid * Time.deltaTime, Space.Self);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(0, hoogte, 0, ForceMode.VelocityChange);

        }
    }
}
