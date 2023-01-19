using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    static private int _puntos = 0;
    static private GameObject CountPuntos;
        public static int puntos
    {
        get
        {
            return _puntos;
        }
        set
        {
            _puntos = value;
            UpdatePuntos();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        CountPuntos = GameObject.Find("CountPuntos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        static void UpdatePuntos()
    {
        CountPuntos.GetComponent<Text>().text = puntos.ToString();
    }
}
