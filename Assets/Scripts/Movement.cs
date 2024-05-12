using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private bool _isFaceRight = true;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(float direction, float speedMove)
    {
        Vector2 offset = new Vector2(direction * speedMove, _rigidbody.velocity.y);
        _rigidbody.velocity = offset;

        Reflect(direction);
    }

    private void Reflect(float direction)
    {
        if ((direction > 0 && _isFaceRight == false) || (direction < 0 && _isFaceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            _isFaceRight = !_isFaceRight;
        }
    }
}
