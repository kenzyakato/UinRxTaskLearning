using System;
using UnityEngine;

namespace UniRxLearning._6.ReactiveProperty
{
    public class ReactivePropertyEX : MonoBehaviour
    {
        public Action<int> OnAgeChanged = null;

        public int age
        {
            get { return age; }

            set
            {
                if (age != value)
                {
                    age = value;
                    if (OnAgeChanged != null)
                    {
                        OnAgeChanged(value);
                    }
                }
            }
        }

        private void Start()
        {
            OnAgeChanged += age =>
            {
                Debug.Log("inner received age changed");
            };
        }

        private void Update()
        {
        }
    }
}