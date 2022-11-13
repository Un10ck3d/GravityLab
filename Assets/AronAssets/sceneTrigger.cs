using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneTrigger : MonoBehaviour
{
    [SerializeField]
    private mainController mainController;
    private bool used = false;
    void OnTriggerEnter(Collider other)
    {
        if(used == false)
        {
            if(!other.isTrigger)
            {
                if(other.gameObject.name == "player")
                {
                    Debug.Log("next scene at "+gameObject.name);
                    mainController.nextCameraPos(1);
                }
            }
        }
        else
        {
            if(!other.isTrigger)
            {
                if(other.gameObject.name == "player")
                {
                    mainController.nextCameraPos(-1);
                }
            }
        }
    }
}
