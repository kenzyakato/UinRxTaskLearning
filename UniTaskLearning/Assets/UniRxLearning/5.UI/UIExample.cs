using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

namespace UniRxLearning._5.UI
{
    public class UIExample : MonoBehaviour
    {
        private void Start()
        {
            var button = transform.Find("Button").GetComponent<Button>();
            button.OnClickAsObservable()
                .Subscribe(_ => Debug.Log("Button!!"));
            var toggle = transform.Find("Toggle").GetComponent<Toggle>();
            toggle.OnValueChangedAsObservable()
                .Where(on=>on)
                .Subscribe(on => Debug.Log(on));
            var image = transform.Find("Image").GetComponent<Graphic>();
            
            image.OnBeginDragAsObservable().Subscribe(_ => Debug.Log("began drag"));
            image.OnDragAsObservable().Subscribe(_ => Debug.Log("On drag"));
            image.OnEndDragAsObservable().Subscribe(_ => Debug.Log("end drag"));
        }
    }
}