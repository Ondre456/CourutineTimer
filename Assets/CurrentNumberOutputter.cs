using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentNumberOutputter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Timer _timer;

    private void Start()
    {
        _timer.OnTimeUpdated += OutputNumber;
    }

    private void OutputNumber(int outputData)
    {
        _text.text = outputData.ToString();
    }
}
