using System;
using Unity.VisualScripting;
using UnityEngine;
using UniRx;

namespace UniRxLearning._2.Update
{
    public class UpdateExample : MonoBehaviour
    {
        private bool buttonClicked = false;
        enum ButtonState
        {
            None,
            Clicked,
        }

        private ButtonState buttonState; 
        private void Start()
        {
            //监听鼠标左键
            Observable.EveryUpdate()
                .Subscribe(_ =>
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Debug.Log("left mouse button clicked");
                        buttonClicked = true;
                    }
                });
            
            //监听鼠标右键
            Observable.EveryUpdate()
                .Subscribe(_ =>
                {
                    if (Input.GetMouseButtonDown(1))
                    {
                        Debug.Log("right mouse button clicked");
                        buttonClicked = true;
                    }
                });
            if (buttonClicked && buttonState == ButtonState.None)
            {
                buttonState = ButtonState.Clicked;
            }

        }
        //监听状态
        
      

        

   
        
    }
}