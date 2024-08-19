using System;
using UniRx;
using UnityEngine;

namespace UniRxLearning._1.Timer
{
    public class UniRxTimerExample : MonoBehaviour
    {
        private void Start()
        {
            Observable.Timer(TimeSpan.FromSeconds(5.0f))
                .Subscribe(_ =>
                {
                    Debug.Log("Do something");
                });
        }
    }
}