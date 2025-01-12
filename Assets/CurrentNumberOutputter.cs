using TMPro;
using UnityEngine;

public class CurrentNumberOutputter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Timer _timer;

    private void OnEnable()
    {
        _timer.OnTimeUpdated += OutputNumber;
    }

    private void OnDisable()
    {
        _timer.OnTimeUpdated -= OutputNumber;
    }

    private void OutputNumber(int outputData)
    {
        _text.text = outputData.ToString();
    }
}
