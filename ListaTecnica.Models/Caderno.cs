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


        public Caderno(int id, string nomeCaderno, int tiragem, int qtdPaginas, int exsPorGiro, string tipoDePapel, int gramatura, int bobina, int cutoffP, double unitarioLiquido, double unitarioBruto, double kgBrutoP, double kgBrutoN)
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
            CutoffN = CutoffCliente();
            DesperdicioAcerto = DesperdicioDeAcerto();
            DesperdicioImpressaoP = DesperdicioDeImpressaoP();
            DesperdicioImpressaoN = DesperdicioDeImpressaoN();
            DesperdicioAcabamentoP = DesperdicioDeAcabamentoP();
            DesperdicioAcabamentoN = DesperdicioDeAcabamentoN();
            KgLiquido = KgsLiquido();
            UnitarioLiquido = UnitarioLiquidoKg();
            UnitarioBruto = UnitarioBrutoKg();
            KgBrutoP = TotalKgBrutoP();
            KgBrutoN = TotalKgBrutoN();
        }

        private int CutoffCliente()
        {
            if (CutoffP == 584)
            {
                return 584;
            }
            else if (CutoffP == 546)
            {
                return 575;
            }
            else
            {
                return 578;
            }
        }

        public int DesperdicioDeAcerto()
        {

            if (Tiragem < 25000)
            {
                return (27000 - Tiragem) / ExsPorGiro;
            }
            return 2000;
        }

        public double DesperdicioDeImpressaoP()
        {
            double percentualCadernoPadrao = 0.0;

            if (Bobina > 730)
            {
                percentualCadernoPadrao = 0.08;
            }
            else
            {
                percentualCadernoPadrao = 0.06;
            }

            return percentualCadernoPadrao;
        }

        public double DesperdicioDeImpressaoN()
        {
            if (Tiragem < 25000)
            {
                return DesperdicioDeImpressaoP();
            }
            else
            {
                return 0.04;
            }
        }

        public double DesperdicioDeAcabamentoP()
        {
            if (Tiragem < 25000)
            {
                return 900 / Tiragem;
            }
            else
            {
                return 0.02;
            }
        }


        #region teste outra forma de calcular o desperdicio acabamentoP
        //public double DesperdicioDeAcabamentoP(double refile, double acbto1, double acbto2, double acbto3, double acbto4)
        //{

        //    double desperdicioTotal = 0.02 + refile + acbto1 + acbto2 + acbto3 + acbto4;


        //    if (Tiragem < 25000 && refile == 0)
        //    {
        //        desperdicioTotal = (300 / Tiragem);

        //        return desperdicioTotal;
        //    }
        //    else if (Tiragem < 25000)
        //    {
        //        desperdicioTotal = (900 / Tiragem);

        //        return desperdicioTotal;
        //    }
        //    else
        //    {
        //        return desperdicioTotal;
        //    }
        //}
        #endregion


        public double DesperdicioDeAcabamentoN()
        {
            if (Tiragem < 25000)
            {
                return DesperdicioDeAcabamentoP();
            }
            else
            {
                return 0.04;
            }
        }

        #region teste outra forma de calcular o desperdicio acabamentoN
        //public double DesperdicioDeAcabamentoN(double refile, double acbto1, double acbto2, double acbto3, double acbto4)
        //{

        //    double desperdicioTotal = 0.04 + acbto1 + acbto2 + acbto3 + (acbto4 + 1.5);

        //    if (Tiragem < 25000)
        //    {
        //        return DesperdicioDeAcabamentoP(refile, acbto1, acbto2, acbto3, acbto4);
        //    }
        //    else
        //    {
        //        return desperdicioTotal;
        //    }


        //}
        #endregion

        public double KgsLiquido()
        {
            double resultado = (Bobina / 1000) * (CutoffN / 1000) * (Gramatura / 1000) * (Tiragem / 1000);

            return resultado;
        }

        public double UnitarioLiquidoKg()
        {
            return KgsLiquido() / Tiragem;
        }

        public double UnitarioBrutoKg()
        {
            return 0.0;
        }

        public double TotalKgBrutoP()
        {
            return ((Tiragem / ExsPorGiro) * (1.0 + DesperdicioDeAcabamentoP()) * (1.0 + DesperdicioDeImpressaoP()) + DesperdicioDeAcerto())*((CutoffP/1000) * (Bobina /1000) * (Gramatura / 1000));
        }

        public double TotalKgBrutoN()
        {
            return ((Tiragem / ExsPorGiro) * (1.0 + DesperdicioDeAcabamentoN()) * (1.0 + DesperdicioDeImpressaoN()) + DesperdicioDeAcerto()) * ((CutoffN / 1000) * (Bobina / 1000) * (Gramatura / 1000));
        }

    }
}
