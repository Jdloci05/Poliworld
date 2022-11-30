using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje1 : MonoBehaviour
{
    public int velCorrer;
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public CharacterController controller;
    private Animator anim;
    public float x, y, sumergirse;

    public Rigidbody rb;
    public float fuerzaDeSalto = 8f;
    public float disRayoProfundidad;
    public bool puedoSaltar;
    public bool suspendido, sumergido;
    public bool enAgua;
    float profundidad;

    public float velocidadInicial;

    public Transform cam;

    void ConfiguraRb()
    {
        rb.useGravity = !sumergido;

        if (sumergido == true)
        {
            rb.velocity = Vector3.zero;
            anim.SetBool("nadando", true);
        }
        else
        {
            anim.SetBool("nadando", false);
        }
    }

    void SensorProfundidad()
    {
        sumergido = false;
        int nLayer = 1 << 4;

        RaycastHit rh;
        if (Physics.Raycast(transform.position + Vector3.up * disRayoProfundidad, Vector3.down, out rh, disRayoProfundidad, nLayer))
        {
            float distanciaAgua = rh.point.y - transform.position.y;
            if (distanciaAgua >= 0.5)
            {
                sumergido = true;
            }
        }
    }
    void MovimientosNadando()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.X))
        {
            sumergirse = -1 * velocidadMovimiento * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            sumergirse = 1 * velocidadMovimiento * Time.deltaTime;
        }
        else
        {
            sumergirse = 0;
        }
        Vector3 movimiento = new Vector3(x, sumergirse, y);
        anim.SetFloat("velocidadCaminar", movimiento.magnitude);
    }

    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void movimientoPersonaje()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -y * Time.deltaTime * velocidadMovimiento);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, x * Time.deltaTime * velocidadMovimiento);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -x * Time.deltaTime * velocidadMovimiento);
        }

        //movimiento camara
        Vector3 direction = new Vector3(x, 0f, y).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float tarjetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, tarjetAngle, ref turnSmoothVelocity, turnSmoothTime);

            Vector3 moveDir = Quaternion.Euler(0f, tarjetAngle, 0f) * Vector3.forward;

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(moveDir.normalized * velocidadMovimiento * Time.deltaTime);
        }
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
    // Update is called once per frame
    void Update()
    {  
        if (sumergido) 
        {
            MovimientosNadando();
            ConfiguraRb();
            SensorProfundidad();
            movimientoPersonaje();
        }
        else
        {
            SensorProfundidad();
            ConfiguraRb();
            movimientoPersonaje();
        }

        //otras opciones
        if (Input.GetKey(KeyCode.LeftShift) && puedoSaltar)
        {
            velocidadMovimiento = velCorrer;
            if (y > 0)
            {
                anim.SetBool("correr", true);
            }
            else
            {
                anim.SetBool("correr", false);
            }
        }
        else
        {
            anim.SetBool("correr", false);

            if (puedoSaltar)
            {
                velocidadMovimiento = velocidadInicial;
            }
        }

        if (puedoSaltar) 
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                anim.SetBool("salte", true);
                rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocoSuelo", true);
        }
        else 
        {
            EstoyCayendo();
        }
    }
    public void EstoyCayendo() 
    {
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("salte", false);  
    }
}
