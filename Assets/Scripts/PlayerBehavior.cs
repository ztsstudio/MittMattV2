using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public static PlayerBehavior Instance;
    private bool hasJumped = false;
        private Rigidbody rb;
        public float jumpForce;

    private void Awake()
    {

        // Singleton pattern
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

   
    }




