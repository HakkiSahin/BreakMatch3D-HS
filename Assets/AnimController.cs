using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = transform.GetChild(0).GetComponent<Animator>();
        anim.SetTrigger("Running");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
