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

    void Update()
    {
        cycleTime += (Time.deltaTime / dayLength) * sunspeed;
        cycleTime %= 1f;

        float sunAngle = cycleTime * 360f - sunStartAngle;
        directionalLight.transform.rotation = Quaternion.Euler(sunAngle, 0, 0);

        directionalLight.color = lightColor.Evaluate(cycleTime);
        directionalLight.intensity = lightIntensity.Evaluate(cycleTime);
    }
}
