using System;
using PortalQualidade.Domain.Resources;
using PortalQualidade.Domain.ValueObjects;
using PortalQualidade.Helpers;

namespace PortalQualidade.Domain.Entities
{
    public class Usuario:EntityBase
    {
        public const int NomeMaxLenght = 100;
        public string Nome { get; private set; }
        public const int LoginMaxLenght = 50;
        public string Login { get; private set; }
        public Password Password { get; private set; }
        public Guid TokenAlteracao { get; private set; }
        public Email EMail { get; private set; }
        public const int DepartamentoMaxLenght = 60;
        public string Departamento { get; private set; }
        public bool Nivel { get; private set; }
        public bool Flag { get; private set; }

        //Contrutor EntityFramework
        protected Usuario(){}

        public Usuario(string nome, string email, string login, string password, string confirmaPassword, string departamento, bool nivel = false, bool flag = false)
        {
            SetNome(nome);
            SetEmail(email);
            SetLogin(login);
            SetPassword(password,confirmaPassword);
            SetDepartamento(departamento);
            Nivel = nivel;
            Flag = flag;
        }

        public void SetNome(string nome)
        {
            Guard.ForNullOrEmpty(nome,Errors.InvalidNome);
            Nome = nome;
        }

        public void SetLogin(string login)
        {
            Guard.ForNullOrEmpty(login,Errors.InvalidLogin);
            Login = login;
        }

        private void SetPassword(string password, string confirmaPassword)
        {
            Password = new Password(password, confirmaPassword);
        }

        public void SetEmail(string email)
        {
            EMail = new Email(email);
        }

        public void SetDepartamento(string departamento)
        {
            Departamento = departamento;
        }
    }
}
