using UnityEngine;
using UnityEngine.InputSystem;

public class LightSensorController : MonoBehaviour
{
    void Update()
    {
        InputSystem.DisableDevice(LightSensor.current);
        InputSystem.EnableDevice(LightSensor.current);

        if (LightSensor.current.enabled)
        {
            var CurrentLight = LightSensor.current.lightLevel.ReadValue(); // <= change here
            DisplayLight = (float)CurrentLight;
        }

        Light.value = (float)DisplayLight;
    }
}
