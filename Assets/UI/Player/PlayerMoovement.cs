using System;
using UnityEngine;

namespace UI.Player
{
    public class PlayerMoovement : MonoBehaviour
    {
        public Rigidbody PlayerBody;
        private float _x;
        private float _y;

        void Update()
        {
            _x = Input.GetAxisRaw("Horizontal");
            _y = Input.GetAxisRaw("Vertical");
        }

        private void FixedUpdate()
        {
            PlayerBody.AddForce(new Vector3(_x * 10, 0, _y * 10));
        }
    }
}
