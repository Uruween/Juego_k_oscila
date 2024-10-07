using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigid;
    private float movimientoHorizontal = 0f;
    [SerializeField] private float velocidadMovimiento;
    [Range(0, 0.3f)][SerializeField] private float suavizado;
    private Vector3 velocidad = Vector3.zero;
    private bool lookingTo = true;

    [SerializeField] private float fuerzaSalto;
    [SerializeField] private LayerMask capita;
    [SerializeField] private Transform detector;
    [SerializeField] private Vector3 cajaSuelo;
    [SerializeField] private bool suelo;
    private bool salto = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadMovimiento;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            salto = true;
        }
    }

    public void FixedUpdate()
    {
        suelo = Physics2D.OverlapBox(detector.position, cajaSuelo, 0f, capita);
        mover(movimientoHorizontal * Time.deltaTime, salto);
        salto = false;
    }
    private void mover(float mover, bool salto)
    {
        Vector3 velocidadObjetivo = new Vector2(mover, rigid.velocity.y);
        rigid.velocity = Vector3.SmoothDamp(rigid.velocity, velocidadObjetivo, ref velocidad, suavizado); 
                                                                                                          
        if (mover > 0 && !lookingTo)
        {
            Girar();
        }
        else if (mover < 0 && lookingTo)
        {
            Girar();
        }
        if (suelo && salto)
        {
            suelo = false;
            rigid.AddForce(new Vector2(0f, fuerzaSalto));
        }
    }

    private void Girar()
    {
        lookingTo = !lookingTo;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(detector.position, cajaSuelo);
    }

}
