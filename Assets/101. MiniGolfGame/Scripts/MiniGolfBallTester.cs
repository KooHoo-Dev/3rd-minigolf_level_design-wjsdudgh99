using System;
using Study.Utilities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MiniGolfGame
{
    public class MiniGolfBallTester : MonoBehaviour
    {
        public MiniGolfBall ball;
        public Vector3 startPosition;

        private void Update()
        {
            if (SimpleInput.GetKeyDown(Key.Digit1))
            {
                ball.ReturnToLasShotPosition();
            }
            if (SimpleInput.GetKeyDown(Key.Digit2))
            {
                ball.PlaceAt(startPosition);
            }
        }
    }
}