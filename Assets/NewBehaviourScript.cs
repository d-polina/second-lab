using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject TestObjects;

    public void Deactive(){
        TestObjects.SetActive(false);
    }
    public void Active(){
        TestObjects.SetActive(true);
    }
}
