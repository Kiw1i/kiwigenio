using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProyectoServicio
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IList<string> GetCiudades();
        [OperationContract]
        void GuardarDatosEnArchivo(string nombre, string apellidos, string correo, string genero, int ciudad, string requerimientos);
    }
}
