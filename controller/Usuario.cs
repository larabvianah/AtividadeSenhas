using System;
using System.Linq;
using System.Collections.Generic;
using Repository;
using System.Text.RegularExpressions;

namespace Controller
{
    public class Usuario
    {
        public static Model.Usuario CriarUsuario(
            string nome,
            string email,
            string senha
        )

        public static Model.Usuario AlterarUsuario(
            string id,
            string nome,
            string email,
            string senha
        )
        {
            try
            {
                int idUsuario = Int32.Parse(id);

                return Model.Usuario.AlterarUsuario(
                    idUsuario,
                    nome,
                    email,
                    senha
                );
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void ExcluirUsuario(
            string id
        )
        {
            try
            {
                int idUsuario = Int32.Parse(id);

                Model.Usuario.ExcluirUsuario(idUsuario);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static List<Model.Usuario> ListarUsuarios() {
            return Model.Usuario.ListarUsuarios();
        }


        public static Model.Usuario BuscarPorEmail(string email) {
            return Model.Usuario.BuscarPorEmail(email);
        }
    }   
}