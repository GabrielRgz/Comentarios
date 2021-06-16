using System;
using System.Collections.Generic;

namespace Comentarios
{
    public class Comentario
    { 
        public int Id { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }
        public string comentario { get; set; }
        public string Ip { get; set; }
        public int Inapropiado { get; set; }
        public int Likes { get; set; }

        public Comentario()
        { 
        }

        public Comentario(string ip, int id, string autor, DateTime fecha, string comentario, int likes, int inapropiado)
        {
            Ip = ip;
            Id = id;
            Autor = autor;
            Fecha = fecha;
            this.comentario = comentario;
            Likes = likes;
            Inapropiado = inapropiado;
        }

        public override string ToString()
        {
            return String.Format("\n" + $"> {Autor}:" + "\n" + comentario + "\n" + $"Likes: {Likes} Inapropiado: {Inapropiado} Publicado: {Fecha}" + "\n");
        }
    }
}
