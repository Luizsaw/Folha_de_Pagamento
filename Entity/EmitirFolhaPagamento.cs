using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjFolhaPagamento.Entity.BancodeDados;

namespace RHS_Folha_de_Pagamento.Entity
{
    internal class EmitirFolhaPagamento
    {
       
        private ListView ListView;
        private String[] textos;
        private BancoDados banco = new BancoDados();
        private string CaminhoPDF;
        public EmitirFolhaPagamento(ListView listView, String[] textos)
        {
            ListView = listView;
            this.textos = textos;
            string pastaDestino = @"C:\RHS_Folha_de_Pagamento\Folhas_de_Pagamento_Emitidas\";

            // Verifica se a pasta de destino existe, senão a cria
            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            CaminhoPDF = Path.Combine(pastaDestino, "folha-de-pagamento-" + this.textos[5] + ".pdf");
            CriarPDF(CaminhoPDF, listView);
        }
        //Emissao da folha de pagamento
        private void CriarPDF(string caminho, ListView listView)
        {
            try
            {
                using (var fs = new FileStream(caminho, FileMode.Create))
                {
                    using (var document = new Document())
                    {
                        var writer = PdfWriter.GetInstance(document, fs);

                        document.Open();
                        // Adicionar conteúdo ao documento PDF
                        gerarFolhaPagamentoPDF(document, listView, writer);
                        document.Close();
                        MessageBox.Show("PDF criado com sucesso!");
                        //guardando dados no banco de dados
                        banco.InserirFolhaPagamento(CaminhoPDF,int.Parse(textos[5]), textos[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar o PDF: {ex.Message}");
            }
        }
        private void gerarFolhaPagamentoPDF(Document document, ListView listView, PdfWriter writer)
        {
            // Adicionar título
            AdicionarParagrafoCentralizado(document, "Folha de Pagamento", FontFactory.GetFont(FontFactory.HELVETICA, 20));

            // Adicionar subtitulo
            AdicionarParagrafoCentralizado(document, textos[0], FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 20f, 755f, "Data da Emissão:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 105f, 755f, textos[1], FontFactory.GetFont(FontFactory.HELVETICA, 10));

            // Adicionar quebra de linha
            document.Add(new Chunk("\n"));

            //Informações do cabeçalho
            textoPanel(document, writer, 20f, 740f, "Empresa:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 70f, 740f, textos[2], FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 445f, 740f, "CNPJ:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 480f, 740f, textos[3], FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 20f, 720f, "Nome:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 55f, 720f, textos[4], FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 445f, 720f, "N.º Registro:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 505f, 720f, textos[5], FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 20f, 700f, "Cargo:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 55f, 700f, textos[6], FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 445f, 700f, "Admissão:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 495f, 700f, textos[7], FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 20f, 680f, "Departamento:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
            textoPanel(document, writer, 90f, 680f, textos[8], FontFactory.GetFont(FontFactory.HELVETICA, 10));

            // Adicionar quebra de linha
            document.Add(new Chunk("\n"));
            document.Add(new Chunk("\n"));
            document.Add(new Chunk("\n"));

            // Adicionar tabela para os dados do ListView
            CriarTabela(listView, document, writer);


            // Criar linhas
            CriarLinha(writer, 20f, 750f, 570f, 750f);
            CriarLinha(writer, 20f, 660f, 570f, 660f);


        }
        private void CriarTabela(ListView listView, Document doc, PdfWriter writer)
        {
            try
            {
                // Criar uma tabela com o mesmo número de colunas que o ListView
                PdfPTable table = new PdfPTable(listView.Columns.Count);

                //Posicao da tabela
                float posicaoX = 35f;
                float posicaoY = 650f;

                // Ajustar a largura das colunas
                float[] widths = new float[] { 8f, 3f, 4f, 4f };
                table.SetWidths(widths);
                table.TotalWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin; // Definir largura total com base na largura da página

                // Adicionar cabeçalhos da tabela
                foreach (ColumnHeader column in listView.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11f, iTextSharp.text.Font.NORMAL)));
                    // Ajustar tamanho da célula, fonte e cor de fundo
                    headerCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    // Remover bordas da célula
                    headerCell.Border = PdfPCell.NO_BORDER;
                    table.AddCell(headerCell);
                }

                // Adicionar linhas de dados (verifique se há itens no listView.Items antes de iterar)
                foreach (ListViewItem item in listView.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(subItem.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10f, iTextSharp.text.Font.NORMAL)));
                        // Ajustar aqui o tamanho da célula, fonte e cor de fundo
                        cell.BackgroundColor = BaseColor.WHITE;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        // Remover bordas da célula
                        cell.Border = PdfPCell.NO_BORDER;
                        table.AddCell(cell);
                    }
                }

                // Verificar se a largura total da tabela é maior que zero
                if (table.TotalWidth > 0)
                {
                    // Definir a posição absoluta da tabela no documento
                    table.WriteSelectedRows(0, -1, posicaoX, posicaoY, writer.DirectContent);

                }
                // Obter as coordenadas finais da tabela
                float tabelaXFinal = posicaoX + table.TotalWidth;
                float tabelaYFinal = (posicaoY - table.TotalHeight) - 100;

                //criar o panel da tabela
                CriarLinhaPanel(writer, posicaoX, posicaoY, tabelaXFinal, tabelaYFinal);

                //Informações do Panel
                textoPanel(doc, writer, tabelaXFinal - 510f, tabelaYFinal + 40f, "Base Cálculo IRRF", FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 485f, tabelaYFinal + 25f, textos[18], FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 510f, tabelaYFinal + 8f,"Faixa IRRF: " + textos[9], FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 410f, tabelaYFinal + 40f, "Sal. Contribuição INSS", FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 380f, tabelaYFinal + 25f, textos[10], FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 288f, tabelaYFinal + 40f, "Base FGTS", FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 278f, tabelaYFinal + 25f, textos[19], FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 290f, tabelaYFinal + 8f, "FGTS: " + textos[11], FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 195f, tabelaYFinal + 60f, "Total Vencimentos", FontFactory.GetFont(FontFactory.HELVETICA, 8));
                textoPanel(doc, writer, tabelaXFinal - 186f, tabelaYFinal + 45f, textos[12], FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 82f, tabelaYFinal + 60f, "Total Descontos", FontFactory.GetFont(FontFactory.HELVETICA, 8));
                textoPanel(doc, writer, tabelaXFinal - 78f, tabelaYFinal + 45f, textos[13], FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 150f, tabelaYFinal + 25f, "Salário Líquido", FontFactory.GetFont(FontFactory.HELVETICA, 12));
                textoPanel(doc, writer, tabelaXFinal - 135f, tabelaYFinal + 6f, textos[14], FontFactory.GetFont(FontFactory.HELVETICA, 12));

                //criar o panel inferior da tabela
                CriarPanelInferior(writer, posicaoX, posicaoY, tabelaXFinal, tabelaYFinal - 100f);

                //Informações do Panel inferiro da tabela
                textoPanel(doc, writer, tabelaXFinal - 510f, tabelaYFinal - 90f, "Banco:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 470f, tabelaYFinal - 90f, textos[15], FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 360f, tabelaYFinal - 90f, "Agência:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 310f, tabelaYFinal - 90f, textos[16], FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 250f, tabelaYFinal - 90f, "Conta:", FontFactory.GetFont(FontFactory.HELVETICA, 10));
                textoPanel(doc, writer, tabelaXFinal - 210f, tabelaYFinal - 90f, textos[17], FontFactory.GetFont(FontFactory.HELVETICA, 10));

                //criar linha no inferior da tabela
                criarlinhaInferior(writer, posicaoX, posicaoY, tabelaXFinal, tabelaYFinal - 120f);

                //Criar Campo para assinatura do funcionario e data
                textoPanel(doc, writer, tabelaXFinal - 510f, tabelaYFinal - 150f, "Assinatura: ", FontFactory.GetFont(FontFactory.HELVETICA, 12));
                textoPanel(doc, writer, tabelaXFinal - 82f, tabelaYFinal - 150f, "Data:     /     /     ", FontFactory.GetFont(FontFactory.HELVETICA, 12));


                //criar linha no inferior da tabela
                criarlinhaInferior(writer, posicaoX, posicaoY, tabelaXFinal, tabelaYFinal - 160f);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar a tabela: {ex.Message}");
            }
        }
        private void CriarLinha(PdfWriter writer, float x1, float y1, float x2, float y2)
        {
            // Obter o conteúdo do PDF a partir do PdfWriter
            PdfContentByte content = writer.DirectContent;

            // Definir o estilo da linha
            content.SetLineWidth(1f); // Largura da linha em pontos
            content.SetRGBColorStroke(1, 0, 0);

            // Traçar a linha no documento
            content.MoveTo(x1, y1);
            content.LineTo(x2, y2);
            content.Stroke();
        }
        private void CriarLinha(float x1, float y1, float x2, float y2, PdfWriter writer, BaseColor cor)
        {
            // Obter o conteúdo do PDF a partir do PdfWriter
            PdfContentByte content = writer.DirectContent;

            // Definir o estilo da linha
            content.SetLineWidth(1f); // Largura da linha em pontos
            content.SetRGBColorStroke(cor.R, cor.G, cor.B); // Cor da linha

            content.MoveTo(x1, y1);
            content.LineTo(x2, y2);
            content.Stroke();
        }
        private void CriarLinhaPanel(PdfWriter writer, float posicaoX, float posicaoY, float posicaoFinalX, float posicaoFinalY)
        {
            float margemEsquerda = posicaoX;
            float margemDireita = posicaoFinalX;
            float margemSuperior = posicaoY;
            float margemInferior = posicaoFinalY;

            BaseColor corLinha = new BaseColor(1, 0, 0);

            // Linha vertical esquerda
            CriarLinha(margemEsquerda, margemInferior, margemEsquerda, margemSuperior, writer, corLinha);
            // Linha vertical direita centro
            CriarLinha(margemEsquerda + 110f, margemInferior, margemEsquerda + 110f, margemInferior + 70f, writer, corLinha);
            // Linha vertical direita centro
            CriarLinha(margemEsquerda + 220f, margemInferior, margemEsquerda + 220f, margemSuperior, writer, corLinha);
            // Linha vertical direita centro
            CriarLinha(margemEsquerda + 305f, margemInferior, margemEsquerda + 305f, margemSuperior, writer, corLinha);
            // Linha horizontal centro
            CriarLinha(margemEsquerda, margemInferior + 70f, margemDireita, margemInferior + 70f, writer, corLinha);
            // Linha horizontal centro
            CriarLinha(margemEsquerda + 305f, margemInferior + 40f, margemDireita, margemInferior + 40f, writer, corLinha);
            // Linha horizontal centro
            CriarLinha(margemEsquerda, margemInferior + 20f, margemDireita, margemInferior + 20f, writer, corLinha);
            // Linha vertical direita centro
            CriarLinha(margemDireita - 105f, margemInferior + 40f, margemDireita - 105f, margemSuperior, writer, corLinha);
            // Linha vertical direita
            CriarLinha(margemDireita, margemInferior, margemDireita, margemSuperior, writer, corLinha);
            // Linha horizontal superior
            CriarLinha(margemEsquerda, margemSuperior, margemDireita, margemSuperior, writer, corLinha);
            // Linha horizontal inferior 
            CriarLinha(margemEsquerda, margemInferior, margemDireita, margemInferior, writer, corLinha);
        }
        private void CriarPanelInferior(PdfWriter writer, float posicaoX, float posicaoY, float posicaoFinalX, float posicaoFinalY)
        {
            float margemEsquerda = posicaoX;
            float margemDireita = posicaoFinalX;
            float margemSuperior = posicaoY;
            float margemInferior = posicaoFinalY;

            BaseColor corLinha = new BaseColor(1, 0, 0);

            // Linha vertical esquerda
            CriarLinha(margemEsquerda, margemInferior, margemEsquerda, margemSuperior, writer, corLinha);
            // Linha vertical direita
            CriarLinha(margemDireita, margemInferior, margemDireita, margemSuperior, writer, corLinha);
            // Linha horizontal superior
            CriarLinha(margemEsquerda, margemSuperior, margemDireita, margemSuperior, writer, corLinha);
            // Linha horizontal inferior 
            CriarLinha(margemEsquerda, margemInferior, margemDireita, margemInferior, writer, corLinha);
        }
        private void criarlinhaInferior(PdfWriter writer, float posicaoX, float posicaoY, float posicaoFinalX, float posicaoFinalY)
        {
            float margemEsquerda = posicaoX;
            float margemDireita = posicaoFinalX;
            float margemSuperior = posicaoY;
            float margemInferior = posicaoFinalY;

            BaseColor corLinha = new BaseColor(1, 0, 0);

            // Linha horizontal inferior 
            CriarLinha(margemEsquerda, margemInferior, margemDireita, margemInferior, writer, corLinha);
        }
        private void textoPanel(Document doc, PdfWriter writer, float posicaoX, float posicaoY, string texto, iTextSharp.text.Font fonte)
        {
            var paragrafo = new Paragraph(texto, fonte);


            // Obter o conteúdo do PDF a partir do PdfWriter
            PdfContentByte content = writer.DirectContent;

            // Posicionar o parágrafo usando o conteúdo
            content.MoveTo(posicaoX, posicaoY);
            ColumnText.ShowTextAligned(content, Element.ALIGN_LEFT, new Phrase(paragrafo), posicaoX, posicaoY, 0);


        }
        private void AdicionarParagrafo(Document document, string texto, iTextSharp.text.Font fonte, int alinhamento)
        {
            var paragrafo = new Paragraph(texto, fonte);
            paragrafo.Alignment = alinhamento;
            document.Add(paragrafo);
        }
        private void AdicionarParagrafoCentralizado(Document document, string texto, iTextSharp.text.Font fonte)
        {
            AdicionarParagrafo(document, texto, fonte, Element.ALIGN_CENTER);
        }    

    }
}
