﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAll : MonoBehaviour
{
    public FlyCoronaMan coronaBoy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public IEnumerator freeze(){
        yield return new WaitForSeconds(2);
        Time.timeScale = 0;
    }
}
