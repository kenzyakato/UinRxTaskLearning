using UnityEngine;

namespace UniRxLearning
{
    public class CommonTimerExample : MonoBehaviour
    {
        private float _mStartTime;

        private void Start()
        {
            _mStartTime = Time.time;
        }

        private void Update()
        {
            if (Time.time - _mStartTime >5)
            {
                Debug.Log("do something");

                _mStartTime = float.MaxValue;
            }
        }
    }
}