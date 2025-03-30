using UnityEngine;

public class BouncingBallSound : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
}
