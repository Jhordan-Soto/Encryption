using System;
using System.Text;
using System.Security.Cryptography;

namespace CriptografiaSCD.utilidades
{
  class CriptoMD5
  {

    /// <summary>
    /// Encriptar un texto
    /// </summary>
    /// <param name="cadenaAEncriptar">Texto a encriptar</param>
    /// <returns>Texto encriptado</returns>
    public static string Encriptar(string cadenaAEncriptar) {

      byte[] byteAEncriptar;
      byte[] byteEncriptados;
      string sResultado;

      try
      {

        // validar
        if (cadenaAEncriptar.Trim()  == "") { 

          sResultado = "";

        } else {

          // convertir a bytes el texto a encriptar
          byteAEncriptar = Encoding.Unicode.GetBytes(cadenaAEncriptar);

          // encriptar texto
          byteEncriptados = MD5.Create().ComputeHash(byteAEncriptar);

          // convertir bytes a texto base 64
          sResultado = Convert.ToBase64String(byteEncriptados);

        }

        // final
        return sResultado;

      } catch (Exception) {
        // heredar
        throw;
      }
    }

  }

}
