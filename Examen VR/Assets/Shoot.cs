using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
[RequireComponent(typeof(XRGrabInteractable))]
public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField]
     GameObject bala;
     [SerializeField]
     float speed =40;
     XRGrabInteractable m_InteractableBase;
    void Start()
    {
        m_InteractableBase = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {

    }

   public  void disparo (){
        GameObject disparo = Instantiate (bala,this.transform.position, transform.rotation);
        disparo.GetComponent<Rigidbody>().velocity = speed * this.transform.forward;
        print ("disparo");
        Destroy(disparo,3);
    }
}
