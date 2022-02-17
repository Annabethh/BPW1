using UnityEngine;

public class Camaracontroller : MonoBehaviour
{
    public MeshRenderer Player;

    public float snelheid = 0.5f;

    public Vector2 roteren;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        float x_as = Input.GetAxis("Mouse X");
        float y_as = Input.GetAxis("Mouse Y");

        roteren.x = x_as;
        roteren.y = y_as; 

        transform.Rotate(-(roteren.y * snelheid), 0, 0);
        Player.transform.Rotate(0, roteren.x * snelheid, 0);

    }
}
