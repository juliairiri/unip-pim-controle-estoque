﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;
using Logica;
using System.Data;

namespace Servico
{
    public class Servico : IServico
    {
        #region Operações do Usuário

        public Entidades.Usuario ObterUsuarioPorCodigo(string codigo)
        {
            return Logica.Usuario.ObterUsuarioPorCodigo(codigo);
        }

        public Entidades.Usuario Autenticar(string codigo, string senha)
        {
            return Logica.Usuario.Autenticar(codigo, senha);
        }

        public void AlterarSenha(ref Entidades.Usuario usuario, string senha)
        {
            Logica.Usuario.AlterarSenha(ref usuario, senha);
        }

        public void InserirUsuario(ref Entidades.Usuario usuario)
        {
            Logica.Usuario.Inserir(ref usuario);
        }

        public void AlterarUsuario(ref Entidades.Usuario usuario)
        {
            Logica.Usuario.Alterar(ref usuario);
        }

        public void DeletarUsuario(Entidades.Usuario usuario)
        {
            Logica.Usuario.Deletar(usuario);
        }

        #endregion

        #region Operações da Unidade de Medida

        public Entidades.Unidade ObterUnidadePorCodigo(string codigo)
        {
            return Logica.Unidade.ObterUnidadePorCodigo(codigo);
        }

        public Entidades.Unidade[] ObterListaUnidades()
        {
            return Logica.Unidade.ObterListaUnidades();
        }

        public void InserirUnidade(ref Entidades.Unidade unidade)
        {
            Logica.Unidade.Inserir(ref unidade);
        }

        public void AlterarUnidade(ref Entidades.Unidade unidade)
        {
            Logica.Unidade.Alterar(ref unidade);
        }

        #endregion

        #region Operações do Produto

        public Entidades.Produto ObterProdutoPorCodigo(string codigo)
        {
            return Logica.Produto.ObterProdutoPorCodigo(codigo);
        }

        public void InserirProduto(ref Entidades.Produto produto)
        {
            Logica.Produto.Inserir(ref produto);
        }

        public void AlterarProduto(ref Entidades.Produto produto)
        {
            Logica.Produto.Alterar(ref produto);
        }

        #endregion
    }
}