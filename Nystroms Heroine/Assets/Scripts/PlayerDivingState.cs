using UnityEngine;

namespace Chapter.State
{

    public class PlayerDivingState : MonoBehaviour, PlayerState
    {

        private PlayerController _playerController;

        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
            {
                _playerController = playerController;
            }

            Rigidbody _rb = _playerController.GetComponent<Rigidbody>();

            if (_rb == null || _rb.linearVelocity.y == 0)
                return;

            _rb.AddForce(new Vector3(0f, -200f * _playerController.transform.localScale.y, 0f));


        }

    }

}