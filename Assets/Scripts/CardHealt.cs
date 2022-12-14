using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHealt : MonoBehaviour
{
    public Material matDissolveEdge;
    public float health;
    public float maxHealth;
    public float healthToLose;
    public ParticleSystem particles;
    void Start()
    {
        matDissolveEdge.SetFloat("_Progress",1.0f);
    }

    [ContextMenu("Disolve Card")]
    public void DisolveCard()
    {
        StartCoroutine(EffectDisolve());
    }

    private IEnumerator EffectDisolve()
    {
        while(health >= 0)
        {
            health -= healthToLose;
            matDissolveEdge.SetFloat("_Progress", health / maxHealth);
            yield return new WaitForSeconds(0.05f);
        }
        particles.Play();
        GameManager.CanClick = true;
        yield return new WaitForSeconds(2.5f);
        gameObject.SetActive(false);
    }
}
