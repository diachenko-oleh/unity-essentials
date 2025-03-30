using UnityEngine;
using UnityEngine.Audio;

public class Collectible : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioClip collectSound;
    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other) // action on the collectible
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }
        
    }
}
