using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationManager : MonoBehaviour
{
    public static SimulationManager Instance;
    [SerializeField] Time time;
    
    
    
    public Score score;
    void Start()
    {
        if (Instance == null)
        {
            Instance = this; //si no tiene valor entonces se le pondrá *este* valor
        }
        else 
        {
            Destroy(gameObject);
        } 
    }

    public void StartGame() 
    {

    }
    public void ResumeGame() 
    {

    }
    public void PauseGame() 
    {

    } 
    public void RestartGame() 
    {

    }

}
