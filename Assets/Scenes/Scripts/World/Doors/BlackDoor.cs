using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackDoor : MonoBehaviour
{
    LevelController levelC; 

    // Start is called before the first frame update
    void Start()
    {
        levelC = GameObject.Find("LevelController").GetComponent<LevelController>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        levelC.blackOnDoor = true;
    }

}
