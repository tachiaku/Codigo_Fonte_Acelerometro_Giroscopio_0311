using UnityEngine;

public class InputGyroExample : MonoBehaviour
{
    Gyroscope m_Gyro;

    private void Start()
    {
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.label);
        style.fontSize = 60;

        GUI.Label(new Rect(Screen.width * 0.1f, Screen.height * 0.1f, Screen.width * 0.8f, Screen.height * 0.8f), "Gyro rotation rate: " + m_Gyro.rotationRate, style);
        
        //GUI.Label(new Rect(450, 700, 500, 40), "Gyro attitude: " + m_Gyro.attitude);
        //GUI.Label(new Rect(450, 900, 500, 40), "Gyro enabled: " + m_Gyro.enabled);
    }
}
