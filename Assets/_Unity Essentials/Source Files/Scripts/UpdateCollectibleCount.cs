using UnityEngine;
using TMPro;
using System; // Required for Type handling

public class UpdateCollectibleCount : MonoBehaviour
{

    private TextMeshProUGUI collectibleText; // Reference to the TextMeshProUGUI component
    private int totalCollectibles2D;
    private int totalCollectibles3D;

    void Start()
    {
        
        collectibleText = GetComponent<TextMeshProUGUI>();
        if (collectibleText == null)
        {
            Debug.LogError("UpdateCollectibleCount script requires a TextMeshProUGUI component on the same GameObject.");
            return;
        }
        totalCollectibles2D = UnityEngine.Object.FindObjectsByType(Type.GetType("Collectible2D"), FindObjectsSortMode.None).Length;
        totalCollectibles3D = UnityEngine.Object.FindObjectsByType(Type.GetType("Collectible"), FindObjectsSortMode.None).Length;

        UpdateCollectibleDisplay(); 
    }

    void Update()
    {
        UpdateCollectibleDisplay();
    }

    private void UpdateCollectibleDisplay()
    {
        int remaining2D = FindObjectsByType<Collectible2D>(FindObjectsSortMode.None).Length;
        int remaining3D = FindObjectsByType<Collectible>(FindObjectsSortMode.None).Length;

        int totalRemaining = remaining2D + remaining3D;
        int total = totalCollectibles2D + totalCollectibles3D;

        collectibleText.text = $"Collectibles remaining: {totalRemaining}/{total}";

    }
}
