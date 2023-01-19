using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySpawn : MonoBehaviour
{

    [SerializeField]
    GameObject objectToSpawn;

    [SerializeField]
    float spawnTime;

    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine()
    {
        BoxCollider pantalla = GetComponent<BoxCollider>();
        Debug.Log(pantalla.size);
        while (isActiveAndEnabled)
        {   

            Vector3 spawn= new Vector3(Random.Range(-pantalla.size.x/4,pantalla.size.x/4),Random.Range(-pantalla.size.y/4,pantalla.size.y/4), 20);
            Debug.Log(spawn);
            GameObject instance = Instantiate(objectToSpawn, spawn, Quaternion.identity,transform);
            instance.transform.localPosition = spawn;
            Rigidbody rb = SetGetRigidbody(instance);
            rb.AddForce(new Vector3(0, 0, -1).normalized * speed, ForceMode.VelocityChange);
            yield return new WaitForSeconds(spawnTime);
        }


    }
    Rigidbody SetGetRigidbody(GameObject instance) {
        Rigidbody rb = instance.GetComponent<Rigidbody>();

        if (rb == null)
        {
            instance.AddComponent<Rigidbody>();
            rb = instance.GetComponent<Rigidbody>();
        }

        return rb;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider){ 
        if (collider.tag =="Energy"){
            Destroy(collider.gameObject);
            GameManager.puntos-=1;
        }
    }
}
