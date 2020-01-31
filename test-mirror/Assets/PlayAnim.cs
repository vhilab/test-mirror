using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    public GameObject tiger;

    // Start is called before the first frame update
    void Start()
    {
        tiger.GetComponent<Animation>().Play("run");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
