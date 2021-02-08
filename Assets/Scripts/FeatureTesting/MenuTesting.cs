using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class MenuTesting : MonoBehaviour
    {
        SceneManager SceneManager;

        void Awake() {
            SceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
        }




        // Testing the Show/Hide Menu
        void Start()
        {
            SceneManager.ShowMenu();
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.ShowMenu();
            }
        }

    }
}
