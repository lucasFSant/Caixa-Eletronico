﻿using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico
{
    public sealed class Singleton
    {
        private Singleton(){
            contas = new List<Conta>() { new CCorrente("123", 200), new CPoupanca("1") };
        }

        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public List<Conta> contas;
        public Conta conta_logada; 

        public Conta BuscarConta(string numero)
        {
            Conta c = contas.Find(c => c.Numero == numero);

            return c;
        }
    }
}
