using UniRx;
using UnityEngine;

namespace UniRxLearning
{
    public class IntroExample : MonoBehaviour
    {
        private void Start()
        {
            Observable.EveryUpdate()//开启Update的事件监听
                .Where(_ => Input.GetMouseButtonDown(0))//进行一个鼠标是否抬起的判断
                .First()//只判断第一次
                .Subscribe(_ =>
                {
                    Debug.Log("Mouse clicked");
                });
        }
    }
}