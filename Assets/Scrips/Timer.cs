using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Timer : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] Timer timer;
    public void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                Debug.Log("Finalizado");
            }
        }
        StartTimer();

        
    }
    public void StartTimer()
    {
        
    }
    public void Stopimer()
    {

    }
    public void PauseTimer()
    {

    }
    public void RestartTimer()
    {

    }
}
