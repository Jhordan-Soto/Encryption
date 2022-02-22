using System;
using System.Windows.Forms;

namespace CriptografiaSCD.utilidades
{
  class Comun
  {

    /// <summary>
    /// Verificar si ya está en ejecucíón la aplicación
    /// </summary>
    /// <returns>Verdadero si ya está en ejecución y Falso si no está en ejecución</returns>
    public static bool AppEjecucion()
    {

      // verificar si ya se está ejecutando la aplicación
      // if (Information.UBound(System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName)) > 0)
      if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).GetUpperBound(0) > 0)
        return true;
      else
        return false;

    }

    ///
    /// <summary>
    /// Regresar la ruta en donde se está llamando la aplicación
    /// </summary>
    /// <returns>Regresar la ruta en donde está llamando la aplicación</returns>
    public static string AppRuta()
    {

      string sRuta = Application.StartupPath;

      try
      {

        // verificar
        if (sRuta.LastIndexOf("bin") > 0)
        {

          // recortar ruta
          sRuta = sRuta.Substring(0, sRuta.LastIndexOf("bin"));

        }
        else
        {

          // obtener ruta
          sRuta += @"\";

        }

        // final
        return sRuta;

      }
      catch (Exception)
      {
        // heredar
        throw;
      }

    }

    /// <summary>
    /// Regresar el nombre de la aplicación
    /// </summary>
    /// <returns>Regresar el nombre de la aplicación</returns>
    public static string AppNombre()
    {
      try
      {

        // nombre de la aplicación
        return "Encrypted";

      }
      catch (Exception)
      {
        // heredar
        throw;
      }

    }

  }

}