using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class notdestroy : MonoBehaviour {
    
    private void Start()
    {
        
    }
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
