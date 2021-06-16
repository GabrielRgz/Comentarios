using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comentarios
{
    public partial class Form1 : Form
    {
        string usuario;
        List<Comentario> comentarios = new List<Comentario>();
        //List<Comentario> comentariosLikes = new List<Comentario>();

        public void Escribir(List<Comentario> comentarios)
        {
            cuerpo.Text = "";
            comentarios = ComentarioDB.LeerArchivo(@"C:\Users\dell\comentarios.txt");
            foreach (var c in comentarios)
            {
                if (c.Inapropiado >= 5 && c.Inapropiado > c.Likes)
                {
                    c.comentario = "Este comentario se ocultó debido a que ha sido marcado como inapropiado";
                }
                cuerpo.Text += c;
            }
        }

        public void OrdenLikes(List<Comentario> comentarios)
        {
            comentarios.Clear();
            comentarios = ComentarioDB.filtro_likes(@"C:\Users\dell\comentarios.txt");
            ComentarioDB.GuardarArchivo(comentarios, @"C:\Users\dell\comentarios.txt");
            Escribir(comentarios);
        }
        public void OrdenFecha(List<Comentario> comentarios)
        {
            comentarios.Clear();
            comentarios = ComentarioDB.filtro_fecha(@"C:\Users\dell\comentarios.txt");
            ComentarioDB.GuardarArchivo(comentarios, @"C:\Users\dell\comentarios.txt");
            Escribir(comentarios);
        }

        public Form1()
        {
            InitializeComponent();
            comentarios.Add(new Comentario("127.65.13", 100, "Adan Ru", new DateTime(2021, 06, 03, 18, 32, 13), "Buenas tardes, me pareces muy aburrido", 1, 2));
            comentarios.Add(new Comentario("127.64.22", 101, "LuigiTime", new DateTime(2021, 03, 17, 9, 2, 52), "Ola, quien juega Warzone conmigo? Pasen discord", 7, 1));
            comentarios.Add(new Comentario("127.65.31", 102, "Angela123", new DateTime(2021, 01, 25, 12, 54, 12), "Felicidades, funciona hasta ahora:)", 12, 0));
            comentarios.Add(new Comentario("123.47.29", 103, "DanMan", new DateTime(2021, 05, 30, 19, 22, 07), "Que programa tan feo, mejor date de baja", 3, 6));
            ComentarioDB.GuardarArchivo(comentarios, @"C:\Users\dell\comentarios.txt");
            Escribir(comentarios);
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            usuario = userTxt.Text;
            Comentario comment = new Comentario("127.64.12", 104, usuario, DateTime.Now, comentarioTxt.Text, 0, 0);
            comentarios.Add(comment);
            ComentarioDB.NuevoComentario(comment, @"C:\Users\dell\comentarios.txt");
            Escribir(comentarios);
            comentarioTxt.Clear();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                OrdenLikes(comentarios);
            }
            if (listBox1.SelectedIndex == 1)
            {
                OrdenFecha(comentarios);
            }
        }
    }
}
