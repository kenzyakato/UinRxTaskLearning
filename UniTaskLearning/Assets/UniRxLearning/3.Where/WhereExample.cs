using System;
using UniRx;
using UnityEngine;

namespace UniRxLearning._3.Where
{
    public class WhereExample : MonoBehaviour
    {
        private void Start()
        {
            Observable.EveryUpdate()
                .Where(_ => Input.GetMouseButtonDown(0))
                .First()
                .Subscribe(_ =>
                {
                    Debug.Log("Mouse button down");
                });
        }
    }
}