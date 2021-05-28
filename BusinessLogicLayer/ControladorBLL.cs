using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using ObjetosTransferencia.DTO;

namespace BusinessLogicLayer
{
    
    public static class ControladorBLL
    {

        #region Atributos
        

        #endregion

        #region Constructores
     

        #endregion

        #region Propiedades
        //private AccesoDatosDAL accesoDatos = new AccesoDatosDAL();


        #endregion

        #region Metodos


        /// <summary>
        /// Pedir datos de la lista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public static List<ClienteDTO> PedirListaClientes()
        {
            // TODO: llama al metodo que pide la lista de clientes
            List<ClienteDTO> listaClientes = AccesoDatosDAL.ListadoClientesNorthWind();
            return listaClientes;
            //throw new Exception();
        }


        /// <summary>
        /// Pedir la lista de pedidos de un clientelista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public static List<PedidoDTO> ListarPedidosCliente(String nombreCliente)
        {
            // TODO: llamar al metodo que lista los pedidos
            List<PedidoDTO> listaPedidos = AccesoDatosDAL.ListadoPedidosCliente(nombreCliente);
            return listaPedidos;
            //throw new Exception();
        }


        #endregion


    }
}
