using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
public class GameManager : MonoBehaviour
{
    [Title("Entidades en juego")]
    [ListDrawerSettings(Expanded = true)]
    public List<Entity> entidadesActuales = new List<Entity>();

    [Title("Control de turnos")]
    public CustomDoubleLinkedList<CustomNode> listaTurnos;

    private int turnoActual = 1;

    private void Start()
    {
        listaTurnos = new CustomDoubleLinkedList<CustomNode>();
        CrearTurnoInicial();
    }

    private void CrearTurnoInicial()
    {
        CustomNode turnoInicial = new CustomNode(turnoActual);
        foreach (var entidad in entidadesActuales)
        {
            turnoInicial.AgregarEntidad(entidad);
        }
        listaTurnos.Add(turnoInicial);
    }

    [Button("Avanzar Turno")]
    private void AvanzarTurno()
    {
        turnoActual++;
        CustomNode nuevoTurno = new CustomNode(turnoActual);

        foreach (var entidad in entidadesActuales)
        {
            nuevoTurno.AgregarEntidad(entidad);
        }

        listaTurnos.Add(nuevoTurno);
        Debug.Log("Nuevo turno añadido: " + turnoActual);
    }

    [Button("Retroceder Turno")]
    private void RetrocederTurno()
    {
        listaTurnos.MovePeakPrev();
        if (listaTurnos.Peak != null)
        {
            Debug.Log("Turno retrocedido a: " + listaTurnos.Peak.Value.NumeroTurno);
        }
    }

    [Button("Mostrar Turnos")]
    private void MostrarTurnos()
    {
        listaTurnos.ShowAllElements();
    }

    [Button("Mostrar Turno Actual (Peak)")]
    private void MostrarPeak()
    {
        listaTurnos.PrintPeak();
    }
}
