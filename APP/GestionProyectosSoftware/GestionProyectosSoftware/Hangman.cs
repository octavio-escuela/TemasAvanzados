﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionProyectosSoftware
{
    public partial class Hangman : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        char[] PalabrasAdivinidas; int Oportunidades; int value;
        char[] PalabraSeleccionada;
        char[] Alfabeto;
        String[] Palabras;

        public Hangman()
        {
            InitializeComponent();
        }
        public void IniciarJuego()
        {
            layoutLetras.Controls.Clear();
            layoutLetras.Enabled = true;
            ahorcadoPB.Image = null;
            lblperdiste.Visible = false;
            Oportunidades = 0;
            value = 0;
            botoninicio.Image = Properties.Resources.rojo;
            Palabras = new string[] {"Programa","Escuela" };
            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            Random rnd = new Random();
            int IndicePalabraSeleccionada = rnd.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasAdivinidas = PalabraSeleccionada;

            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button letra = new Button();
                letra.Tag = "";
                letra.Text = LetraAlfabeto.ToString();
                letra.Width = 60;
                letra.Height = 40;
                letra.Click += Compara;
                letra.ForeColor = Color.White;
                letra.Font = new Font(letra.Font.Name, 15, FontStyle.Bold);
                letra.BackgroundImageLayout = ImageLayout.Center;
                letra.BackColor = Color.Black;
                letra.Name = LetraAlfabeto.ToString();
                layoutLetras.Controls.Add(letra);
            }

            layoutPalabra.Controls.Clear();

            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
            {
                Button word = new Button();
                word.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                word.Width = 46;
                word.Height = 80;
                word.ForeColor = Color.Aqua;
                word.Text = "-";
                word.Font = new Font(word.Font.Name, 32, FontStyle.Bold);
                word.BackgroundImageLayout = ImageLayout.Center;
                word.BackColor = Color.White;
                word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                word.Name = "Adivinado" + IndiceValorLetra.ToString();
                word.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.azul));
                layoutPalabra.Controls.Add(word);
            }
        }

        void Compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            for (int IndiceRevisar = 0; IndiceRevisar < PalabrasAdivinidas.Length; IndiceRevisar++)
            {
                if (PalabrasAdivinidas[IndiceRevisar] == Char.Parse(btn.Text))
                {
                    Button tbx = this.Controls.Find("Adivinado" + IndiceRevisar, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinidas[IndiceRevisar].ToString();
                    PalabrasAdivinidas[IndiceRevisar] = '-';
                    encontrado = true;
                }
            }

            bool ganaste = true;

            for (int gano = 0; gano < PalabrasAdivinidas.Length; gano++)
            {
                if (PalabrasAdivinidas[gano] != '-')
                {
                    ganaste = false;
                }
            }

            if(ganaste) 
            { 
                MessageBox.Show("Ganaste"); botoninicio.Image = Properties.Resources.verde;
                if (Oportunidades == 0)
                {
                    value = 10;
                }
                if (Oportunidades == 1)
                {
                    value = 8;

                }
                if (Oportunidades == 2)
                {
                    value = 6;

                }
                if (Oportunidades == 3)
                {
                    value = 4;

                }
                if (Oportunidades == 4)
                {
                    value = 3;

                }
                if (Oportunidades == 5)
                {
                    value = 2;
                }
                if (Oportunidades == 6)
                {
                    value = 1;
                }
                try
                {
                    connection.Open();
                    SqlCommand altas = new SqlCommand("UPDATE Letras set Puntos_Letras = ( Puntos_Letras + @value) WHERE Id_Letras = @Id_Letras", connection);
                    altas.Parameters.AddWithValue("value", value);
                    altas.Parameters.AddWithValue("Id_Letras", global.id_user);
                    altas.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    connection.Close();
                }

            }
            
            if(!encontrado)
            {
                Oportunidades = Oportunidades + 1;
                ahorcadoPB.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + Oportunidades);
                if(Oportunidades == 7)
                {
                    lblperdiste.Visible = true;
                    for (int i = 0; i < PalabraSeleccionada.Length; i++)
                    {
                        Button let = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                        let.Text = let.Tag.ToString();
                    }

                    layoutLetras.Enabled = false;
                    botoninicio.Image = Properties.Resources.verde;
                }
            }
        }
        private void Hangman_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void botoninicio_Click(object sender, EventArgs e)
        {
            IniciarJuego();
            veces_jugas();
        }

        public void veces_jugas()
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Letras set Veces_Jugadas = (Veces_Jugadas + 1) WHERE Id_Letras = @Id_Letras", connection);
                altas.Parameters.AddWithValue("Id_Letras", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Puntajes set promedio = c.Puntos_Colores + n.Puntos_Numeros + l.Puntos_Letras from Colores c, Numeros n, Letras l WHERE (c.Id_Colores = Puntajes.Id_Colores) AND (n.Id_Numeros = Puntajes.Id_Numeros) AND (l.Id_Letras = Puntajes.Id_Letras)", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }

            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Alumno set promedio = p.promedio from Puntajes p WHERE p.Id_Puntaje = Alumno.Id_Puntaje", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
