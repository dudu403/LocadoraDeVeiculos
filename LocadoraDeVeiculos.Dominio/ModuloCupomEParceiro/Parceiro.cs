﻿namespace LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro
{
    public class Parceiro : EntidadeBase<Parceiro>
    {
        public string nome { get; set; }

        public override void AtualizarInformacoes(Parceiro registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}