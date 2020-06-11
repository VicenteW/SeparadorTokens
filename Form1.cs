using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace SeparadorTokens3._0
{
    public partial class btnImpLex : Form
    {
        public btnImpLex()
        {
            InitializeComponent();
        }
        public static string[,] lexemas;
        bool tokens = false;
        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (tokens == true) { 
            string palabra = null;
            string sig;
            int parentesis = 0;
            int llaves = 0;
            int corchete = 0;
            bool errorcorchete = false;
            bool Parentesiserror = false;
            bool comillas = false;
            bool migual = false;
            bool llave = false;
            bool error = false;
            bool errorllave = false;
            Queue encontradas = new Queue();
            //Comienza el analisis linea por linea
            for (int j = 0; j < codigotxt.Lines.Count(); j++)
            {
                string lineacodigo = codigotxt.Lines[j];
                char[] separada = lineacodigo.ToCharArray();
                for (int i = 0; i < separada.Length; i++)
                {
                    switch (separada[i])
                    {
                        case ' ':
                            if (comillas == false)
                            {
                                if (palabra != null)
                                {
                                    BuscarDescripcion(palabra);
                                    palabra = null;
                                }
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;

                        case '+':
                        case '-':
                        case '*':
                        case '/':
                            if (comillas == false)
                            {
                                BuscarDescripcion(palabra);
                                palabra = null;
                                palabra = palabra + separada[i];
                                BuscarDescripcion(palabra);
                                palabra = null;
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;

                        case '=':
                            if (comillas == false)
                            {
                                if (migual == true)
                                {
                                    palabra = palabra + separada[i];
                                    BuscarDescripcion(palabra);
                                    palabra = null;
                                }
                                else
                                {
                                    BuscarDescripcion(palabra);
                                    palabra = null;
                                    palabra = palabra + separada[i];
                                    BuscarDescripcion(palabra);
                                    palabra = null;
                                }
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }

                            break;

                        case '<':
                            if (comillas == false)
                            {
                                migual = true;
                                BuscarDescripcion(palabra);
                                palabra = null;
                                palabra = palabra + separada[i];
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;

                        case '>':
                            if (comillas == false)
                            {
                                migual = true;
                                BuscarDescripcion(palabra);
                                palabra = null;
                                palabra = palabra + separada[i];
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;

                        case '.':
                            if (comillas == false)
                            {
                                if (separada[i - 1] == '1' || separada[i - 1] == '2' || separada[i - 1] == '3' || separada[i - 1] == '4' || separada[i - 1] == '5' || separada[i - 1] == '6' || separada[i - 1] == '7' || separada[i - 1] == '8' || separada[i - 1] == '9' || separada[i - 1] == '0')
                                {
                                    palabra = palabra + separada[i];
                                }
                                else
                                {
                                    BuscarDescripcion(palabra);
                                    palabra = null;
                                }
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;

                        case '(':
                            if (comillas == false)
                            {
                                if (palabra != null)
                                {
                                    BuscarDescripcion(palabra);
                                    palabra = null;
                                }
                                parentesis++;
                                palabra = palabra + separada[i];
                                BuscarDescripcion(palabra);
                                palabra = null;

                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;

                        case ')':
                            if (comillas == false)
                            {
                                if (parentesis != 0)
                                {
                                    if (palabra != null)
                                    {
                                        BuscarDescripcion(palabra);
                                        palabra = null;
                                    }

                                }
                                else
                                {
                                    Parentesiserror = true;
                                    if (palabra != null)
                                    {
                                        BuscarDescripcion(palabra);
                                        palabra = null;
                                    }
                                }
                                parentesis--;
                                palabra = palabra + separada[i];
                                BuscarDescripcion(palabra);
                                palabra = null;
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }


                            break;

                        case '[':
                            if (comillas == false)
                            {
                                corchete++;
                                BuscarDescripcion(palabra);
                                palabra = null;
                                palabra = palabra + separada[i];
                                BuscarDescripcion(palabra);
                                palabra = null;
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;

                        case ']':
                            if (comillas == false)
                            {
                                corchete--;
                                BuscarDescripcion(palabra);
                                palabra = null;
                                palabra = palabra + separada[i];
                                BuscarDescripcion(palabra);
                                palabra = null;
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;

                        case '"':
                            if (comillas == false)
                            {
                                comillas = true;
                                BuscarDescripcion(palabra);
                                palabra = null;
                                palabra = palabra + separada[i];
                                BuscarDescripcion(palabra);
                                palabra = null;
                            }
                            else
                            {
                                if (comillas == true)
                                {
                                    comillas = false;
                                    if (palabra != null)
                                    {
                                        BuscarDescripcion(palabra);
                                        palabra = null;
                                    }
                                    palabra = palabra + separada[i];
                                    BuscarDescripcion(palabra);
                                    palabra = null;
                                }
                            }
                            break;
                        case '{':
                            if (comillas == false)
                            {
                                if (llave == false)
                                {
                                    llave = true;
                                }
                                llaves++;
                                if (palabra != null)
                                {
                                    BuscarDescripcion(palabra);
                                    palabra = null;
                                }
                                palabra = palabra + separada[i];
                                BuscarDescripcion(palabra);
                                palabra = null;
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;
                        case '}':
                            if (comillas == false)
                            {
                                if (llave == true)
                                {
                                    llave = false;
                                }
                                else
                                {
                                    errorllave = true;
                                }
                                llaves--;
                                if (palabra != null)
                                {
                                    BuscarDescripcion(palabra);
                                    palabra = null;
                                }
                                palabra = palabra + separada[i];
                                BuscarDescripcion(palabra);
                                palabra = null;
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }
                            break;
                        case ';':
                            if (comillas == false)
                            {
                                if (i + 1 != separada.Length)
                                {

                                    if (comillas != true)
                                    {
                                        error = true;
                                    }
                                }
                                else
                                {
                                    if (palabra != null)
                                    {
                                        BuscarDescripcion(palabra);
                                        palabra = null;
                                    }
                                    if (parentesis != 0)
                                    {
                                        Parentesiserror = true;
                                    }
                                }
                            }
                            else
                            {
                                palabra = palabra + separada[i];
                            }

                            break;
                        default:
                            palabra = palabra + separada[i];
                            break;
                    }
                    //Termina el switch analizador+

                    if (i + 1 == separada.Length)
                    {
                        if (palabra != null)
                        {
                            BuscarDescripcion(palabra);
                            palabra = null;
                        }
                        if (error == true)
                        {
                            //IMPRIMIR ERROR DE PUNTO Y COMA EN MEDIO
                        }
                        if (separada[i] != ';')
                        {
                            if (separada[i] == '}')
                            {
                            }
                            else
                            {
                                //IMPRIMIR ERROR DE PUNTO Y COMA
                            }
                        }

                    }
                }//termina el for del renglon


            }//Termina el for del texto
        }//if de tokens
            else
            {
                MessageBox.Show("DEBE IMPORTAR PRIMERO EL ARCHIVO DE TOKENS");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                codigotxt.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        //BUSCAR DESCRIPCIÓN
        public void BuscarDescripcion(string palabra)
        {
            bool encon = false;
            for (int i=0; i<lexemas.GetLength(1); i++)
            {
                if (palabra != null && lexemas[0,i] != null)
                {
                    if (palabra.Equals(lexemas[0, i].ToString()))
                    {
                        dgvTokens.Rows.Add(palabra, lexemas[1, i]);
                        encon = true;
                        break;
                    }
                }
            }
            if(encon == false)
            {
                if (palabra != null)
                {
                    char[] variable = palabra.ToCharArray();
                    bool numerico = true;
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (variable[i] != '0' && variable[i] != '1' && variable[i] != '2' && variable[i] != '3' && variable[i] != '4' && variable[i] != '5' && variable[i] != '6' && variable[i] != '7' && variable[i] != '8' && variable[i] != '9')
                        {
                            numerico = false;
                        }
                        //SI ES UNA VARIABLE
                    }
                    if (numerico == true)
                    {
                        dgvTokens.Rows.Add(palabra, "Valor numerico");
                    }
                    if (numerico == false)
                    {
                        dgvTokens.Rows.Add(palabra, "Variable");
                    }

                }
            }
        }//Cierra el metodo de busqueda de descripción

        private void button1_Click(object sender, EventArgs e)
        {
            tokens = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                lexemastxt.Text = sr.ReadToEnd();
                sr.Close();
            }
            lexemas = new string[2, lexemastxt.Lines.Count()];
            for (int i=0; i<lexemastxt.Lines.Count(); i++)
            {
                //string[,] lexemas = new string[2, lexemastxt.Lines.Count()];
                string lexema = lexemastxt.Lines[i];
                bool div = false;
                string palabra = null;
                char[] arraylexema= lexema.ToCharArray();
                for(int j=0; j<arraylexema.Length; j++)
                {
                    if (arraylexema[j] != '-')
                    {
                        
                        if (div == true)
                        {
                            palabra = palabra + arraylexema[j];
                            
                        }else
                        {
                            palabra = palabra + arraylexema[j];
                        }
                    }
                    else
                    {
                        lexemas[0, i] = palabra;

                        div = true;
                        palabra = null;

                    }
                    
                }
                lexemas[1, i] = palabra;

            }
        }

        public void Llenargdv()
        {
            
        }

        private void dgvTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
