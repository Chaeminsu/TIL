﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManger
{
    public Action keyAction = null;
    public Action<Define.MouseEvent> MouseAction = null;
    public bool _pressed = false;
    public void OnUpdate()
    {
        if (Input.anyKey && keyAction != null)
            keyAction.Invoke();

        if (MouseAction != null)
        {
            if (Input.GetMouseButton(0))
            {
                MouseAction.Invoke(Define.MouseEvent.Press);
                _pressed = true;
            }
            else
            {
                if (_pressed)
                    MouseAction.Invoke(Define.MouseEvent.Click);

                _pressed = false;
            }
        }



    }
}
