using System;
using System.Windows.Forms;
using CriptografiaSCD.utilidades;

namespace CriptografiaSCD
{
  public partial class Criptografia : Form
  {
    public Criptografia()
    {
      InitializeComponent();
    }

    #region "barra de herramientas"

    private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
      try
      {
        // verificar
        if (e.ClickedItem == tsbEncriptar) {

          // verificar
          if (tsbcbMenu.SelectedItem != null)
          {

            // verificar
            if (tsbcbMenu.SelectedItem.ToString().ToUpper() == "AES (RIJNDAEL)")
            {
              
            // encriptar y desencriptar
              EncriptarAES();

            }

            // verificar
            if (tsbcbMenu.SelectedItem.ToString().ToUpper() == "MD5")
            {

              // encriptar
              EncriptarMD5();

            }

            // verificar
            if (tsbcbMenu.SelectedItem.ToString().ToUpper() == "TRIPLEDES")
            {

              // encriptar y desencriptar
              Encriptar3DES();

            }

          }
          else
          {
            MessageBox.Show("Seleccione una opción de la lista Clase a utilizar.", Comun.AppNombre(), MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

        }
                ///

        if (e.ClickedItem == toolStripButton1)
        {
       
            // verificar
            if (tsbcbMenu.SelectedItem != null)
            {
       
                // verificar
                if (tsbcbMenu.SelectedItem.ToString().ToUpper() == "AES (RIJNDAEL)")
                {

                    // desencriptar
                    DesencriptarAES();
       
                }       
                // verificar
                if (tsbcbMenu.SelectedItem.ToString().ToUpper() == "TRIPLEDES")
                {

                     // encriptar y desencriptar
                     Desencriptar3DES();
       
                }
       
            }
            else
            {
                MessageBox.Show("Seleccione una opción de la lista Clase a utilizar.", Comun.AppNombre(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

                // verificar
                if (e.ClickedItem == tsbLimpiar)
        {
          // limpiar
          txtResultado.Text = "";
          txtError.Text = "";
        }
      }
      catch (Exception Ex)
      {
        // mostrar mensaje
        txtError.Text = Ex.Message.ToString();
      }

    }

    #endregion 

    #region "criptografia"

    private void EncriptarAES()
    {

      CriptoAES udtCriptoAES;
      string sEncriptado;
      string sDesencriptado;

      try
      {
        txtResultado.Text += "[Encriptar  datos con AES (Rijndael)]" + "\r\n\r\n";

        // instanciar clase
        udtCriptoAES = new CriptoAES(txtAESClaveSecreta.Text, txtAESClaveHash.Text);

        // encriptar
        sEncriptado = udtCriptoAES.Encriptar(txtAEncriptar.Text);

        // mostrar datos
        txtResultado.Text += "[Información encriptada]" + "\r\n";
        txtResultado.Text += sEncriptado + "\r\n\r\n";

      }
      catch (Exception Ex)
      {
        // mostrar mensaje
        txtError.Text = Ex.Message.ToString();
      }

    }
        private void DesencriptarAES()
        {

            CriptoAES udtCriptoAES;
            string sEncriptado;
            string sDesencriptado;

            try
            {
                txtResultado.Text += "[Encriptar y desencriptar datos con AES (Rijndael)]" + "\r\n\r\n";

                // instanciar clase
                udtCriptoAES = new CriptoAES(txtAESClaveSecreta.Text, txtAESClaveHash.Text);

                // desencriptar
                sDesencriptado = udtCriptoAES.Desencriptar(txtAEncriptar.Text);

                // mostrar datos
                txtResultado.Text += "[Información desencriptada]" + "\r\n";
                txtResultado.Text += sDesencriptado + "\r\n\r\n";

            }
            catch (Exception Ex)
            {
                // mostrar mensaje
                txtError.Text = Ex.Message.ToString();
            }
        }


    private void EncriptarMD5(){

      string sEncriptado;

      try
      {
        txtResultado.Text += "[Encriptar datos con MD5]" + "\r\n\r\n";

        // encriptar
        sEncriptado = CriptoMD5.Encriptar(txtAEncriptar.Text);

        // mostrar datos
        txtResultado.Text += "[Información encriptada]" + "\r\n";
        txtResultado.Text += sEncriptado + "\r\n\r\n";

      }
      catch (Exception Ex)
      {
        // mostrar mensaje
        txtError.Text = Ex.Message.ToString();
      }

    }


    private void Encriptar3DES()
    {
      Cripto3DES udtCripto3DES;
      string sEncriptado;
      string sDesencriptado;

      try
      {
        txtResultado.Text += "[Encriptar y desencriptar datos con TripleDES]" + "\r\n\r\n";

        // instanciar clase
        udtCripto3DES = new Cripto3DES(txt3DesClaveHash.Text);

        // encriptar
        sEncriptado = udtCripto3DES.Encriptar(txtAEncriptar.Text);

        // mostrar datos
        txtResultado.Text += "[Información encriptada]" + "\r\n";
        txtResultado.Text += sEncriptado + "\r\n\r\n";
      }
      catch (Exception Ex)
      {
        // mostrar mensaje
        txtError.Text = Ex.Message.ToString();
      }

    }

    private void Desencriptar3DES()
    {

        Cripto3DES udtCripto3DES;
        string sDesencriptado;

        try
        {
            txtResultado.Text += "[desencriptar datos con TripleDES]" + "\r\n\r\n";

            // instanciar clase
            udtCripto3DES = new Cripto3DES(txt3DesClaveHash.Text);
            // desencriptar
            sDesencriptado = udtCripto3DES.Desencriptar(txtAEncriptar.Text);

            // mostrar datos
            txtResultado.Text += "[Información desencriptada]" + "\r\n";
            txtResultado.Text += sDesencriptado + "\r\n\r\n";

        }
        catch (Exception Ex)
        {
            // mostrar mensaje
            txtError.Text = Ex.Message.ToString();
        }

    }

        #endregion

        private void Criptografia_Load(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
