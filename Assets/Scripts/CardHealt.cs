using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHealt : MonoBehaviour
{
    public Material matDissolveEdge;
    public float health;
    public float maxHealth;




    void Start()
    {
        matDissolveEdge.SetFloat("_Progress",1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            health -= 5;
            matDissolveEdge.SetFloat("_Progress", health / maxHealth);

        }
    }
}
