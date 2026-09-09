using UnityEngine;

namespace Chapter.State
{

    public class PlayerLeapingState : MonoBehaviour, PlayerState
    {

        private PlayerController _playerController;

        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
            {
                _playerController = playerController;
            }
            _playerController.CurrentSpeed = 0;

            Rigidbody _rb = _playerController.GetComponent<Rigidbody>();

            if (_rb == null || _rb.linearVelocity.y != 0)
                return;

            _rb.AddForce(new Vector3(0f, 500f * _playerController.transform.localScale.y, 100f));

        }

    }

}