using UnityEngine;
using System;
using UnityEngine.UI;

public class VFXEffectStart : MonoBehaviour
{
    public ParticleSystem correctEffect; // Reference to the GameObject to activate
    public AudioSource correctSound; // Reference to the Audio Source
    private bool allCollected = false;
    void Start()
    {
        UpdateCollectibleDisplay();
    }

    void Update()
    {
        UpdateCollectibleDisplay();
    }
    private void UpdateCollectibleDisplay()
    {
        int remainCollectibles = 0;
        Type collectibleType = Type.GetType("Collectible");
        if (collectibleType != null)
        {
            remainCollectibles += UnityEngine.Object.FindObjectsByType(collectibleType, FindObjectsSortMode.None).Length;
        }
        if (remainCollectibles == 0 && !allCollected)
        {
            correctEffect.Play();
            correctSound.Play();
            allCollected = true;
        }
    }
        
}
