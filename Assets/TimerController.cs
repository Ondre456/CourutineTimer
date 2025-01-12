using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay = 0.5f;

    private int _currentNumber = 0;
    private bool _timerStarted = false;
    private WaitForSeconds _wait;
    
    public void ResetTimer()
    {
        if (_timerStarted)
        {
            _timerStarted = false;
        }
        else
        {
            _timerStarted = true;
            StartCoroutine(Time());
        }

        Debug.Log(_timerStarted);
    }

    private void Start()
    {
        _text.text = "";
        _wait = new WaitForSeconds(_delay);
    }

    private IEnumerator Time()
    {
        while (_timerStarted)
        {
       
            _text.text = _currentNumber.ToString();
            Debug.Log(_currentNumber);

            yield return _wait;

            _currentNumber++;
        }
    }
}
