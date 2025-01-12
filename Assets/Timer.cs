using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private Button _button;

    public event Action<int> OnTimeUpdated;

    private int _currentNumber = 0;
    private bool _timerStarted = false;
    private WaitForSeconds _wait;
    

    private void Start()
    {
        _wait = new WaitForSeconds(_delay);
        _button.onClick.AddListener(ResetTimer);
    }

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
    }

    private IEnumerator Time()
    {
        while (_timerStarted)
        {
            OnTimeUpdated?.Invoke(_currentNumber);

            yield return _wait;

            _currentNumber++;
        }
    }
}
