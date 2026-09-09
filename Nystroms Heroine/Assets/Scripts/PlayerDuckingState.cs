using UnityEngine;

namespace Chapter.State
{

    public class PlayerDuckingState : MonoBehaviour, PlayerState
    {

        private PlayerController _playerController;

        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
            {
                _playerController = playerController;
            }

            if (_playerController.transform.localScale.y != 1f)
                return;

            _playerController.transform.localScale = new Vector3(1f, 0.5f, 1f);
            _playerController.transform.Translate(Vector3.up * -0.45f);

        }

    }

}