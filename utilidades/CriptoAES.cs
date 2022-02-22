using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace CriptografiaSCD.utilidades
{

  class CriptoAES
  {

    private readonly string _claveSecreta;
    private readonly string _claveHash;

    /// <summary>
    /// Inicializa una nueva instancia de clase <see cref="CriptoAES"/>, por medio de una palabra u oración que sirve de Clave Secreta y otra palabra u oración que sirve de  Clave Hash
    /// </summary>
    /// <param name="claveSecreta">Palabra u oración que sirve de Clave Secreta</param>
    /// <param name="claveSecreta">Palabra u oración que sirve de Clave Hash</param>
    public CriptoAES(string claveSecreta, string claveHash) {
      try
      {
      
        // asignar
        _claveSecreta = claveSecreta;
        _claveHash = claveHash;

      } catch (Exception){
        // heredar
        throw ;
      }

    }

    /// <summary>
    /// Encriptar un texto
    /// </summary>
    /// <param name="cadenaAEncriptar">Texto a encriptar</param>
    /// <returns>Texto encriptado</returns>
    public string Encriptar(string cadenaAEncriptar) {

      string cadenaEncriptada = "";
      RijndaelManaged algorithm = obtenerAlgoritmo();
      byte[] byteAEncriptar;
      byte[] byteEncriptados;

      try
      {

        // crear stream para escribir encriptado
        using (MemoryStream msEncriptar = new MemoryStream()) {
          
          // crear motor de encriptado
          using (CryptoStream csEncriptar = new CryptoStream(msEncriptar, algorithm.CreateEncryptor(), CryptoStreamMode.Write)) {

            // convertir a bytes el texto a encriptar
            byteAEncriptar = Encoding.Unicode.GetBytes(cadenaAEncriptar);

            // encriptar texto
            csEncriptar.Write(byteAEncriptar, 0, byteAEncriptar.Length);
            csEncriptar.FlushFinalBlock();

            // recuperar bytes encriptados
            byteEncriptados = msEncriptar.ToArray();

            // convertir bytes a texto base 64
            cadenaEncriptada = Convert.ToBase64String(byteEncriptados);

          }

        }
    
        // final
        return cadenaEncriptada;
      }
      catch (Exception)
      {
        // heredar
        throw;
      }
    }

    /// <summary>
    /// Desencriptar un texto
    /// </summary>
    /// <param name="cadenaEncriptada">Texto encriptado</param>
    /// <returns>Texto desencriptado</returns>
    public string Desencriptar(string cadenaEncriptada) {

      string cadenaDesencriptada = null;
      RijndaelManaged algorithm = obtenerAlgoritmo();
      byte[] byteEncriptados;
      byte[] byteDesencriptados;

      try
      {

        // convertir a bytes el texto encriptado
        byteEncriptados = Convert.FromBase64String(cadenaEncriptada);

        // definir tamaño del arreglo de bytes
        byteDesencriptados = new byte[byteEncriptados.Length];

        // crear stream con bytes encriptados
        using (MemoryStream msDesencriptar = new MemoryStream(byteEncriptados)) {

          // crear motor de encriptado
          using (CryptoStream csDesencriptar = new CryptoStream(msDesencriptar, algorithm.CreateDecryptor(), CryptoStreamMode.Read)) {

            // desencriptar y guardar bytes desencriptados
            csDesencriptar.Read(byteDesencriptados, 0, byteDesencriptados.Length);

            // convertir bytes desencriptados a texto unicode
            cadenaDesencriptada = Encoding.Unicode.GetString(byteDesencriptados);

            // limpiar terminador de cadenas
            cadenaDesencriptada = cadenaDesencriptada.Replace("\0", "");
          }

        }

        // final
        return cadenaDesencriptada;

      }
      catch (Exception)
      {
        // heredar
        throw;
      }
    }

    /// <summary>
    /// Obtener el Algoritmo de cifrado
    /// </summary>
    /// <returns>Algortimo de cifrado</returns>
    private RijndaelManaged obtenerAlgoritmo() {
      
      Rfc2898DeriveBytes keyBuilder = new Rfc2898DeriveBytes(_claveSecreta, Encoding.Unicode.GetBytes(_claveHash));
      RijndaelManaged algorithm = new RijndaelManaged();

      try
      {

        // tamaño de la llave
        algorithm.KeySize = 256;

        // definir el vector (IV)
        algorithm.IV = keyBuilder.GetBytes(System.Convert.ToInt32(algorithm.BlockSize / (double)8));

        // definir la llave secreta
        algorithm.Key = keyBuilder.GetBytes(System.Convert.ToInt32(algorithm.KeySize / (double)8));

        // definir el modo relleno
        algorithm.Padding = PaddingMode.PKCS7;

        // final
        return algorithm;

      } catch (Exception) {
        // heredar
        throw;
      }
    }
  }
}
