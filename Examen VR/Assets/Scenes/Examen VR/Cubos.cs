using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
[RequireComponent(typeof(XRGrabInteractable))]

public class Cubos : MonoBehaviour
{

    XRBaseInteractable m_Interactable;
    
    Renderer m_Renderer, inicial;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Interactable = GetComponent<XRBaseInteractable>();
        m_Renderer = GetComponent<Renderer>();
        inicial = GetComponent<Renderer>();
    }

    // Update is called once per frame

    public void verde(){
        // cambia al color verdeXRBaseInteractable m_Interactable;
        m_Renderer.material.color = Color.green;
    }
    public void blanco(){
        // cambia al colo blanco
        m_Renderer.material.color = Color.white;
    }
    public void original(){
        m_Renderer.material.color= inicial.material.color;
    }
}
