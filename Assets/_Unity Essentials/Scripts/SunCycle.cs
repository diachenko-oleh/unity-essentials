using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class SunCycle : MonoBehaviour
{
    public float sunspeed = 1.0f;
    public float dayLength = 24.0f;
    private float cycleTime;
    public float sunStartAngle = 90.0f;
    public Light directionalLight;
    public Gradient lightColor;
    public AnimationCurve lightIntensity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate time progression from 0 to 1
        cycleTime += (Time.deltaTime / dayLength) * sunspeed;
        cycleTime %= 1f;

        // Rotate the light to simulate the sun movement
        float sunAngle = cycleTime * 360f - sunStartAngle;
        directionalLight.transform.rotation = Quaternion.Euler(sunAngle, 0, 0);

        // Adjust light color and intensity
        directionalLight.color = lightColor.Evaluate(cycleTime);
        directionalLight.intensity = lightIntensity.Evaluate(cycleTime);
    }
}
