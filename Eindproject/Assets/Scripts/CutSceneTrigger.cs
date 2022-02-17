using UnityEngine;

public class CutSceneTrigger : MonoBehaviour
{

    public GameObject animatieCamera;

    public ParticleSystem particlesysteem;

    public GameObject Player;

    public GameObject schuifdeur;

    public void OnTriggerEnter(Collider other)
    {
        animatieCamera.SetActive(true);

        gameObject.SetActive(false);

        particlesysteem.Play();

        Player.SetActive(false);

        schuifdeur.SetActive(false);
    }
}
