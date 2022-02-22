using System;
using System.Text;
using System.Security.Cryptography;

namespace CriptografiaSCD.utilidades
{

  class Cripto3DES
  {

    private readonly string _claveHash;
    
    /// <summary>
    /// Inicializa una nueva instancia de clase <see cref="Cripto3DES"/>, por medio de una palabra u oración que sirve de Clave Hash
    /// </summary>
    /// <param name="claveSecreta">Palabra u oración que sirve de Clave Hash</param>
    public Cripto3DES( string claveHash)
    {
      try
      {

        // asignar
        _claveHash = claveHash;

      } catch (Exception) {
        // heredar
        throw;
      }

    }



    /// <summary>
    /// Encriptar un texto
    /// </summary>
    /// <param name="cadenaAEncriptar">Texto a encriptar</param>
    /// <returns>Texto encriptado</returns>
    public string Encriptar(string cadenaAEncriptar)
    {

      TripleDESCryptoServiceProvider mTDCP = new TripleDESCryptoServiceProvider();
      MD5CryptoServiceProvider mMD5CP = new MD5CryptoServiceProvider();
      ICryptoTransform mITTmp;
      byte[] byteAEncriptar;
      byte[] byteEncriptados;
      string sResultado;

      try
      {

        // validar
        if (cadenaAEncriptar.Trim() == "")
        {

          sResultado = "";

        } else {

          // asignar llave calculando código hash
          mTDCP.Key = mMD5CP.ComputeHash(Encoding.UTF8.GetBytes(_claveHash));

          // elegir modo ECB
          mTDCP.Mode = CipherMode.ECB;

          // elegir modo padding
          mTDCP.Padding = PaddingMode.PKCS7;

          // crear motor para encriptar
          mITTmp = mTDCP.CreateEncryptor();

          // convertir a bytes el texto a encriptar
          byteAEncriptar = Encoding.UTF8.GetBytes(cadenaAEncriptar);

          // encriptar texto
          byteEncriptados = mITTmp.TransformFinalBlock(byteAEncriptar, 0, byteAEncriptar.Length);

          // convertir bytes a texto base 64
          sResultado = Convert.ToBase64String(byteEncriptados);

        }

        // final
        return sResultado;

      }
      catch (Exception)
      {
        // heredar
        throw;
      }

    }

    /// <summary>
    /// Desencriptar un texto encriptado
    /// </summary>
    /// <param name="cadenaEncriptada">Texto a encriptar</param>
    /// <returns>Texto desencriptado</returns>
    public string Desencriptar(string cadenaEncriptada)
    {
      TripleDESCryptoServiceProvider mTDCP = new TripleDESCryptoServiceProvider();
      MD5CryptoServiceProvider mMD5CP = new MD5CryptoServiceProvider();
      ICryptoTransform mITTmp;
      byte[] byteEncriptados;
      byte[] byteDesencriptados;
      string sResultado;
      try
      {
        // validar
        if (cadenaEncriptada.Trim() == "")
        {

          sResultado = "";

        }
        else
        {

          // asignar llave calculando código hash
          mTDCP.Key = mMD5CP.ComputeHash(Encoding.UTF8.GetBytes(_claveHash));

          // elegir modo ECB
          mTDCP.Mode = CipherMode.ECB;

          // elegir modo padding
          mTDCP.Padding = PaddingMode.PKCS7;

          // crear motor para desencriptar
          mITTmp = mTDCP.CreateDecryptor();

          // convertir a bytes el texto encriptado
          byteEncriptados = Convert.FromBase64String(cadenaEncriptada);

          // desencriptar texto
          byteDesencriptados = mITTmp.TransformFinalBlock(byteEncriptados, 0, byteEncriptados.Length);

          // convertir bytes a texto UTF8
          sResultado = Encoding.UTF8.GetString(byteDesencriptados);
        }

        // final
        return sResultado;

      }
      catch (Exception)
      {
        // heredar
        throw;
      }

    }

  }

}