using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterfazDentalidea2
{
    internal class archivoRegistroPacienteClase
    {
        public void GuardarArchivo(List<pacienteRegistroClase> pacientes, string rutaArchivo)
        {
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    foreach (pacienteRegistroClase c in pacientes)
                    {
                        escritor.Write(c.ID);
                        escritor.Write(c.Name.Length);
                        escritor.Write(c.Name.ToCharArray());
                        escritor.Write(c.Direccion);
                        escritor.Write(c.Blood);
                        escritor.Write(c.Edad);
                        escritor.Write(c.Sexo);
                        escritor.Write(c.Numero);
                    }
                }
            }
        }

        public List<pacienteRegistroClase> CargarPacientes(string rutaArchivo)
        {
            List<pacienteRegistroClase> pacientes = new List<pacienteRegistroClase>();

            if (!File.Exists(rutaArchivo))
            {
                return pacientes;
            }

            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lector = new BinaryReader(archivo))
                {
                    while (archivo.Position < archivo.Length)
                    {
                        try
                        {
                            string id = lector.ReadString();
                            int tamaño = lector.ReadInt32();
                            char[] nombreArray = lector.ReadChars(tamaño);
                            string name = new string(nombreArray);
                            string direccion = lector.ReadString();
                            string blood = lector.ReadString();
                            int edad = lector.ReadInt32();
                            string sexo = lector.ReadString();
                            string numero = lector.ReadString();

                            pacienteRegistroClase paciente = new pacienteRegistroClase
                            {
                                ID = id,
                                Name = name,
                                Direccion = direccion,
                                Blood = blood,
                                Edad = edad,
                                Sexo = sexo,
                                Numero = numero
                            };

                            pacientes.Add(paciente);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error leyendo archivo: " + ex.Message);
                            break;
                        }
                    }
                }
            }

            return pacientes;
        }
    }
}
