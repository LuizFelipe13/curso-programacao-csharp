using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = ""; //tudo ok
        public bool acessar(String login, String senha)
        {
            LoginDalComandos loginDao = new LoginDalComandos();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public string cadastrando (String email, string senha, string confirmarsenha)
        {
            return mensagem;
        }
    }
}
