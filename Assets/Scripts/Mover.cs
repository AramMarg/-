using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speedMovement;

    private void Update()
    {
        transform.Translate(_speedMovement * Time.deltaTime * Vector3.forward);
    }
}
