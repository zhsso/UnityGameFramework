﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Net;

public class GameController : MonoBehaviour
{
    #region 内置函数

    // Use this for initialization
    void Start ()
    {
        gameObject.AddComponent<NetManager>();

        NetManager.Instance.SendConnect();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    #endregion
}
