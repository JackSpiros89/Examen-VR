using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinja : MonoBehaviour
{

    [SerializeField]
    GameObject objectToSpawn;

    [SerializeField]
    float spawnTime;

    [SerializeField]
    float speed;

    [SerializeField]
    [Range(0f, 1f)]
    float random;


    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnCoroutine());

    }

    IEnumerator SpawnCoroutine()
    {

        while (isActiveAndEnabled)
        {

            GameObject instance = Instantiate(objectToSpawn, transform.position, Quaternion.identity, transform);
            Rigidbody rb = SetGetRigidbody(instance);

            rb.AddForce(new Vector3(1, 1, 0).normalized * speed * Random.Range(0, random), ForceMode.VelocityChange);


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
}
