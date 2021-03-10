using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherController : MonoBehaviour
{
    [SerializeField] private Material sky;
    [SerializeField] private Light sun;

    private float _fullIntensity;
    private float _sunnyValue = 1f;

    // Start is called before the first frame update
    void Start()
    {
        _fullIntensity = sun.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if (_sunnyValue > 0) {
            SetOvercast(_sunnyValue);
            _sunnyValue -= 0.0005f;
        }
    }

    private void SetOvercast(float value) {
        sky.SetFloat("_Blend", value);
        sun.intensity = 0.6f + 0.4f * _fullIntensity * value;
    }
}
