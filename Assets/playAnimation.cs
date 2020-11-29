using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour
{

    public Animator anim;
    public AudioSource audiosource;
    private IEnumerator coroutine;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    private IEnumerator wait()
    {
        yield return new WaitForSeconds(2.0f);
        anim.SetBool("isDancing", false);
    }

    public void setAnimation()
    {
        audiosource.Play();
        anim.SetBool("isDancing", true);
        coroutine = wait();
        StartCoroutine(coroutine);
    }
}
