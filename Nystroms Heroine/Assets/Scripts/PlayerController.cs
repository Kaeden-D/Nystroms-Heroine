using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Chapter.State
{

    public class PlayerController : MonoBehaviour
    {

        public float maxSpeed = 2.0f;
        public float turnDistance = 2.0f;

        public float CurrentSpeed { get; set; }
        public Direction CurrentTurnDirection { get; private set; }

        private PlayerState _standingState, _duckingState, _jumpingState, _divingState, _leapingState, _doubleJumpState, _walkingState;

        private PlayerStateContext _playerStateContext;

        private void Start()
        {

            _playerStateContext = new PlayerStateContext(this);

            _standingState = gameObject.AddComponent<PlayerStandingState>();
            _duckingState = gameObject.AddComponent<PlayerDuckingState>();
            _jumpingState = gameObject.AddComponent<PlayerJumpingState>();
            _divingState = gameObject.AddComponent<PlayerDivingState>();
            _leapingState = gameObject.AddComponent<PlayerLeapingState>();
            _doubleJumpState = gameObject.AddComponent<PlayerDoubleJumpState>();
            _walkingState = gameObject.AddComponent<PlayerWalkingState>();

            _playerStateContext.Transition(_standingState);

        }

        private void Update()
        {

            if (Keyboard.current.xKey.wasPressedThisFrame)
                Stand();

            if (Keyboard.current.wKey.wasPressedThisFrame)
                Walk();

            if (Keyboard.current.dKey.wasPressedThisFrame)
                Duck();

            if (Keyboard.current.sKey.wasPressedThisFrame)
                Dive();

            if (Keyboard.current.lKey.wasPressedThisFrame)
                Leap();

            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                DoubleJump();
                Jump();
            }
                
        }

        public void Stand()
        {
            _playerStateContext.Transition(_standingState);
        }

        public void Duck()
        {
            _playerStateContext.Transition(_duckingState);
        }

        public void Jump()
        {
            _playerStateContext.Transition(_jumpingState);
        }

        public void Dive()
        {
            _playerStateContext.Transition(_divingState);
        }

        public void Leap()
        {
            _playerStateContext.Transition(_leapingState);
        }

        public void DoubleJump()
        {
            _playerStateContext.Transition(_doubleJumpState);
        }

        public void Walk()
        {
            _playerStateContext.Transition(_walkingState);
        }

    }

}