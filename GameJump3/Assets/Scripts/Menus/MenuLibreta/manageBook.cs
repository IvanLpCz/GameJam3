using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bbook
{
    public class manageBook : MonoBehaviour
    {
        public Button sospechosos, pistas, salir, volverAtrasPistas, volverAtrasSospechosos, isabelaBoton, isabelaVolver, lorenzoBoton, lorenzoVolver, franciscoBoton, franciscoVolver, elenaBoton, elenaVolver, incriminacionVolver;
        public GameObject libro, inicioPagina, sospechososPagina, pistasPagina, isabelaPagina, lorenzoPagina, franciscoPagina, elenaPagina, menuIncriminacion;

        public void openSospechosos()
        {
            inicioPagina.SetActive(false);
            sospechososPagina.SetActive(true);
        }
        public void openPistas()
        {
            inicioPagina.SetActive(false);
            pistasPagina.SetActive(true);
        }
        public void salirLibro()
        {
            Time.timeScale = 1;
            libro.SetActive(false);
        }
        public void retrocederPistas()
        {
            pistasPagina.SetActive(false);
            inicioPagina.SetActive(true);
        }
        public void retrocederSospechosos()
        {
            sospechososPagina.SetActive(false);
            inicioPagina.SetActive(true);
        }
        public void perfilIsabela()
        {
            sospechososPagina.SetActive(false);
            isabelaPagina.SetActive(true);
        }
        public void volverIsabela()
        {
            isabelaPagina.SetActive(false);
            sospechososPagina.SetActive(true);           
        }
        public void perfilLorenzo()
        {
            sospechososPagina.SetActive(false);
            lorenzoPagina.SetActive(true);
        }
        public void volverLorenzo()
        {
            lorenzoPagina.SetActive(false);
            sospechososPagina.SetActive(true);
        }
        public void perfilFrancisco()
        {
            sospechososPagina.SetActive(false);
            franciscoPagina.SetActive(true);
        }
        public void volverFrancisco()
        {
            franciscoPagina.SetActive(false);
            sospechososPagina.SetActive(true);
        }
        public void perfilElena()
        {
            sospechososPagina.SetActive(false);
            elenaPagina.SetActive(true);
        }
        public void volverElena()
        {
            elenaPagina.SetActive(false);
            sospechososPagina.SetActive(true);
        }
        public void volverAvatares()
        {
            menuIncriminacion.SetActive(false);
            sospechososPagina.SetActive(true);
        }

    }
}
