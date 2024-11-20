using System.ComponentModel;

namespace SGComserv.Enums;

public enum ECstCofins
{
    [Description("* - Todos os Registros")]
    Item00 = 0,
    [Description("01 - Operação Tributável com Alíquota Básica")]
    Item01 = 1,
    [Description("02 - Operação Tributável com Alíquota Diferenciada")]
    Item02 = 2,
    [Description("03 - Operação Tributável com Alíquota por Unidade de Medida de Produto")]
    Item03 = 3,
    [Description("04 - Operação Tributável Monofásica - Revenda a Alíquota Zero")]
    Item04 = 4,
    [Description("05 - Operação Tributável por Substituição Tributária")]
    Item05 = 5,
    [Description("06 - Operação Tributável com Alíquota Zero")]
    Item06 = 6,
    [Description("07 - Operação Isenta da Contribuição")]
    Item07 = 7,
    [Description("08 - Operação sem Incidência da Contribuição")]
    Item08 = 8,
    [Description("09 - Operação com Suspensão da Contribuição")]
    Item09 = 9,
    [Description("49 - Outras Operações de Saída")]
    Item49 = 49,
    [Description("50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno")]
    Item50 = 50,
    [Description("51 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno")]
    Item51 = 51,
    [Description("52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação")]
    Item52 = 52,
    [Description("53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno")]
    Item53 = 53,
    [Description("54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação")]
    Item54 = 54,
    [Description("55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação")]
    Item55 = 55,
    [Description("56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação")]
    Item56 = 56,
    [Description("60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno")]
    Item60 = 60,
    [Description("61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno")]
    Item61 = 61,
    [Description("62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação")]
    Item62 = 62,
    [Description("63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno")]
    Item63 = 63,
    [Description("64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação")]
    Item64 = 64,
    [Description("65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação")]
    Item65 = 65,
    [Description("66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação")]
    Item66 = 66,
    [Description("67 - Crédito Presumido - Outras Operações")]
    Item67 = 67,
    [Description("70 - Operação de Aquisição sem Direito a Crédito")]
    Item70 = 70,
    [Description("71 - Operação de Aquisição com Isenção")]
    Item71 = 71,
    [Description("72 - Operação de Aquisição com Suspensão")]
    Item72 = 72,
    [Description("73 - Operação de Aquisição a Alíquota Zero")]
    Item73 = 73,
    [Description("74 - Operação de Aquisição sem Incidência da Contribuição")]
    Item74 = 74,
    [Description("75 - Operação de Aquisição por Substituição Tributária")]
    Item75 = 75,
    [Description("98 - Outras Operações de Entrada")]
    Item98 = 98,
    [Description("99 - Outras Operações")]
    Item99 = 99,
}
