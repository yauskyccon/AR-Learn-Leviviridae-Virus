using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class click : MonoBehaviour ,IVirtualButtonEventHandler
{
    public GameObject Leviviridae, VirtualButton;
    private AudioSource blink;
    private Animator LeviviridaeIdle;

    // Start is called before the first frame update
    void Start()
    {
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Leviviridae = GameObject.Find("Leviviridae");
        Leviviridae.SetActive(true);

        LeviviridaeIdle = Leviviridae.GetComponent<Animator>();
        blink = Leviviridae.GetComponent<AudioSource>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Leviviridae.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Leviviridae.SetActive(true);
        LeviviridaeIdle.SetTrigger("PlayAnimation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
