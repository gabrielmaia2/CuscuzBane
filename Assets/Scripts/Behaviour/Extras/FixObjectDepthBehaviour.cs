﻿using System.Collections;
using UnityEngine;

namespace CuscuzBane.Behaviour
{
    public class FixObjectDepthBehaviour : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y / 100);
        }
    }
}
