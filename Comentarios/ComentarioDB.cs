using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Comentarios
{
    public class ComentarioDB
    {
        public static void GuardarArchivo(List<Comentario> comentarios, string path)
        {
            StreamWriter textOut = null;

            try
            {
                textOut = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));
                foreach (var c in comentarios)
                {
                    textOut.Write(c.Ip + "|");
                    textOut.Write(c.Id + "|");
                    textOut.Write(c.Autor + "|");
                    textOut.Write(c.Fecha + "|");
                    textOut.Write(c.comentario + "|");
                    textOut.Write(c.Likes + "|");
                    textOut.WriteLine(c.Inapropiado);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (textOut != null)
                {
                    textOut.Close();
                }
            }
        }

        public static void NuevoComentario(Comentario c, string path)
        {
            StreamWriter textOut = null;
            try
            {
                textOut = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write));
                    textOut.Write(c.Ip + "|");
                    textOut.Write(c.Id + "|");
                    textOut.Write(c.Autor + "|");
                    textOut.Write(c.Fecha + "|");
                    textOut.Write(c.comentario + "|");
                    textOut.Write(c.Likes + "|");
                    textOut.WriteLine(c.Inapropiado);

            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (textOut != null)
                {
                    textOut.Close();
                }
            }
        }

        public static List<Comentario> LeerArchivo(string path)
        {
            List<Comentario> comentarios = new List<Comentario>();

            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            try
            {
                while (textIn.Peek() != -1) //Leer hasta el final
                {
                    string renglon = textIn.ReadLine();
                    string[] columnas = renglon.Split('|');
                    Comentario c = new Comentario();

                    c.Ip = columnas[0];
                    c.Id = int.Parse(columnas[1]);
                    c.Autor = columnas[2];
                    c.Fecha = DateTime.Parse(columnas[3]);
                    c.comentario = columnas[4];
                    c.Likes = int.Parse(columnas[5]);
                    c.Inapropiado = int.Parse(columnas[6]);
                    comentarios.Add(c);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                textIn.Close();
            }

            return comentarios;
        }

        public static List<Comentario> filtro_likes(string path)
        {
            List<Comentario> comentarios;
            List<Comentario> filtro_likes = new List<Comentario>();

            try
            {
                comentarios = LeerArchivo(path);

                var filtro = from c in comentarios
                             orderby c.Likes descending
                             select c;
                foreach (var c in filtro)
                {
                    filtro_likes.Add(c);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return filtro_likes;
        }

        public static List<Comentario> filtro_fecha(string path)
        {
            List<Comentario> comentarios;
            List<Comentario> filtro_fecha = new List<Comentario>();

            try
            {
                comentarios = LeerArchivo(path);

                var filtro = from c in comentarios
                             orderby c.Fecha descending
                             select c;
                foreach (var c in filtro)
                {
                    filtro_fecha.Add(c);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return filtro_fecha;
        }
    }
}
