namespace LMFinanciamentos.Entidades
{
    public class Processo
    {
        #region processo
        public string Id_processo { get; set; }
        public string Id_responsavel { get; set; }
        public string Nome_responsavel { get; set; }
        public string Permission_responsavel { get; set; }
        public string Data_processo { get; set; }
        public string Obs_processo { get; set; }
        public string StatusCPF_cliente { get; set; }
        public string StatusCiweb_cliente { get; set; }
        public string StatusCadmut_cliente { get; set; }
        public string StatusIR_cliente { get; set; }
        public string StatusFGTS_cliente { get; set; }
        public string StatusAnalise_cliente { get; set; }
        public string StatusEng_cliente { get; set; }
        public string SaqueFGTS_cliente { get; set; }
        public string SIOPI_cliente { get; set; }
        public string SICTD_cliente { get; set; }
        public string StatusPA_cliente { get; set; }
        public string Status_processo { get; set; }
        public string H_id { get; set; }
        public string H_idprocesso { get; set; }
        public string H_idresponsavel { get; set; }
        public string H_DataStatusCPF { get; set; }
        public string H_DataStatusCiweb { get; set; }
        public string H_DataStatusCadmut { get; set; }
        public string H_DataStatusIR { get; set; }
        public string H_DataStatusFGTS { get; set; }
        public string H_DataStatusAnalise { get; set; }
        public string H_DataStatusEng { get; set; }
        public string H_DataSaqueFGTS { get; set; }
        public string H_DataSIOP { get; set; }
        public string H_DataSICTD { get; set; }
        public string H_DataPA { get; set; }
        public string H_DataStatusCartorio { get; set; }
        public string H_DataStatus { get; set; }



        #endregion

        #region Cliente

        public string Id_cliente { get; set; }
        public string Nome_cliente { get; set; }
        public string Email_cliente { get; set; }
        public string Telefone_cliente { get; set; }
        public string Celular_cliente { get; set; }
        public string CPF_cliente { get; set; }
        public string RG_cliente { get; set; }
        public string Renda_cliente { get; set; }
        public string Nascimento_cliente { get; set; }
        public string Agencia_cliente { get; internal set; }
        public string Conta_cliente { get; internal set; }
        #endregion

        #region vendedor
        public string Id_vendedor { get; set; }
        public string Nome_vendedor { get; set; }
        public string Email_vendedor { get; set; }
        public string Telefone_vendedor { get; set; }
        public string Celular_vendedor { get; set; }
        public string CPF_vendedor { get; set; }
        public string CNPJ_vendedor { get; set; }
        public string Renda_vendedor { get; set; }
        public string Nascimento_vendedor { get; set; }
        public string Agencia_vendedor { get; internal set; }
        public string Conta_vendedor { get; internal set; }

        #endregion

        #region Imovel
        public string Id_corretora { get; set; }
        public string Id_corretor { get; set; }
        public string Descricao_corretora { get; set; }
        public string Nome_corretor { get; set; }
        public string AgenciaImovel_imovel { get; set; }
        public string Id_AgenciaImovel { get; set; }
        public string Programa_imovel { get; set; }
        public string Id_Programa { get; set; }
        public string EmpDescricao_imovel { get; set; }
        public string id_Empreendimentos_imovel { get; set; }

        public string Valor_imovel { get; set; }
        public string ValorFinanciado_imovel { get; set; }





        #endregion

        #region Cartorio
        public string id_Carftorio { get; set; }
        public string Descricao_Carftorio { get; set; }
        public string end_Cartorio { get; set; }
        public string StatusCartorio { get; set; }



        #endregion







        public int Cont { get; internal set; }




        //public string Permision { get; set; }

        //public byte[] Foto_cliente { get; set; }

        public string GetId()
        {
            return Id_processo;
        }
    }
}
