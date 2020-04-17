using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [Header("寶箱彈跳")]
    public Animator TreasureChestClosed;
    [Header("喇叭")]
    public AudioSource aud;
    [Header("寶箱彈跳音效")]
    public AudioClip ChestJump;

    [Header("木桶搖晃")]
    public Animator Default;
    [Header("木桶搖晃音效")]
    public AudioClip DefaultJump;

    [Header("燭台彈跳")]
    public Animator CandleLight;
    [Header("燭台彈跳音效")]
    public AudioClip CandleLightJump;

    public void LookChest()
    {
        TreasureChestClosed.SetTrigger("寶箱彈跳");
        aud.PlayOneShot(ChestJump,0.2f);
}
    public void LookDefault()
    {
        Default.SetTrigger("木桶搖晃");
        aud.PlayOneShot(DefaultJump, 0.2f);
    }
    public void LookCandleLight()
    {
        CandleLight.SetTrigger("燭台彈跳");
        aud.PlayOneShot(CandleLightJump, 0.2f);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
