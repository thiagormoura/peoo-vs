using System;
using System.Collections.Generic;
using System.Text;

namespace questao1_lista4
{
    class Abastecimento
    {
        private double ValorLitro;
        private double ValorPago;
        private double KmRodados;
        public void SetValorLitro(double ValorLitro)
        {
            if (ValorLitro > 0) this.ValorLitro = ValorLitro;
        }
        public void SetValorPago(double ValorPago)
        {
            if (ValorPago > 0) this.ValorPago = ValorPago;
        }
        public void SetKmRodados(double KmRodados)
        {
            if (KmRodados > 0) this.KmRodados = KmRodados;
        }
        public double MediaKmLitro()
        {
            double numLitros = ValorPago / ValorLitro ;
            return KmRodados / numLitros;
        }
        public double MediaReaisKm()
        {
            return ValorPago / KmRodados;
        }
    }
}
