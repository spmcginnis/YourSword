using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class MenuTesting : MonoBehaviour
    {
        GameObject Managers;
        SceneManager SceneManager;
        GamePlayManager GP;

        void Awake() {
            Managers = GameObject.Find("Managers");
            SceneManager = Managers.GetComponent<SceneManager>();
            GP = Managers.GetComponent<GamePlayManager>();
        }

        // Testing the Show/Hide Menu
        void Start()
        {
            GP.ShowMenu();
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                GP.ShowMenu();
            }
        }
    }
}
