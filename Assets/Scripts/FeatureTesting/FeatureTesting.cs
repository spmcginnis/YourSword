using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class FeatureTesting : MonoBehaviour
    {
        SceneManager SceneManager;

        void Awake() {
            SceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
        }

        void Start()
        {
            SceneManager.ShowMenu();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                SceneManager.ShowMenu();
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                SceneManager.HideMenu();
            }
        }

    }
}
