using TMPro;
using UnityEngine;

public class ShowInformation : MonoBehaviour
{
    private TextMeshProUGUI information;
    void Start()
    {
        this.information = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        this.information.text = $"Sensor Size: {Camera.main.sensorSize.x}mm x {Camera.main.sensorSize.y}mm\nFocal Length: {Camera.main.focalLength}mm";
    }
}
