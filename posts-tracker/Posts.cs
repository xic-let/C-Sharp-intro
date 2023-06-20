using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostTracker
{
    internal class Posts
    {
        //define as propriedades
        public DateTime moment {get; set;}
        public String title { get; set;}
        public String description { get; set;}
        public int likes { get; set; }
        public List<Comment> comments { get; set; } = new List<Comment>();
            // cria a lista de comentarios eliga à classe comment


        public Posts() { }

        public Posts(DateTime moment, string title, string description, int likes)
        {
            this.moment = moment;
            this.title = title;
            this.description = description;
            this.likes = likes;
        }

        //Sempre que existe uma lista devem sempre ser inseridos metodos de adição e remoção de laços da lista
        public void AddComment (Comment comment) 
        {
            comments.Add(comment);
        }

        public void RemoveComment (Comment comment)
        {
            comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            // usar a string builder para kdprecisamos de concatenar grandes quantidades de texto
            //torna o codigo mais facil para o compilador de interpretar o texto
            //é um classe e precisa de ser instanciada

            sb.AppendLine(title);
            sb.Append(likes);
            sb.AppendLine(" - Likes");
            sb.AppendLine(moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(description);
            sb.AppendLine("Comments: ");

            foreach (Comment comment in comments) //para adicionar todos os comentários da lista temos de fazer um foreach
            {
                sb.AppendLine(comment.content); //adiciona os comentários
            }
            return sb.ToString(); //vai retornar o conteudo de sb em forma de string
        }
    }
}
