using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgmt : MonoBehaviour
{
    public void SceneSwitcher()
    {
        System.DateTime currentTime;
        var now = currentTime.TimeOfDay;

        System.TimeSpan morningStart = new System.TimeSpan(07, 0, 0);
        System.TimeSpan morningEnd = new System.TimeSpan(11, 59, 59);

        System.TimeSpan afternoonStart = new System.TimeSpan(12, 0, 0);
        System.TimeSpan afternoonEnd = new System.TimeSpan(16, 59, 59);

        System.TimeSpan eveningStart = new System.TimeSpan(17, 0, 0);
        System.TimeSpan eveningEnd = new System.TimeSpan(20, 59, 59);

        if ((now > morningStart) && (now < morningEnd))
        {
            SceneManager.LoadScene(1);
        }

        else if ((now > afternoonStart) && (now < afternoonEnd))
        {
            SceneManager.LoadScene(2);
        }

        else if ((now > eveningStart) && (now < eveningEnd))
        {
            SceneManager.LoadScene(3);
        }

        else
        {
            SceneManager.LoadScene(4);
        }

    }
}
