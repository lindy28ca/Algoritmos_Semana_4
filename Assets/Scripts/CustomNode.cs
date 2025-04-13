using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;

public class CustomNode : MonoBehaviour
{
    public int NumeroTurno { get; set; }
    public List<Entity> Entidades { get; set; }

    public CustomNode(int numeroTurno)
    {
        NumeroTurno = numeroTurno;
        Entidades = new List<Entity>();
    }

    public void AgregarEntidad(Entity entidad)
    {
        Entidades.Add(entidad);
    }

    public override string ToString()
    {
        string resultado = $"Turno #{NumeroTurno}:";
        foreach (var entidad in Entidades)
        {
            resultado += $"\n  - {entidad.Nombre} en {entidad.Posicion}";
        }
        return resultado;
    }
}
