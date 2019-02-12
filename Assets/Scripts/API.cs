using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class API : MonoBehaviour
{
    private const string url =
        "http://api.openweathermap.org/data/2.5/weather?q=Wilsonville,US&appid=272d4a7147e89ee64c76e699bdfa2a9e&units=&cnt=6";
    
    // Use this for initialization
    public void Request () {
        WWW request = new WWW(url);
        StartCoroutine(OnResponse(request));
        
    }

    private IEnumerator OnResponse(WWW req)
    {
        yield return req;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
