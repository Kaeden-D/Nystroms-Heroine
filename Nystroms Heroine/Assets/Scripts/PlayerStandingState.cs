using UnityEngine;

namespace Chapter.State
{

    public class PlayerStandingState : MonoBehaviour, PlayerState
    {

        private PlayerController _playerController;

        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
            {
                _playerController = playerController;
            }

            _playerController.CurrentSpeed = 0;

            if (_playerController.transform.localScale.y != 1)
            {
                _playerController.transform.localScale = new Vector3(1f, 1f, 1f);
                _playerController.transform.Translate(Vector3.up * 0.25f);
            }
            


        }

    }

}