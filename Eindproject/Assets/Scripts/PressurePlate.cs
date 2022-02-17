using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject plaat;

    public void OnTriggerEnter(Collider other)
    {
        plaat.SetActive(true);

        gameObject.SetActive(false);
    }
}
