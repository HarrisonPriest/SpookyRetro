using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class triggerSceneChange : MonoBehaviour {
    private GameObject player;
    private Collider a;
    private GameObject door;
    private Animator anim;


    RawImage Fade_effect;

    public void Start()
    {
        a = GetComponent<Collider>();
        player = GameObject.FindGameObjectWithTag("Player");
        a.isTrigger = true;
        anim = GameObject.Find("HUD").GetComponent<Animator>();
        Fade_effect = GameObject.Find("Fade_effect").GetComponent<RawImage>();

    }

    void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {

                switch (SceneManager.GetActiveScene().name)
                {

                   
                    case "Outdoors":
                        if (name == "roomChange_maze")
                            LoadLevel("Maze");
                        break;
                    
                }

            }
        }
        
            


    }
    private void LoadLevel(string SceneLoad) {
        StartCoroutine(Fading(SceneLoad));

    }
    IEnumerator Fading(string SceneLoad) {

        anim.SetBool("Fade", true);
        player.SetActive(false);
        yield return new WaitUntil(()=>Fade_effect.color.a==0);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene(SceneLoad);
        Debug.Log("Room Loaded");
        player.SetActive(true);
        anim.SetBool("Fade", false);
    }
}
