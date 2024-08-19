using System;
using System.Collections;
using UnityEngine;

namespace UniRxLearning
{
    public class CoroutineTimerExample : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(Timer(5, (() =>
            {
                Debug.Log("do something");
            })));

        }

        private IEnumerator Timer(float seconds, Action callback)
        {
            yield return new WaitForSeconds(seconds);
            callback();
        }
    }
}