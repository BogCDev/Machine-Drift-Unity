using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RulController : MonoBehaviour
{
    [SerializeField] private GameObject _rifle;
    public Slider _slider;
    private void LateUpdate()
    {
        _rifle.transform.rotation = Quaternion.Euler(0, 0, -_slider.value * 100);
    }
}
