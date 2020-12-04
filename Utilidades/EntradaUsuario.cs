#region Encabezo de comentarios
// ===++===
//
//	OrtizOL
//
// ===--===
/*============================================================
//
// Clase: InputBox.cs
//
// Propósito: Diálogo de captura de entrada de usuario.
//
============================================================*/
#endregion

using System;
using System.Windows.Forms;
using System.Drawing;

namespace N1_SimuladorBancario.Utilidades
{
    /// <summary>
    /// Clase que contiene métodos de ayuda para los controles personalizados.
    /// </summary>
    public static class Ayudante
    {
        /// <summary>
        /// Captura la entrada del usuario por medio de un formulario simple.
        /// </summary>
        /// <param name="titulo">Título de la ventana de captura de texto.</param>
        /// <param name="texto">Texto guía para la entrada del usuario.</param>
        /// <param name="valor">Texto de captura.</param>
        /// <returns></returns>
        public static DialogResult InputBox(string titulo, string texto, ref string valor)
        {
            Form frmEntrada = new Form();
            Label lblEtiqueta = new Label();
            TextBox textBox = new TextBox();
            Button btnOK = new Button();
            Button btnCancelar = new Button();

            frmEntrada.Text = titulo;
            lblEtiqueta.Text = texto;
            textBox.Text = valor;

            btnOK.Text = "OK";
            btnCancelar.Text = "Cancelar";
            btnOK.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;

            lblEtiqueta.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            btnOK.SetBounds(228, 72, 75, 23);
            btnCancelar.SetBounds(309, 72, 75, 23);

            lblEtiqueta.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            frmEntrada.ClientSize = new Size(396, 107);
            frmEntrada.Controls.AddRange(new Control[] { lblEtiqueta, textBox, btnOK, btnCancelar });
            frmEntrada.ClientSize = new Size(Math.Max(300, lblEtiqueta.Right + 10), frmEntrada.ClientSize.Height);
            frmEntrada.FormBorderStyle = FormBorderStyle.FixedDialog;
            frmEntrada.StartPosition = FormStartPosition.CenterScreen;
            frmEntrada.MinimizeBox = false;
            frmEntrada.MaximizeBox = false;
            frmEntrada.AcceptButton = btnOK;
            frmEntrada.CancelButton = btnCancelar;

            DialogResult dialogResult = frmEntrada.ShowDialog();
            valor = textBox.Text;
            return dialogResult;
        }
    }
}