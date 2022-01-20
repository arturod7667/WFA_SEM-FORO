using System;
using System.Collections.Generic;
using System.Text;

namespace WFA_SEMAF
{
    class Semaforo
    {
        private byte estado;

        public Semaforo()
        {
            // com rua1 = vd e rua2 = vm - situação inicial
        }

        public void setVerde(int rua)
        {
        }

        public void setAmarelo(int rua)
        {
        }

        public void setVermelho(int rua)
        {
        }

        public byte getEstado()
        {
            return this.estado;
        }

        public int getEstado(int rua)
        {
            // 1. Vd - 2. Am - 3. Vm
            byte aux = 0;
            return aux;
        }
    }

}
