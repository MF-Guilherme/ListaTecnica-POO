using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaTecnica.Models;

namespace ListaTecnica.Models
{
    public class Caderno
    {
        public int Id { get; set; }
        public string NomeCaderno { get; set; }
        public int Tiragem { get; set; }
        public int QtdPaginas { get; set; }
        public int ExsPorGiro { get; set; }
        public string TipoDePapel { get; set; }
        public int Gramatura { get; set; }
        public int Bobina { get; set; }
        public int CutoffP { get; set; }
        public int CutoffN { get; set; }
        public int DesperdicioAcerto { get; set; }
        public double DesperdicioImpressaoP { get; set; }
        public double DesperdicioImpressaoN { get; set; }
        public double DesperdicioAcabamentoP { get; set; }
        public double DesperdicioAcabamentoN { get; set; }
        public double KgLiquido { get; set; }
        public double UnitarioLiquido { get; set; }
        public double UnitarioBruto { get; set; }
        public double KgBrutoP { get; set; }
        public double KgBrutoN { get; set; }

        public Caderno(int id, string nomeCaderno, int tiragem, int qtdPaginas, int exsPorGiro, string tipoDePapel, int gramatura, int bobina, int cutoffP, int cutoffN, int desperdicioAcerto, double desperdicioImpressaoP, double desperdicioImpressaoN, double desperdicioAcabamentoP, double desperdicioAcabamentoN, double kgLiquido, double unitarioLiquido, double unitarioBruto, double kgBrutoP, double kgBrutoN)
        {
            Id = id;
            NomeCaderno = nomeCaderno;
            Tiragem = tiragem;
            QtdPaginas = qtdPaginas;
            ExsPorGiro = exsPorGiro;
            TipoDePapel = tipoDePapel;
            Gramatura = gramatura;
            Bobina = bobina;
            CutoffP = cutoffP;
            CutoffN = cutoffN;
            DesperdicioAcerto = DesperdicioDeAcerto();
            DesperdicioImpressaoP = DesperdicioDeImpressaoP();
            DesperdicioImpressaoN = desperdicioImpressaoN;
            DesperdicioAcabamentoP = desperdicioAcabamentoP;
            DesperdicioAcabamentoN = desperdicioAcabamentoN;
            KgLiquido = kgLiquido;
            UnitarioLiquido = unitarioLiquido;
            UnitarioBruto = unitarioBruto;
            KgBrutoP = kgBrutoP;
            KgBrutoN = kgBrutoN;
        }

        private int DesperdicioDeAcerto()
        {
            //=SE(B5<25000;(27000-B5)/M5;PROCV(L5;'Desp. Plural'!$D$7:$F$29;3;0))
            if (Tiragem < 25000)
            {
                return (27000 - Tiragem) / ExsPorGiro;
            }
            return 2000;
        }

        private double DesperdicioDeImpressaoP()
        {
            double percentualCadernoPadrao = 0.0;

            //tentar um switch case

            return percentualCadernoPadrao;
        }


    }
}
