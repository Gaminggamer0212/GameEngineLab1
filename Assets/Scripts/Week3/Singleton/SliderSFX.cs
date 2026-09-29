using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SliderSFX : MonoBehaviour
{
    [SerializeField] private Slider slider;

    void OnEnable()
    {
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    void OnDisable()
    {
        slider.onValueChanged.RemoveListener(OnSliderValueChanged);
    }
   
   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.value = AudioManager.Instance.GetSfxVolume();
    }

    void OnSliderValueChanged(float value)
    {
        AudioManager.Instance.ChangeSfxVolume(value);
    }
}
