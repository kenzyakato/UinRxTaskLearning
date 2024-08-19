using System;
using UniRx;
using UnityEngine;

namespace UniRxLearning._4.First
{
    public class FirstExample : MonoBehaviour
    {
        private void Start()
        {
            Observable.EveryUpdate()
                .First(_ => Input.GetMouseButtonDown(0))
                .Subscribe(_ => Debug.Log("mouse clicked"))
                .AddTo(this);
        }
    }
}